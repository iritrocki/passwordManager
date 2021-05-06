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
        public CategoryList(User u)
        {
            InitializeComponent();
            this.user = u;
            chargeListItems();
        }

        public void chargeListItems()
        {
            foreach(Category c in user.Categories)
            {
                ListViewItem listItem = new ListViewItem(string.Format("{0}", c.Name), 0);
                listViewCategoryList.Items.Add(listItem);
            }
        }

        private void btnAddNewCategory_Click(object sender, EventArgs e)
        {
            CategoryEdit();
        }

        private void btnModifyCategory_Click(object sender, EventArgs e)
        {
            CategoryEdit();
        }

        public void CategoryEdit()
        {
            //Mostrar user control de edicion de categorias
        }
    }
}
