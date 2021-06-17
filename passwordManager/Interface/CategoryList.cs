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
        private Panel mainPanel;
        private IDataAccess<Category> dataAccessCategory = DataAccessManager.GetDataAccessCategory();
        
        public CategoryList(Panel MainPanel)
        {
            InitializeComponent();
            this.mainPanel = MainPanel;
            lblError.Text = "";
            ChargeListItems();
        }

        public void ChargeListItems()
        {
            foreach(Category c in (List<Category>)dataAccessCategory.GetAll())
            {
                ListViewItem listItem = new ListViewItem(string.Format("{0}", c.Name), 0);
                listItem.Tag = c;
                listViewCategoryList.Items.Add(listItem);
            }
        }

        private void btnAddNewCategory_Click(object sender, EventArgs e)
        {
            this.mainPanel.Controls.Clear();
            UserControl categoryEditWindow = new AddCategory(mainPanel);
            this.mainPanel.Controls.Add(categoryEditWindow);
        }

        private void btnModifyCategory_Click(object sender, EventArgs e)
        {
            try
            {
                Category selectedItem = (Category)listViewCategoryList.SelectedItems[0].Tag;
                this.mainPanel.Controls.Clear();
                UserControl categoryEditWindow = new AddCategory(selectedItem, mainPanel);
                this.mainPanel.Controls.Add(categoryEditWindow);

            }catch(Exception exc)
            {
                lblError.Text = "Debe seleccionar una categoría para modificar.";
            }
            
        }

    }
}
