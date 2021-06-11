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
        IDataAccess<Account> dataAccessAccount = DataAccessManager.GetDataAccessAccount();
        IDataAccess<CreditCard> dataAccessCreditCard = DataAccessManager.GetDataAccessCreditCard();
        IDataAccess<DataBreachCheck> daDataBreaches = DataAccessManager.GetDataAccessDataBreaches();

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
            dataBreachCheck.CheckDataBreaches(adapter, (List<Account>)dataAccessAccount.GetAll(), (List<CreditCard>)dataAccessCreditCard.GetAll());
            daDataBreaches.Add(dataBreachCheck);
            mainPanel.Controls.Clear();
            DataBreachesResults results = new DataBreachesResults(dataBreachCheck.ExposedPasswords, dataBreachCheck.ExposedCreditCards, mainPanel);
            mainPanel.Controls.Add(results);

        }
    }
}
