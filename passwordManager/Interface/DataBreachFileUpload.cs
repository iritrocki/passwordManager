using passwordManager;
using passwordManager.Exceptions;
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
        IDataAccess<DataBreachCheck> daDataBreaches = DataAccessManager.GetDataAccessDataBreaches();
        IDataAccess<Account> daAccounts = DataAccessManager.GetDataAccessAccount();
        IDataAccess<CreditCard> daCreditCards = DataAccessManager.GetDataAccessCreditCard();

        public DataBreachFileUpload(Panel panel)
        {
            InitializeComponent();
            this.MainPanel = panel;
            lblError.Text = "";
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
            try
            {
                IDataBreachesAdapter adapter = new TxtFileAdapter(this.path);
                DataBreachCheck dataBreachCheck = new DataBreachCheck();
                dataBreachCheck.CheckDataBreaches(adapter, (List<Account>)daAccounts.GetAll(), (List<CreditCard>)daCreditCards.GetAll());
                daDataBreaches.Add(dataBreachCheck);
                MainPanel.Controls.Clear();
                DataBreachesResults results = new DataBreachesResults(dataBreachCheck, MainPanel);
                MainPanel.Controls.Add(results);
            }catch(InvalidPathException exc)
            {
                lblError.Text = exc.Message;
            }
        }

        private void txtPath_TextChanged(object sender, EventArgs e)
        {
            lblError.Text = "";
        }
    }
}
