using passwordManager;
using Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    public partial class DataBreachFileUpload : UserControl
    {
        private string path;
        private Panel MainPanel;
        private User User;
        IDataAccess<Account> dataAccessAccount = DataAccessManager.GetDataAccessAccount();
        IDataAccess<CreditCard> dataAccessCreditCard = DataAccessManager.GetDataAccessCreditCard();
        IDataAccess<DataBreachCheck> daDataBreaches = DataAccessManager.GetDataAccessDataBreaches();

        public DataBreachFileUpload(User u, Panel panel)
        {
            InitializeComponent();
            this.MainPanel = panel;
            this.User = u;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.InitialDirectory = "C:\\";
            op.Filter = "txt files (*.txt)|*.txt";
            op.FilterIndex = 2;
            if(op.ShowDialog() == DialogResult.OK)
            {
                this.path = op.FileName;
                txtPath.Text = this.path;
            }
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            IDataBreachesAdapter adapter = new TxtFileAdapter(this.path);
            DataBreachCheck dataBreachCheck = new DataBreachCheck();
            dataBreachCheck.CheckDataBreaches(adapter, (List<Account>)dataAccessAccount.GetAll(), (List<CreditCard>)dataAccessCreditCard.GetAll());
            daDataBreaches.Add(dataBreachCheck);
            MainPanel.Controls.Clear();
            DataBreachesResults results = new DataBreachesResults(dataBreachCheck.ExposedPasswords, dataBreachCheck.ExposedCreditCards, MainPanel, User);
            MainPanel.Controls.Add(results);
        }
    }
}
