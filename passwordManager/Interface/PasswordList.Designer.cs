
namespace Interface
{
    partial class PasswordList
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
            this.btnModifyPassword = new System.Windows.Forms.Button();
            this.btnAddNewPassword = new System.Windows.Forms.Button();
            this.listViewPasswords = new System.Windows.Forms.ListView();
            this.lblPasswordList = new System.Windows.Forms.Label();
            this.btnErasePassword = new System.Windows.Forms.Button();
            this.chCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSite = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chUsername = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLastMod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnModifyPassword
            // 
            this.btnModifyPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnModifyPassword.Location = new System.Drawing.Point(447, 356);
            this.btnModifyPassword.Name = "btnModifyPassword";
            this.btnModifyPassword.Size = new System.Drawing.Size(87, 28);
            this.btnModifyPassword.TabIndex = 7;
            this.btnModifyPassword.Text = "Modificar";
            this.btnModifyPassword.UseVisualStyleBackColor = true;
            this.btnModifyPassword.Click += new System.EventHandler(this.btnModifyPassword_Click);
            // 
            // btnAddNewPassword
            // 
            this.btnAddNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAddNewPassword.Location = new System.Drawing.Point(259, 356);
            this.btnAddNewPassword.Name = "btnAddNewPassword";
            this.btnAddNewPassword.Size = new System.Drawing.Size(87, 28);
            this.btnAddNewPassword.TabIndex = 6;
            this.btnAddNewPassword.Text = "Agregar";
            this.btnAddNewPassword.UseVisualStyleBackColor = true;
            this.btnAddNewPassword.Click += new System.EventHandler(this.btnAddNewPassword_Click);
            // 
            // listViewPasswords
            // 
            this.listViewPasswords.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewPasswords.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chCategory,
            this.chSite,
            this.chUsername,
            this.chLastMod});
            this.listViewPasswords.GridLines = true;
            this.listViewPasswords.HideSelection = false;
            this.listViewPasswords.Location = new System.Drawing.Point(71, 95);
            this.listViewPasswords.Name = "listViewPasswords";
            this.listViewPasswords.Size = new System.Drawing.Size(463, 252);
            this.listViewPasswords.TabIndex = 5;
            this.listViewPasswords.UseCompatibleStateImageBehavior = false;
            this.listViewPasswords.View = System.Windows.Forms.View.Details;
            // 
            // lblPasswordList
            // 
            this.lblPasswordList.AutoSize = true;
            this.lblPasswordList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordList.Location = new System.Drawing.Point(67, 61);
            this.lblPasswordList.Name = "lblPasswordList";
            this.lblPasswordList.Size = new System.Drawing.Size(178, 20);
            this.lblPasswordList.TabIndex = 4;
            this.lblPasswordList.Text = "Listado de Contraseñas";
            this.lblPasswordList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnErasePassword
            // 
            this.btnErasePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnErasePassword.Location = new System.Drawing.Point(354, 356);
            this.btnErasePassword.Name = "btnErasePassword";
            this.btnErasePassword.Size = new System.Drawing.Size(87, 28);
            this.btnErasePassword.TabIndex = 8;
            this.btnErasePassword.Text = "Eliminar";
            this.btnErasePassword.UseVisualStyleBackColor = true;
            this.btnErasePassword.Click += new System.EventHandler(this.btnErasePassword_Click);
            // 
            // chCategory
            // 
            this.chCategory.Text = "Categoría";
            this.chCategory.Width = 113;
            // 
            // chSite
            // 
            this.chSite.Text = "Sitio";
            this.chSite.Width = 107;
            // 
            // chUsername
            // 
            this.chUsername.Text = "Usuario";
            this.chUsername.Width = 107;
            // 
            // chLastMod
            // 
            this.chLastMod.Text = "Última Modificación";
            this.chLastMod.Width = 130;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(259, 391);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 9;
            // 
            // PasswordList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnErasePassword);
            this.Controls.Add(this.btnModifyPassword);
            this.Controls.Add(this.btnAddNewPassword);
            this.Controls.Add(this.listViewPasswords);
            this.Controls.Add(this.lblPasswordList);
            this.Name = "PasswordList";
            this.Size = new System.Drawing.Size(604, 446);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModifyPassword;
        private System.Windows.Forms.Button btnAddNewPassword;
        private System.Windows.Forms.ListView listViewPasswords;
        private System.Windows.Forms.Label lblPasswordList;
        private System.Windows.Forms.Button btnErasePassword;
        private System.Windows.Forms.ColumnHeader chCategory;
        private System.Windows.Forms.ColumnHeader chSite;
        private System.Windows.Forms.ColumnHeader chUsername;
        private System.Windows.Forms.ColumnHeader chLastMod;
        private System.Windows.Forms.Label lblError;
    }
}
