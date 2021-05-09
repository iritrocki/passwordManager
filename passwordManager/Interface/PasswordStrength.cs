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

namespace Interface
{
    public partial class PasswordStrength : UserControl
    {
        private User user;
        private Panel mainPanel;
        public PasswordStrength(User u,Panel p)
        {
            this.user = u;
            this.mainPanel = p;
            InitializeComponent();
            ChargeLabels();
        }

       public void ChargeLabels()
        {
            lblNumberRed.Text = string.Format("{0}", user.ColorCount[(int)ColorClassification.Red-1]);
            lblNumberOrange.Text = string.Format("{0}", user.ColorCount[(int)ColorClassification.Orange-1]);
            lblNumberYellow.Text = string.Format("{0}", user.ColorCount[(int)ColorClassification.Yellow-1]);
            lblNumberLightGreen.Text = string.Format("{0}", user.ColorCount[(int)ColorClassification.LightGreen-1]);
            lblNumberDarkGreen.Text = string.Format("{0}", user.ColorCount[(int)ColorClassification.DarkGreen-1]);
        }

        private void btnViewRed_Click(object sender, EventArgs e)
        {
            UserControl redPasswordsList = new PasswordList(user, mainPanel, user.FilterBy(ColorClassification.Red));
            this.mainPanel.Controls.Clear();
            this.mainPanel.Controls.Add(redPasswordsList);
        }

        private void btnViewOrange_Click(object sender, EventArgs e)
        {
            UserControl orangePasswordsList = new PasswordList(user, mainPanel, user.FilterBy(ColorClassification.Orange));
            this.mainPanel.Controls.Clear();
            this.mainPanel.Controls.Add(orangePasswordsList);
        }

        private void btnViewYellow_Click(object sender, EventArgs e)
        {
            UserControl yellowPasswordsList = new PasswordList(user, mainPanel, user.FilterBy(ColorClassification.Yellow));
            this.mainPanel.Controls.Clear();
            this.mainPanel.Controls.Add(yellowPasswordsList);
        }

        private void btnViewLightGreen_Click(object sender, EventArgs e)
        {
            UserControl lightGreenPasswordsList = new PasswordList(user, mainPanel, user.FilterBy(ColorClassification.LightGreen));
            this.mainPanel.Controls.Clear();
            this.mainPanel.Controls.Add(lightGreenPasswordsList);
        }

        private void btnViewDarkGreen_Click(object sender, EventArgs e)
        {
            UserControl darkGreenPasswordsList = new PasswordList(user, mainPanel, user.FilterBy(ColorClassification.DarkGreen));
            this.mainPanel.Controls.Clear();
            this.mainPanel.Controls.Add(darkGreenPasswordsList);
        }
    }
}
