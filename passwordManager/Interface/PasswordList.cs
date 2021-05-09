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
        public PasswordList(User u, Panel p)
        {
            InitializeComponent();
            lblError.Text = "";
            this.user = u;
            this.MainPanel = p;
            chargePasswordsToList();
        }

        private void chargePasswordsToList()
        {
            listViewPasswords.Items.Clear();
            foreach(Account a in user.Accounts)
            {
                string[] row = new string[] { a.Category.Name, a.Site, a.Username, a.Modification.ToString("dd/MM/yyyy") };
                ListViewItem item = new ListViewItem(row);
                item.Tag = a;
                listViewPasswords.Items.Add(item);
            }
        }

        private void btnAddNewPassword_Click(object sender, EventArgs e)
        {
            UserControl passwordEditWindow = new AddPassword(user);
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
                UserControl passwordEditWindow = new AddPassword(user, selectedAccount);
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
