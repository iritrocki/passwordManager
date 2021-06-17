using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using passwordManager;
using Repository;

namespace Interface
{
    public partial class PasswordStrength : UserControl
    {
        private Panel mainPanel;
        private IDataAccess<Account> dataAccessAccount = DataAccessManager.GetDataAccessAccount();
        public PasswordStrength( Panel p)
        {
            InitializeComponent();
            this.mainPanel = p;
            ClearLabels();
            ChargeLabels();
        }

        public void ClearLabels()
        {
            lblNumberRed.Text = "";
            lblNumberYellow.Text = "";
            lblNumberOrange.Text = "";
            lblNumberLightGreen.Text = "";
            lblNumberDarkGreen.Text = "";
        }
       public void ChargeLabels()
        {
            int[] colorCount = ColorClassificator.PasswordStrengthCount((List<Account>)dataAccessAccount.GetAll());
            lblNumberRed.Text = string.Format("{0}", colorCount[(int)ColorClassification.Red-1]);
            lblNumberOrange.Text = string.Format("{0}", colorCount[(int)ColorClassification.Orange-1]);
            lblNumberYellow.Text = string.Format("{0}", colorCount[(int)ColorClassification.Yellow-1]);
            lblNumberLightGreen.Text = string.Format("{0}", colorCount[(int)ColorClassification.LightGreen-1]);
            lblNumberDarkGreen.Text = string.Format("{0}", colorCount[(int)ColorClassification.DarkGreen-1]);
        }

        private void btnViewRed_Click(object sender, EventArgs e)
        {
            List<Account> accounts = (List<Account>)dataAccessAccount.GetAll();
            UserControl redPasswordsList = new PasswordList(mainPanel, ColorClassificator.FilterBy(ColorClassification.Red, accounts));
            this.mainPanel.Controls.Clear();
            this.mainPanel.Controls.Add(redPasswordsList);
        }

        private void btnViewOrange_Click(object sender, EventArgs e)
        {
            List<Account> accounts = (List<Account>)dataAccessAccount.GetAll();
            UserControl orangePasswordsList = new PasswordList(mainPanel, ColorClassificator.FilterBy(ColorClassification.Orange, accounts));
            this.mainPanel.Controls.Clear();
            this.mainPanel.Controls.Add(orangePasswordsList);
        }

        private void btnViewYellow_Click(object sender, EventArgs e)
        {
            List<Account> accounts = (List<Account>)dataAccessAccount.GetAll();
            UserControl yellowPasswordsList = new PasswordList(mainPanel, ColorClassificator.FilterBy(ColorClassification.Yellow, accounts));
            this.mainPanel.Controls.Clear();
            this.mainPanel.Controls.Add(yellowPasswordsList);
        }

        private void btnViewLightGreen_Click(object sender, EventArgs e)
        {
            List<Account> accounts = (List<Account>)dataAccessAccount.GetAll();
            UserControl lightGreenPasswordsList = new PasswordList(mainPanel, ColorClassificator.FilterBy(ColorClassification.LightGreen, accounts));
            this.mainPanel.Controls.Clear();
            this.mainPanel.Controls.Add(lightGreenPasswordsList);
        }

        private void btnViewDarkGreen_Click(object sender, EventArgs e)
        {
            List<Account> accounts = (List<Account>)dataAccessAccount.GetAll();
            UserControl darkGreenPasswordsList = new PasswordList(mainPanel, ColorClassificator.FilterBy(ColorClassification.DarkGreen, accounts));
            this.mainPanel.Controls.Clear();
            this.mainPanel.Controls.Add(darkGreenPasswordsList);
        }
    }
}
