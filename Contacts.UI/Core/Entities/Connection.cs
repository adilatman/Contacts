using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts.UI.Core.Entities
{
    public class Connection
    {
        [Key]
        public int ConnectionID { get; set; }
        public Guid ContactID { get; set; }
        public int ConnectionTypeID { get; set; }
        [StringLength(200, ErrorMessage = "Bu alan en az 3, en fazla 200 karakter olmalıdır.", MinimumLength = 3)]
        public string ConnectionName { get; set; }



        [ForeignKey("ContactID")]
        public Contact Contacts { get; set; }
        [ForeignKey("ConnectionTypeID")]
        public ConnectionType ConnectionTypeNames { get; set; }
    }
}
