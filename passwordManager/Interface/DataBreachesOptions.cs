using passwordManager;
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
    public partial class DataBreachesOptions : UserControl
    {
        private Panel MainPanel;
        private User User;

        public DataBreachesOptions(User u, Panel main)
        {
            InitializeComponent();
            this.MainPanel = main;
            this.User = u;
        }

        private void btnPlainText_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            UserControl dataBreaches = new DataBreaches(User, MainPanel);
            MainPanel.Controls.Add(dataBreaches);
        }

        private void btnTxtFile_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            UserControl dataBreachesWithFiles = new DataBreachFileUpload(User, MainPanel);
            MainPanel.Controls.Add(dataBreachesWithFiles);
        }

        private void btnViewHistoric_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            UserControl historicPanel = new DataBreachesHistory(MainPanel);
            MainPanel.Controls.Add(historicPanel);
        }
    }
}
