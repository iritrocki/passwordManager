using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using passwordManager;
using Repository;

namespace Interface
{
    public partial class DataBreaches : UserControl
    {
        private Panel mainPanel;
        IDataAccess<DataBreachCheck> daDataBreaches = DataAccessManager.GetDataAccessDataBreaches();
        IDataAccess<Account> daAccounts = DataAccessManager.GetDataAccessAccount();
        IDataAccess<CreditCard> daCreditCards = DataAccessManager.GetDataAccessCreditCard();

        public DataBreaches(Panel main)
        {
            InitializeComponent();
            this.mainPanel = main;
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            string plainText = txtDataBreaches.Text;
            IDataBreachesAdapter adapter = new PlainTextAdapter(plainText);
            DataBreachCheck dataBreachCheck = new DataBreachCheck();
            dataBreachCheck.CheckDataBreaches(adapter, (List<Account>)daAccounts.GetAll(), (List<CreditCard>)daCreditCards.GetAll());
            daDataBreaches.Add(dataBreachCheck);
            mainPanel.Controls.Clear();
            DataBreachesResults results = new DataBreachesResults(dataBreachCheck, mainPanel);
            mainPanel.Controls.Add(results);

        }
    }
}
