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

namespace Interface
{
    public partial class DataBreaches : UserControl
    {
        private User user;
        private Panel mainPanel;
        public DataBreaches(User u, Panel main)
        {
            InitializeComponent();
            this.user = u;
            this.mainPanel = main;
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            string plainText = txtDataBreaches.Text;
            IDataBreachesAdapter adapter = new PlainTextAdapter(plainText);
            DataBreachCheck dataBreachCheck = new DataBreachCheck();
            dataBreachCheck.CheckDataBreaches(adapter, user);
            mainPanel.Controls.Clear();
            DataBreachesResults results = new DataBreachesResults(dataBreachCheck.ExposedPasswords, dataBreachCheck.ExposedCreditCards, mainPanel, user);
            mainPanel.Controls.Add(results);

        }
    }
}
