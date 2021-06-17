using passwordManager.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace passwordManager
{
    public class PasswordAnalysis
    {
        public bool DataBreach { get; set; }

        public bool Duplicated { get; set; }

        public bool Secure { get; set; }

        private List<DataBreachCheck> dataBreaches;

        private List<Account> accounts;

        public PasswordAnalysis(){}

        public PasswordAnalysis(List<DataBreachCheck> dataBreaches, List<Account> accounts)
        {
            if (dataBreaches == null || accounts == null)
                throw new NullListException();
            
            this.dataBreaches = dataBreaches;
            this.accounts = accounts;
            this.DataBreach = false;
            this.Duplicated = false;
            this.Secure = false;
        }
        
        public void RunAnalysis(string password)
        {
            this.DataBreach = false;
            this.Duplicated = false;
            this.Secure = false;
            DataBreachAnalysis(password);
            DuplicatedPasswordAnalysis(password);
            SecureAnalysis(password);
        }

        private void DuplicatedPasswordAnalysis(string password)
        {
            foreach (Account a in this.accounts)
            {
                if (password == a.Password)
                {
                    this.Duplicated = true;
                }
            }
        }

        private void DataBreachAnalysis(string password)
        {
            foreach (DataBreachCheck db in this.dataBreaches)
            {
                foreach (DataBreachLine line in db.DataBreaches)
                {
                    if (line.Line == password)
                    {
                        this.DataBreach = true;
                    }
                }
            }
        }

        private void SecureAnalysis(string password)
        {
            ColorClassification color = ColorClassificator.ClassifyColor(password);
            if(color == ColorClassification.LightGreen || color == ColorClassification.DarkGreen)
            {
                this.Secure = true;
            }
        }
    }
}
