﻿using System;
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
        private User user;
        private Panel mainPanel;
        public PasswordStrength(User u, Panel p)
        {
            InitializeComponent();
            this.user = u;
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
            IDataAccess<Account> daa = new DataAccessAccount();
            int[] colorCount = ColorClassificator.PasswordStrengthCount((List<Account>)daa.GetAll());
            lblNumberRed.Text = string.Format("{0}", colorCount[(int)ColorClassification.Red-1]);
            lblNumberOrange.Text = string.Format("{0}", colorCount[(int)ColorClassification.Orange-1]);
            lblNumberYellow.Text = string.Format("{0}", colorCount[(int)ColorClassification.Yellow-1]);
            lblNumberLightGreen.Text = string.Format("{0}", colorCount[(int)ColorClassification.LightGreen-1]);
            lblNumberDarkGreen.Text = string.Format("{0}", colorCount[(int)ColorClassification.DarkGreen-1]);
        }

        private void btnViewRed_Click(object sender, EventArgs e)
        {
            IDataAccess<Account> daa = new DataAccessAccount();
            List<Account> accounts = (List<Account>)daa.GetAll();
            UserControl redPasswordsList = new PasswordList(user, mainPanel, ColorClassificator.FilterBy(ColorClassification.Red, accounts));
            this.mainPanel.Controls.Clear();
            this.mainPanel.Controls.Add(redPasswordsList);
        }

        private void btnViewOrange_Click(object sender, EventArgs e)
        {
            IDataAccess<Account> daa = new DataAccessAccount();
            List<Account> accounts = (List<Account>)daa.GetAll();
            UserControl orangePasswordsList = new PasswordList(user, mainPanel, ColorClassificator.FilterBy(ColorClassification.Orange, accounts));
            this.mainPanel.Controls.Clear();
            this.mainPanel.Controls.Add(orangePasswordsList);
        }

        private void btnViewYellow_Click(object sender, EventArgs e)
        {
            IDataAccess<Account> daa = new DataAccessAccount();
            List<Account> accounts = (List<Account>)daa.GetAll();
            UserControl yellowPasswordsList = new PasswordList(user, mainPanel, ColorClassificator.FilterBy(ColorClassification.Yellow, accounts));
            this.mainPanel.Controls.Clear();
            this.mainPanel.Controls.Add(yellowPasswordsList);
        }

        private void btnViewLightGreen_Click(object sender, EventArgs e)
        {
            IDataAccess<Account> daa = new DataAccessAccount();
            List<Account> accounts = (List<Account>)daa.GetAll();
            UserControl lightGreenPasswordsList = new PasswordList(user, mainPanel, ColorClassificator.FilterBy(ColorClassification.LightGreen, accounts));
            this.mainPanel.Controls.Clear();
            this.mainPanel.Controls.Add(lightGreenPasswordsList);
        }

        private void btnViewDarkGreen_Click(object sender, EventArgs e)
        {
            IDataAccess<Account> daa = new DataAccessAccount();
            List<Account> accounts = (List<Account>)daa.GetAll();
            UserControl darkGreenPasswordsList = new PasswordList(user, mainPanel, ColorClassificator.FilterBy(ColorClassification.DarkGreen, accounts));
            this.mainPanel.Controls.Clear();
            this.mainPanel.Controls.Add(darkGreenPasswordsList);
        }
    }
}
