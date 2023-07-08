using Contacts.UI.Core.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts.UI.Core.Context
{
    public class MyDBEntities:DbContext
    {
        public MyDBEntities() : base(ConfigurationManager.ConnectionStrings["DbRehberConn"].ConnectionString)
        {
            
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //todo Googling Conventions
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();



            base.OnModelCreating(modelBuilder);
        }
        //todo how to use and write Composite Key, Conditional mapping in code first?
        public DbSet<Connection> Connections { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<ConnectionType> ConnectionTypes { get; set; }
    }
}
