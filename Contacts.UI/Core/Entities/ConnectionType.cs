using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts.UI.Core.Entities
{
    public class ConnectionType
    {
        [Key]
        public int ConnectionTypeID { get; set; }
        [StringLength(30,ErrorMessage ="Bu alan en az 3, en fazla 30 karakter olmalıdır.",MinimumLength =3)]
        public string ConnectionTypeName { get; set; }




        public List<Connection> Connections { get; set; }
        public override string ToString()
        {
            return ConnectionTypeName;
        }
    }
}
