using passwordManager;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlProviderServices = System.Data.Entity.SqlServer.SqlProviderServices;

namespace Repository
{
    public class PasswordManagerDBContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }

        public DbSet<CreditCard> CreditCards { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<User> Users { get; set; }

        public PasswordManagerDBContext() : base("name=PasswordManagerDBContext") { }
        
    }
}
