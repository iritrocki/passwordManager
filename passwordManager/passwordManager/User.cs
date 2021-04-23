using System.Collections.Generic;

namespace passwordManager
{
    public class User
    {
        public User()
        {
            this.Status = false;
            this.Categories = new List<Category>();
            this.Accounts = new List<Account>();
            this.CreditCards = new List<CreditCard>();
        }

        public bool Status { get; set; }

        public string MasterKey { get; set; }
        public List<Category> Categories { get; set; }
        public List<Account> Accounts { get; set; }
        public List<CreditCard> CreditCards { get; set; }
    }
}