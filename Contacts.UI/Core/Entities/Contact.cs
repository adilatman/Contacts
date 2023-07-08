using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Contacts.UI.Core.Entities
{
    public class Contact
    {
        [Key]
        public Guid ContactID { get; set; }
        [StringLength(800, ErrorMessage = "Bu alan en az 3, en fazla 80 karakter olmalıdır.", MinimumLength = 3)]
        public string Name { get; set; }
        public bool Gender { get; set; }
        [StringLength(11, ErrorMessage = "Bu alan 11 karakter olmalıdır.", MinimumLength = 11)]
        public string TCKN { get; set; }




        public List<Connection> Connections { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
