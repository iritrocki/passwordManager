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
    public partial class DataBreachesHistory : UserControl
    {
        private Panel mainPanel;
        private User u;
        private IDataAccess<DataBreachCheck> dataAccessBreaches = DataAccessManager.GetDataAccessDataBreaches();
        public DataBreachesHistory(Panel panel)
        {
            InitializeComponent();
            lblError.Text = "";
            this.mainPanel = panel;
            ChargeListItems();
        }

        public void ChargeListItems()
        {
            foreach (DataBreachCheck d in (List<DataBreachCheck>)dataAccessBreaches.GetAll())
            {
                ListViewItem listItem = new ListViewItem(d.Date.ToString("dddd, dd MMMM yyyy HH:mm:ss"), 0);
                listItem.Tag = d;
                listViewDateSelection.Items.Add(listItem);
            }
        }

        private void btnViewDataBreach_Click(object sender, EventArgs e)
        {
            try
            {
                DataBreachCheck selectedItem = (DataBreachCheck)listViewDateSelection.SelectedItems[0].Tag;
                this.mainPanel.Controls.Clear();
                UserControl resultsPanel = new DataBreachesResults(selectedItem.ExposedPasswords, selectedItem.ExposedCreditCards, mainPanel, u);
                this.mainPanel.Controls.Add(resultsPanel);

            }
            catch (Exception exc)
            {
                lblError.Text = "Debe seleccionar la fecha que desea ver el resultado.";
            }
        }
    }
}
