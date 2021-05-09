
namespace Interface
{
    partial class AddCategory
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
            this.lblCategoryTitle = new System.Windows.Forms.Label();
            this.btnAcceptCategoryName = new System.Windows.Forms.Button();
            this.lblCategoryName = new System.Windows.Forms.Label();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.pnlCategoryName = new System.Windows.Forms.Panel();
            this.lblCategoryError = new System.Windows.Forms.Label();
            this.pnlCategoryName.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCategoryTitle
            // 
            this.lblCategoryTitle.AutoSize = true;
            this.lblCategoryTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblCategoryTitle.Location = new System.Drawing.Point(105, 93);
            this.lblCategoryTitle.Name = "lblCategoryTitle";
            this.lblCategoryTitle.Size = new System.Drawing.Size(87, 20);
            this.lblCategoryTitle.TabIndex = 0;
            this.lblCategoryTitle.Text = "Categoría";
            // 
            // btnAcceptCategoryName
            // 
            this.btnAcceptCategoryName.Location = new System.Drawing.Point(256, 136);
            this.btnAcceptCategoryName.Name = "btnAcceptCategoryName";
            this.btnAcceptCategoryName.Size = new System.Drawing.Size(75, 23);
            this.btnAcceptCategoryName.TabIndex = 1;
            this.btnAcceptCategoryName.Text = "Aceptar";
            this.btnAcceptCategoryName.UseVisualStyleBackColor = true;
            this.btnAcceptCategoryName.Click += new System.EventHandler(this.btnAcceptCategoryName_Click);
            // 
            // lblCategoryName
            // 
            this.lblCategoryName.AutoSize = true;
            this.lblCategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblCategoryName.Location = new System.Drawing.Point(36, 50);
            this.lblCategoryName.Name = "lblCategoryName";
            this.lblCategoryName.Size = new System.Drawing.Size(62, 18);
            this.lblCategoryName.TabIndex = 2;
            this.lblCategoryName.Text = "Nombre";
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Location = new System.Drawing.Point(120, 48);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(211, 20);
            this.txtCategoryName.TabIndex = 3;
            // 
            // pnlCategoryName
            // 
            this.pnlCategoryName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCategoryName.Controls.Add(this.lblCategoryError);
            this.pnlCategoryName.Controls.Add(this.txtCategoryName);
            this.pnlCategoryName.Controls.Add(this.lblCategoryName);
            this.pnlCategoryName.Controls.Add(this.btnAcceptCategoryName);
            this.pnlCategoryName.Location = new System.Drawing.Point(109, 147);
            this.pnlCategoryName.Name = "pnlCategoryName";
            this.pnlCategoryName.Size = new System.Drawing.Size(374, 196);
            this.pnlCategoryName.TabIndex = 4;
            // 
            // lblCategoryError
            // 
            this.lblCategoryError.AutoSize = true;
            this.lblCategoryError.ForeColor = System.Drawing.Color.Red;
            this.lblCategoryError.Location = new System.Drawing.Point(39, 85);
            this.lblCategoryError.Name = "lblCategoryError";
            this.lblCategoryError.Size = new System.Drawing.Size(0, 13);
            this.lblCategoryError.TabIndex = 4;
            // 
            // AddCategory
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.pnlCategoryName);
            this.Controls.Add(this.lblCategoryTitle);
            this.Name = "AddCategory";
            this.Size = new System.Drawing.Size(604, 446);
            this.pnlCategoryName.ResumeLayout(false);
            this.pnlCategoryName.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCategoryTitle;
        private System.Windows.Forms.Button btnAcceptCategoryName;
        private System.Windows.Forms.Label lblCategoryName;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.Panel pnlCategoryName;
        private System.Windows.Forms.Label lblCategoryError;
    }
}
