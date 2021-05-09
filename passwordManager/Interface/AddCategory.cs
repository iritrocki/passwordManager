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
using passwordManager.Exceptions;

namespace Interface
{
    public partial class AddCategory : UserControl
    {
        private User user;
        private Category modificationCategory;

        public AddCategory(User u)
        {
            InitializeComponent();
            this.user = u;
        }

        public AddCategory(User u, Category m)
        {
            InitializeComponent();
            this.user = u;
            this.modificationCategory = m;
        }

        private void btnAcceptCategoryName_Click(object sender, EventArgs e)
        {
            if(modificationCategory == null)
            {
                CreateNewCategory();
            }
            else
            {
                ModifyCategory();
            }
        }

        public void CreateNewCategory()
        {
            try
            {
                Category newCategory = new Category(txtCategoryName.Text);
                user.TryAddCategory(newCategory);
                txtCategoryName.Text = "";

            }catch(Exception exc){
                if(exc is invalidCategoryNameException || exc is ExistentCategoryNameException)
                {
                    lblCategoryError.Text = exc.Message;
                }
                else
                {
                    throw;
                }
            }
        }

        public void ModifyCategory()
        {
            try
            {
                user.TryModifyCategory(modificationCategory, txtCategoryName.Text);
                txtCategoryName.Text = "";
            }
            catch (Exception exc)
            {
                if (exc is invalidCategoryNameException || exc is ExistentCategoryNameException)
                {
                    lblCategoryError.Text = exc.Message;
                }
                throw;
            }
        }
    }
}
