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
    public partial class PasswordList : UserControl
    {
        private User user;
        private Panel MainPanel;
        private List<Account> accountsToShow;
        public PasswordList(User u, Panel p,List<Account> accountList)
        {
            InitializeComponent();
            lblError.Text = "";
            this.user = u;
            this.MainPanel = p;
            this.accountsToShow = accountList;
            chargePasswordsToList();
        }

        private void chargePasswordsToList()
        {
            this.user.Accounts.Sort(delegate (Account x, Account y) {
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
            UserControl passwordEditWindow = new AddPassword(user, this.MainPanel);
            this.MainPanel.Controls.Clear();
            this.MainPanel.Controls.Add(passwordEditWindow);
        }

        private void btnErasePassword_Click(object sender, EventArgs e)
        {
            try
            {
                Account selectedAccount = (Account)listViewPasswords.SelectedItems[0].Tag;
                user.TryRemoveAccount(selectedAccount);

            }catch(Exception exc)
            {
                lblError.Text = "Debe seleccionar una contraseña para eliminar.";
            }
        }

        private void btnModifyPassword_Click(object sender, EventArgs e)
        {
            try
            {
                Account selectedAccount = (Account)listViewPasswords.SelectedItems[0].Tag;
                UserControl passwordEditWindow = new AddPassword(user, selectedAccount, this.MainPanel);
                this.MainPanel.Controls.Clear();
                this.MainPanel.Controls.Add(passwordEditWindow);

            }
            catch (Exception exc)
            {
                lblError.Text = "Debe seleccionar una contraseña para modificar.";
            }
        }
    }
}
