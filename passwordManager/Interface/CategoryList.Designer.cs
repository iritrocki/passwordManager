
namespace Interface
{
    partial class CategoryList
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCategoryList = new System.Windows.Forms.Label();
            this.listViewCategoryList = new System.Windows.Forms.ListView();
            this.cHdrCategories = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAddNewCategory = new System.Windows.Forms.Button();
            this.btnModifyCategory = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCategoryList
            // 
            this.lblCategoryList.AutoSize = true;
            this.lblCategoryList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoryList.Location = new System.Drawing.Point(66, 42);
            this.lblCategoryList.Name = "lblCategoryList";
            this.lblCategoryList.Size = new System.Drawing.Size(185, 20);
            this.lblCategoryList.TabIndex = 0;
            this.lblCategoryList.Text = "Listado de Categorías";
            // 
            // listViewCategoryList
            // 
            this.listViewCategoryList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cHdrCategories});
            this.listViewCategoryList.GridLines = true;
            this.listViewCategoryList.HideSelection = false;
            this.listViewCategoryList.Location = new System.Drawing.Point(70, 94);
            this.listViewCategoryList.Name = "listViewCategoryList";
            this.listViewCategoryList.Size = new System.Drawing.Size(463, 252);
            this.listViewCategoryList.TabIndex = 1;
            this.listViewCategoryList.UseCompatibleStateImageBehavior = false;
            this.listViewCategoryList.View = System.Windows.Forms.View.Details;
            // 
            // cHdrCategories
            // 
            this.cHdrCategories.Text = "Categorías";
            this.cHdrCategories.Width = 912;
            // 
            // btnAddNewCategory
            // 
            this.btnAddNewCategory.AutoSize = true;
            this.btnAddNewCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewCategory.Location = new System.Drawing.Point(345, 352);
            this.btnAddNewCategory.Name = "btnAddNewCategory";
            this.btnAddNewCategory.Size = new System.Drawing.Size(88, 34);
            this.btnAddNewCategory.TabIndex = 2;
            this.btnAddNewCategory.Text = "Agregar";
            this.btnAddNewCategory.UseVisualStyleBackColor = true;
            this.btnAddNewCategory.Click += new System.EventHandler(this.btnAddNewCategory_Click);
            // 
            // btnModifyCategory
            // 
            this.btnModifyCategory.AutoSize = true;
            this.btnModifyCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifyCategory.Location = new System.Drawing.Point(438, 352);
            this.btnModifyCategory.Name = "btnModifyCategory";
            this.btnModifyCategory.Size = new System.Drawing.Size(96, 34);
            this.btnModifyCategory.TabIndex = 3;
            this.btnModifyCategory.Text = "Modificar";
            this.btnModifyCategory.UseVisualStyleBackColor = true;
            this.btnModifyCategory.Click += new System.EventHandler(this.btnModifyCategory_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(266, 391);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(29, 13);
            this.lblError.TabIndex = 4;
            this.lblError.Text = "Error";
            // 
            // CategoryList
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnModifyCategory);
            this.Controls.Add(this.btnAddNewCategory);
            this.Controls.Add(this.listViewCategoryList);
            this.Controls.Add(this.lblCategoryList);
            this.Name = "CategoryList";
            this.Size = new System.Drawing.Size(604, 446);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCategoryList;
        private System.Windows.Forms.ListView listViewCategoryList;
        private System.Windows.Forms.Button btnAddNewCategory;
        private System.Windows.Forms.Button btnModifyCategory;
        private System.Windows.Forms.ColumnHeader cHdrCategories;
        private System.Windows.Forms.Label lblError;
    }
}
