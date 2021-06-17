using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using passwordManager;
using Repository;

namespace Interface
{
    public partial class PasswordList : UserControl
    {
        private Panel mainPanel;
        private List<Account> accountsToShow;
        private IDataAccess<Account> dataAccessAccount = DataAccessManager.GetDataAccessAccount();
        private System.Windows.Forms.Timer timer;
        public PasswordList(Panel p,List<Account> accountList)
        {
            InitializeComponent();
            lblError.Text = "";
            this.mainPanel = p;
            this.accountsToShow = accountList;
            chargePasswordsToList();
        }

        private void chargePasswordsToList()
        {
            this.accountsToShow.Sort(delegate (Account x, Account y) {
                return x.Category.Name.CompareTo(y.Category.Name);
            });
            listViewPasswords.Items.Clear();
            foreach(Account a in accountsToShow)
            {
                string[] row = new string[] { a.Category.Name, a.Site, a.Username, a.Modification.ToString("dd/MM/yyyy") };
                ListViewItem item = new ListViewItem(row);
                item.Tag = a;
                listViewPasswords.Items.Add(item);
            }
        }

        private void btnAddNewPassword_Click(object sender, EventArgs e)
        {
            UserControl passwordEditWindow = new AddPassword(this.mainPanel);
            this.mainPanel.Controls.Clear();
            this.mainPanel.Controls.Add(passwordEditWindow);
        }

        private void btnErasePassword_Click(object sender, EventArgs e)
        {
            try
            {
                Account selectedAccount = (Account)listViewPasswords.SelectedItems[0].Tag;
                this.dataAccessAccount.Delete(selectedAccount);
                this.accountsToShow.Remove(selectedAccount);
                chargePasswordsToList();

            }
            catch(Exception exc)
            {
                lblError.Text = "Debe seleccionar una contraseña para eliminar.";
            }
        }

        private void btnModifyPassword_Click(object sender, EventArgs e)
        {
            try
            {
                Account selectedAccount = (Account)listViewPasswords.SelectedItems[0].Tag;
                UserControl passwordEditWindow = new AddPassword(selectedAccount, this.mainPanel);
                this.mainPanel.Controls.Clear();
                this.mainPanel.Controls.Add(passwordEditWindow);

            }
            catch (Exception exc)
            {
                lblError.Text = "Debe seleccionar una contraseña para modificar.";
            }
        }


        

        private void listViewPasswords_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                Account selectedAccount = (Account)listViewPasswords.SelectedItems[0].Tag;
                UserControl thirtySecondsPassword = new DetailedPassword(selectedAccount);
                this.mainPanel.Controls.Clear();
                timer = new System.Windows.Forms.Timer();
                this.mainPanel.Controls.Add(thirtySecondsPassword);
                timer.Interval = 30000;
                timer.Tick += new EventHandler(timer_Event);
                timer.Start();
            }
            catch (Exception)
            {

            }
           
        }
        public void timer_Event(object source, EventArgs e)
        {
            timer.Stop();
            UserControl newPasswordList = new PasswordList( this.mainPanel, this.accountsToShow);
            this.mainPanel.Controls.Clear();
            this.mainPanel.Controls.Add(newPasswordList);

        }
    }
}
