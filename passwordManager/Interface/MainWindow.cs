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
    public partial class MainWindow : Form
    {
        private User user;
        
        
        public MainWindow(User u)
        {
            InitializeComponent();
            this.user = u;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnCategoryList_Click(object sender, EventArgs e)
        {
            UserControl categoryList = new CategoryList(user);
            pnlMainUserControl.Controls.Add(categoryList);
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            user.SignOut();
            Form login = new Login(user);
            login.Show();
            this.Visible = false;
        }
    }
}
