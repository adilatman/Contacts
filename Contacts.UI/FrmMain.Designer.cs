namespace Contacts.UI
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnKisiEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.mtbTckn = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lstKisiListesi = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rdbErkek = new System.Windows.Forms.RadioButton();
            this.rdbKadin = new System.Windows.Forms.RadioButton();
            this.grpKisi = new System.Windows.Forms.GroupBox();
            this.grpIletisim = new System.Windows.Forms.GroupBox();
            this.flpIletisim = new System.Windows.Forms.FlowLayoutPanel();
            this.contextMenuStrip1.SuspendLayout();
            this.grpKisi.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(322, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(208, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnKisiEkle
            // 
            this.btnKisiEkle.Font = new System.Drawing.Font("Pristina", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKisiEkle.Location = new System.Drawing.Point(322, 82);
            this.btnKisiEkle.Name = "btnKisiEkle";
            this.btnKisiEkle.Size = new System.Drawing.Size(208, 31);
            this.btnKisiEkle.TabIndex = 4;
            this.btnKisiEkle.Text = "Kişi Ekle";
            this.btnKisiEkle.UseVisualStyleBackColor = true;
            this.btnKisiEkle.Click += new System.EventHandler(this.btnKisiEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(318, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kişi Ara";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "İsim / Unvan";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(45, 47);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(36, 13);
            this.label20.TabIndex = 9;
            this.label20.Text = "TCKN";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(87, 18);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(180, 20);
            this.txtAd.TabIndex = 10;
            // 
            // mtbTckn
            // 
            this.mtbTckn.Location = new System.Drawing.Point(87, 44);
            this.mtbTckn.Mask = "00000000000";
            this.mtbTckn.Name = "mtbTckn";
            this.mtbTckn.Size = new System.Drawing.Size(180, 20);
            this.mtbTckn.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Pristina", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(322, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 35);
            this.button1.TabIndex = 4;
            this.button1.Text = "Güncelle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Pristina", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(322, 160);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(208, 32);
            this.button2.TabIndex = 4;
            this.button2.Text = "Kişi Sil";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lstKisiListesi
            // 
            this.lstKisiListesi.ContextMenuStrip = this.contextMenuStrip1;
            this.lstKisiListesi.FormattingEnabled = true;
            this.lstKisiListesi.Location = new System.Drawing.Point(619, 15);
            this.lstKisiListesi.Name = "lstKisiListesi";
            this.lstKisiListesi.Size = new System.Drawing.Size(193, 537);
            this.lstKisiListesi.TabIndex = 29;
            this.lstKisiListesi.SelectedIndexChanged += new System.EventHandler(this.lstKisiListesi_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(87, 26);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(86, 22);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // rdbErkek
            // 
            this.rdbErkek.AutoSize = true;
            this.rdbErkek.Location = new System.Drawing.Point(87, 70);
            this.rdbErkek.Name = "rdbErkek";
            this.rdbErkek.Size = new System.Drawing.Size(53, 17);
            this.rdbErkek.TabIndex = 30;
            this.rdbErkek.Text = "Erkek";
            this.rdbErkek.UseVisualStyleBackColor = true;
            // 
            // rdbKadin
            // 
            this.rdbKadin.AutoSize = true;
            this.rdbKadin.Checked = true;
            this.rdbKadin.Location = new System.Drawing.Point(146, 70);
            this.rdbKadin.Name = "rdbKadin";
            this.rdbKadin.Size = new System.Drawing.Size(52, 17);
            this.rdbKadin.TabIndex = 30;
            this.rdbKadin.TabStop = true;
            this.rdbKadin.Text = "Kadın";
            this.rdbKadin.UseVisualStyleBackColor = true;
            // 
            // grpKisi
            // 
            this.grpKisi.Controls.Add(this.mtbTckn);
            this.grpKisi.Controls.Add(this.rdbKadin);
            this.grpKisi.Controls.Add(this.label2);
            this.grpKisi.Controls.Add(this.rdbErkek);
            this.grpKisi.Controls.Add(this.label20);
            this.grpKisi.Controls.Add(this.txtAd);
            this.grpKisi.Location = new System.Drawing.Point(12, 12);
            this.grpKisi.Name = "grpKisi";
            this.grpKisi.Size = new System.Drawing.Size(300, 99);
            this.grpKisi.TabIndex = 31;
            this.grpKisi.TabStop = false;
            this.grpKisi.Text = "Kişi Bilgileri";
            // 
            // grpIletisim
            // 
            this.grpIletisim.Location = new System.Drawing.Point(12, 117);
            this.grpIletisim.Name = "grpIletisim";
            this.grpIletisim.Size = new System.Drawing.Size(300, 435);
            this.grpIletisim.TabIndex = 32;
            this.grpIletisim.TabStop = false;
            this.grpIletisim.Text = "İletişim Bilgileri";
            // 
            // flpIletisim
            // 
            this.flpIletisim.Location = new System.Drawing.Point(318, 198);
            this.flpIletisim.Name = "flpIletisim";
            this.flpIletisim.Size = new System.Drawing.Size(295, 312);
            this.flpIletisim.TabIndex = 33;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 565);
            this.Controls.Add(this.flpIletisim);
            this.Controls.Add(this.grpIletisim);
            this.Controls.Add(this.grpKisi);
            this.Controls.Add(this.lstKisiListesi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnKisiEkle);
            this.Controls.Add(this.textBox1);
            this.Name = "FrmMain";
            this.Text = "Rehber";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.grpKisi.ResumeLayout(false);
            this.grpKisi.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnKisiEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.MaskedTextBox mtbTckn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox lstKisiListesi;
        private System.Windows.Forms.RadioButton rdbErkek;
        private System.Windows.Forms.RadioButton rdbKadin;
        private System.Windows.Forms.GroupBox grpKisi;
        private System.Windows.Forms.GroupBox grpIletisim;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flpIletisim;
    }
}

