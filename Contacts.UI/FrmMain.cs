using Contacts.UI.Core.Context;
using Contacts.UI.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace Contacts.UI
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        //todo floaw layout panel ekle )bır textbox bır buton eklemeö yenı bılgı gırısı)
        //todo arama icin farkli secenekler olsun

        private void FrmMain_Load(object sender, EventArgs e)
        {
            KisileriDoldur();
            DinamikComponentDoldur();
        }



        private void KisileriDoldur()
        {
            lstKisiListesi.Items.Clear();
            List<Contact> contacts = new List<Contact>();
            using (MyDBEntities db2 = new MyDBEntities())
            {
                contacts = db2.Contacts.OrderBy(a=>a.Name).ToList();
            }
            foreach (Contact contact in contacts)
            {
                lstKisiListesi.Items.Add(contact);
            }
        }
        public List<ConnectionType> TurleriDoldurCmbIcin()
        {
            List<ConnectionType> turler = null;
            using (MyDBEntities db = new MyDBEntities())
            {
                turler = db.ConnectionTypes.ToList();
            }
            return turler;
        }
        ComboBox cmb = null;
        TextBox txt = null;
        int ilaveTopDeger = 0;
        private void DinamikComponentDoldur()
        {
            cmb = new ComboBox();
            cmb.DataSource = TurleriDoldurCmbIcin();
            cmb.Top = 30 + ilaveTopDeger;
            cmb.Left = 10;
            grpIletisim.Controls.Add(cmb);

            txt = new TextBox();
            txt.Top = cmb.Top;
            txt.Left = cmb.Left + 130;
            grpIletisim.Controls.Add(txt);

            Button btn = new Button();
            btn.Width = 40;
            btn.Height = 20;
            btn.Text = "+";
            btn.Top = cmb.Top;
            btn.Left = txt.Left + 110;
            btn.Click += Btn_Click;
            grpIletisim.Controls.Add(btn);
            ilaveTopDeger += 35;
        }
        List<Connection> connections = new List<Connection>();
        private void Btn_Click(object sender, EventArgs e)
        {
            connections.Add(new Connection()
            {
                ConnectionTypeID = (cmb.SelectedItem as ConnectionType).ConnectionTypeID,
                ConnectionName = txt.Text
            });
            DinamikComponentDoldur();
        }

        private void btnKisiEkle_Click(object sender, EventArgs e)
        {
            Contact contact = new Contact();
            contact.ContactID=Guid.NewGuid();
            contact.Name = txtAd.Text;
            contact.TCKN = mtbTckn.Text;
            contact.Gender = rdbErkek.Checked;
            using (TransactionScope tran = new TransactionScope())
            {
                try
                {
                    using (MyDBEntities db = new MyDBEntities())
                    {
                        Contact newContact = db.Contacts.Add(contact);
                        db.SaveChanges();
                        foreach (Connection item in connections)
                        {
                            item.ContactID=newContact.ContactID;
                            db.Connections.Add(item);
                            db.SaveChanges();
                        }
                    }
                    tran.Complete();
                    Temizle();          
                    MessageBox.Show("Kişi eklenmiştir.");
                }
                catch (Exception ex)
                {
                    tran.Dispose();
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
            KisileriDoldur();
            ilaveTopDeger = 0;
            DinamikComponentDoldur();
        }

        private void Temizle()
        {
            txtAd.Text = string.Empty;
            mtbTckn.Text = string.Empty;
            connections.Clear();
            grpIletisim.Controls.Clear();
        }

        private void lstKisiListesi_SelectedIndexChanged(object sender, EventArgs e)
        {
            Contact contact = lstKisiListesi.SelectedItem as Contact;
            if(contact!=null)
            {
                txtAd.Text = contact.Name;
                mtbTckn.Text = contact.TCKN;
                rdbErkek.Checked = contact.Gender;
                grpIletisim.Controls.Clear();
                button1.Tag = button2.Tag = contact.ContactID;
            }
            List<Connection> connections = new List<Connection>();
            using (MyDBEntities db = new MyDBEntities())
            {
                connections = (from c in db.Connections
                               where c.ContactID == contact.ContactID
                               select c).ToList();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            lstKisiListesi.Items.Clear();
            List<Contact> contacts = new List<Contact>();
            using (MyDBEntities db = new MyDBEntities())
            {                
                contacts = db.Contacts.OrderBy(a => a.Name).ToList();
                foreach (Contact contact in contacts)
                {
                    if (contact.Name.ToLower().Contains(textBox1.Text.ToLower()))
                    {
                        lstKisiListesi.Items.Add(contact);
                    }                    
                }
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (MyDBEntities db = new MyDBEntities())
            {
                Guid contactID = (Guid)button1.Tag;
                Contact selectedContact = db.Contacts.FirstOrDefault(c=>c.ContactID == contactID);
                //Contact selectedContact = db.Contacts.SingleOrDefault(c=>c.ContactID=button1.Tag);
                if (selectedContact!=null)
                {
                    selectedContact.Name = txtAd.Text;
                    selectedContact.TCKN = mtbTckn.Text;
                    selectedContact.Gender = rdbErkek.Checked;
                    db.SaveChanges();                    
                }                
            }
            KisileriDoldur();
            Temizle();
            MessageBox.Show("Guncellendi");
            ilaveTopDeger = 0;
            DinamikComponentDoldur();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Tag==null)
            {
                return;
            }
            Guid contactID = (Guid)button2.Tag;
            using (MyDBEntities db = new MyDBEntities())
            {
                Contact selectedContact = db.Contacts.FirstOrDefault(c => c.ContactID == contactID);
                if(selectedContact!=null)
                {
                    db.Contacts.Remove(selectedContact);
                    db.SaveChanges();
                }
            }
            KisileriDoldur();
            Temizle();
            MessageBox.Show("Silindi");
            ilaveTopDeger = 0;
            DinamikComponentDoldur();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button2_Click(sender, e);
        }
    }
}
