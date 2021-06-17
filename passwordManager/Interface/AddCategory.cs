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
        private Category modificationCategory;
        private Panel mainPanel;
        private IDataAccess<Category> dataAccessCategory = DataAccessManager.GetDataAccessCategory();

        public AddCategory(Panel main)
        {
            InitializeComponent();
            this.mainPanel = main;
            lblCategoryError.Text = "";
        }

        public AddCategory( Category m, Panel main)
        {
            InitializeComponent();
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
                DataChecker.UniqueCategoryCheck(newCategory, (List<Category>)dataAccessCategory.GetAll());
                this.dataAccessCategory.Add(newCategory);
                this.mainPanel.Controls.Clear();
                UserControl categoryList = new CategoryList(mainPanel);
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
                Modificator.TryModifyCategory(modificationCategory, txtCategoryName.Text, (List<Category>)dataAccessCategory.GetAll());
                this.dataAccessCategory.Modify(modificationCategory);
                this.mainPanel.Controls.Clear();
                UserControl categoryList = new CategoryList(mainPanel);
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
