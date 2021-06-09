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
using Repository;

namespace Interface
{
    public partial class AddCategory : UserControl
    {
        private User user;
        private Category modificationCategory;
        private Panel mainPanel;
        private IDataAccess<Category> dataAccessCategory = DataAccessManager.GetDataAccessCategory();

        public AddCategory(User u, Panel main)
        {
            InitializeComponent();
            this.user = u;
            this.mainPanel = main;
            lblCategoryError.Text = "";
        }

        public AddCategory(User u, Category m, Panel main)
        {
            InitializeComponent();
            this.user = u;
            this.modificationCategory = m;
            this.mainPanel = main;
            txtCategoryName.Text = m.Name;
            lblCategoryError.Text = "";
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
                this.dataAccessCategory.Add(newCategory);
                this.mainPanel.Controls.Clear();
                UserControl categoryList = new CategoryList(user, mainPanel);
                this.mainPanel.Controls.Add(categoryList);

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
                this.dataAccessCategory.Modify(modificationCategory);
                this.mainPanel.Controls.Clear();
                UserControl categoryList = new CategoryList(user, mainPanel);
                this.mainPanel.Controls.Add(categoryList);
            }
            catch (Exception exc)
            {
                if (exc is invalidCategoryNameException || exc is ExistentCategoryNameException)
                {
                    lblCategoryError.Text = exc.Message;
                }
                else
                {
                    throw;
                }
            }
        }
    }
}
