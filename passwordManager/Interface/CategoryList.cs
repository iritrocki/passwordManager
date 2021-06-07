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
using Repository;

namespace Interface
{
    public partial class CategoryList : UserControl
    {
        private User user;
        private Panel mainPanel;
        public CategoryList(User u, Panel MainPanel)
        {
            InitializeComponent();
            this.user = u;
            this.mainPanel = MainPanel;
            lblError.Text = "";
            ChargeListItems();
        }

        public void ChargeListItems()
        {
            IDataAccess<Category> dac = new DataAccessCategory();
            foreach(Category c in (List<Category>)dac.GetAll())
            {
                ListViewItem listItem = new ListViewItem(string.Format("{0}", c.Name), 0);
                listItem.Tag = c;
                listViewCategoryList.Items.Add(listItem);
            }
        }

        private void btnAddNewCategory_Click(object sender, EventArgs e)
        {
            this.mainPanel.Controls.Clear();
            UserControl categoryEditWindow = new AddCategory(user, mainPanel);
            this.mainPanel.Controls.Add(categoryEditWindow);
        }

        private void btnModifyCategory_Click(object sender, EventArgs e)
        {
            try
            {
                Category selectedItem = (Category)listViewCategoryList.SelectedItems[0].Tag;
                this.mainPanel.Controls.Clear();
                UserControl categoryEditWindow = new AddCategory(user, selectedItem, mainPanel);
                this.mainPanel.Controls.Add(categoryEditWindow);

            }catch(Exception exc)
            {
                lblError.Text = "Debe seleccionar una categoría para modificar.";
            }
            
        }

    }
}
