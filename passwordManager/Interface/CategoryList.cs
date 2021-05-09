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
    public partial class CategoryList : UserControl
    {
        private User user;
        private Panel MainPanel;
        public CategoryList(User u, Panel MainPanel)
        {
            InitializeComponent();
            this.user = u;
            this.MainPanel = MainPanel;
            lblError.Text = "";
            chargeListItems();
        }

        public void chargeListItems()
        {
            foreach(Category c in user.Categories)
            {
                ListViewItem listItem = new ListViewItem(string.Format("{0}", c.Name), 0);
                listItem.Tag = c;
                listViewCategoryList.Items.Add(listItem);
            }
        }

        private void btnAddNewCategory_Click(object sender, EventArgs e)
        {
            this.MainPanel.Controls.Clear();
            UserControl categoryEditWindow = new AddCategory(user, MainPanel);
            this.MainPanel.Controls.Add(categoryEditWindow);
        }

        private void btnModifyCategory_Click(object sender, EventArgs e)
        {
            try
            {
                Category selectedItem = (Category)listViewCategoryList.SelectedItems[0].Tag;
                this.MainPanel.Controls.Clear();
                UserControl categoryEditWindow = new AddCategory(user, selectedItem, MainPanel);
                this.MainPanel.Controls.Add(categoryEditWindow);

            }catch(Exception exc)
            {
                lblError.Text = "Debe seleccionar una categoría para modificar.";
            }
            
        }

    }
}
