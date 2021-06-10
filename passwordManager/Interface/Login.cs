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
    public partial class Login : Form
    {
        private User user;
        private IDataAccess<User> dataAccessUser = DataAccessManager.GetDataAccessUser();
        public Login()
        {
            InitializeComponent();
            InitUser();
        }

        public Login(User u)
        {
            InitializeComponent();
            this.user = u;
        }

        private void InitUser()
        {
            try
            {
                this.user = dataAccessUser.GetAll().First();
            }
            catch (Exception e)
            {
                this.user = null;
            }
        }

        private void btnAcceptMasterKey_Click(object sender, EventArgs e)
        {
            string input = txtMasterKey.Text;
            if (user == null || user.MasterKey == null /*dataAccessUser == null*/)
            {
                try
                {
                    this.user = new User();
                    this.user.MasterKey = input;
                    user.Status = true;
                    dataAccessUser.Add(user);
                    Form mainWindow = new MainWindow(user);
                    mainWindow.Show();
                    this.Visible = false;
                }catch(InvalidMasterKeyException exc)
                {
                    lblError.Text = "La contraseña debe tener entre 5 y 25 caracteres";
                    txtMasterKey.Text = "";
                }
                
                
                
                
            }
            else
            {
                try
                {

                    user.SignIn(input);
                    Form mainWindow = new MainWindow(user);
                    mainWindow.Show();
                    this.Visible = false;
                }
                catch (InvalidMasterKeyException exc)
                {
                    lblError.Text = exc.Message;
                    txtMasterKey.Text = "";
                }
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
