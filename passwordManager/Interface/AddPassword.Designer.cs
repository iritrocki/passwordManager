﻿
namespace Interface
{
    partial class AddPassword
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
            this.lblPasswordEdit = new System.Windows.Forms.Label();
            this.pnlPasswordEdit = new System.Windows.Forms.Panel();
            this.pnlPasswordGenerator = new System.Windows.Forms.Panel();
            this.btnGeneratePassword = new System.Windows.Forms.Button();
            this.checkBoxSpecials = new System.Windows.Forms.CheckBox();
            this.checkBoxDigits = new System.Windows.Forms.CheckBox();
            this.checkBoxLower = new System.Windows.Forms.CheckBox();
            this.checkBoxUpper = new System.Windows.Forms.CheckBox();
            this.lblLenght = new System.Windows.Forms.Label();
            this.upDownLenght = new System.Windows.Forms.NumericUpDown();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.comboBoxCategories = new System.Windows.Forms.ComboBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.txtSite = new System.Windows.Forms.TextBox();
            this.lblSite = new System.Windows.Forms.Label();
            this.btnAccept = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.pnlPasswordEdit.SuspendLayout();
            this.pnlPasswordGenerator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upDownLenght)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPasswordEdit
            // 
            this.lblPasswordEdit.AutoSize = true;
            this.lblPasswordEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordEdit.Location = new System.Drawing.Point(23, 21);
            this.lblPasswordEdit.Name = "lblPasswordEdit";
            this.lblPasswordEdit.Size = new System.Drawing.Size(92, 20);
            this.lblPasswordEdit.TabIndex = 5;
            this.lblPasswordEdit.Text = "Contraseña";
            this.lblPasswordEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlPasswordEdit
            // 
            this.pnlPasswordEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPasswordEdit.Controls.Add(this.pnlPasswordGenerator);
            this.pnlPasswordEdit.Controls.Add(this.txtNotes);
            this.pnlPasswordEdit.Controls.Add(this.txtUsername);
            this.pnlPasswordEdit.Controls.Add(this.comboBoxCategories);
            this.pnlPasswordEdit.Controls.Add(this.lblNotes);
            this.pnlPasswordEdit.Controls.Add(this.lblPassword);
            this.pnlPasswordEdit.Controls.Add(this.lblUsername);
            this.pnlPasswordEdit.Controls.Add(this.lblCategory);
            this.pnlPasswordEdit.Controls.Add(this.txtSite);
            this.pnlPasswordEdit.Controls.Add(this.lblSite);
            this.pnlPasswordEdit.Controls.Add(this.btnAccept);
            this.pnlPasswordEdit.Location = new System.Drawing.Point(27, 55);
            this.pnlPasswordEdit.Name = "pnlPasswordEdit";
            this.pnlPasswordEdit.Size = new System.Drawing.Size(311, 416);
            this.pnlPasswordEdit.TabIndex = 6;
            // 
            // pnlPasswordGenerator
            // 
            this.pnlPasswordGenerator.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPasswordGenerator.Controls.Add(this.btnGeneratePassword);
            this.pnlPasswordGenerator.Controls.Add(this.checkBoxSpecials);
            this.pnlPasswordGenerator.Controls.Add(this.checkBoxDigits);
            this.pnlPasswordGenerator.Controls.Add(this.checkBoxLower);
            this.pnlPasswordGenerator.Controls.Add(this.checkBoxUpper);
            this.pnlPasswordGenerator.Controls.Add(this.lblLenght);
            this.pnlPasswordGenerator.Controls.Add(this.upDownLenght);
            this.pnlPasswordGenerator.Controls.Add(this.txtPassword);
            this.pnlPasswordGenerator.Location = new System.Drawing.Point(116, 105);
            this.pnlPasswordGenerator.Name = "pnlPasswordGenerator";
            this.pnlPasswordGenerator.Size = new System.Drawing.Size(183, 202);
            this.pnlPasswordGenerator.TabIndex = 23;
            // 
            // btnGeneratePassword
            // 
            this.btnGeneratePassword.Location = new System.Drawing.Point(96, 170);
            this.btnGeneratePassword.Name = "btnGeneratePassword";
            this.btnGeneratePassword.Size = new System.Drawing.Size(75, 23);
            this.btnGeneratePassword.TabIndex = 24;
            this.btnGeneratePassword.Text = "Generar";
            this.btnGeneratePassword.UseVisualStyleBackColor = true;
            this.btnGeneratePassword.Click += new System.EventHandler(this.btnGeneratePassword_Click);
            // 
            // checkBoxSpecials
            // 
            this.checkBoxSpecials.AutoSize = true;
            this.checkBoxSpecials.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxSpecials.Location = new System.Drawing.Point(19, 142);
            this.checkBoxSpecials.Name = "checkBoxSpecials";
            this.checkBoxSpecials.Size = new System.Drawing.Size(156, 20);
            this.checkBoxSpecials.TabIndex = 22;
            this.checkBoxSpecials.Text = "Especiales (!,$,[,{,<,...)";
            this.checkBoxSpecials.UseVisualStyleBackColor = true;
            // 
            // checkBoxDigits
            // 
            this.checkBoxDigits.AutoSize = true;
            this.checkBoxDigits.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxDigits.Location = new System.Drawing.Point(19, 116);
            this.checkBoxDigits.Name = "checkBoxDigits";
            this.checkBoxDigits.Size = new System.Drawing.Size(119, 20);
            this.checkBoxDigits.TabIndex = 21;
            this.checkBoxDigits.Text = "Dígitos (0,1,2,...)";
            this.checkBoxDigits.UseVisualStyleBackColor = true;
            // 
            // checkBoxLower
            // 
            this.checkBoxLower.AutoSize = true;
            this.checkBoxLower.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxLower.Location = new System.Drawing.Point(19, 90);
            this.checkBoxLower.Name = "checkBoxLower";
            this.checkBoxLower.Size = new System.Drawing.Size(146, 20);
            this.checkBoxLower.TabIndex = 20;
            this.checkBoxLower.Text = "Minúsculas (a,b,c,...)";
            this.checkBoxLower.UseVisualStyleBackColor = true;
            // 
            // checkBoxUpper
            // 
            this.checkBoxUpper.AutoSize = true;
            this.checkBoxUpper.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxUpper.Location = new System.Drawing.Point(19, 64);
            this.checkBoxUpper.Name = "checkBoxUpper";
            this.checkBoxUpper.Size = new System.Drawing.Size(155, 20);
            this.checkBoxUpper.TabIndex = 19;
            this.checkBoxUpper.Text = "Mayúsculas (A,B,C,...)";
            this.checkBoxUpper.UseVisualStyleBackColor = true;
            // 
            // lblLenght
            // 
            this.lblLenght.AutoSize = true;
            this.lblLenght.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblLenght.Location = new System.Drawing.Point(13, 37);
            this.lblLenght.Name = "lblLenght";
            this.lblLenght.Size = new System.Drawing.Size(46, 18);
            this.lblLenght.TabIndex = 18;
            this.lblLenght.Text = "Largo";
            // 
            // UpDLenght
            // 
            this.upDownLenght.Location = new System.Drawing.Point(65, 37);
            this.upDownLenght.Name = "UpDLenght";
            this.upDownLenght.Size = new System.Drawing.Size(107, 20);
            this.upDownLenght.TabIndex = 17;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(16, 7);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(156, 20);
            this.txtPassword.TabIndex = 16;
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(132, 313);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(156, 60);
            this.txtNotes.TabIndex = 15;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(132, 75);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(156, 20);
            this.txtUsername.TabIndex = 10;
            // 
            // comboBoxCategories
            // 
            this.comboBoxCategories.FormattingEnabled = true;
            this.comboBoxCategories.Location = new System.Drawing.Point(132, 8);
            this.comboBoxCategories.Name = "comboBoxCategories";
            this.comboBoxCategories.Size = new System.Drawing.Size(156, 21);
            this.comboBoxCategories.TabIndex = 14;
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblNotes.Location = new System.Drawing.Point(13, 313);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(48, 18);
            this.lblNotes.TabIndex = 13;
            this.lblNotes.Text = "Notas";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblPassword.Location = new System.Drawing.Point(13, 114);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(85, 18);
            this.lblPassword.TabIndex = 12;
            this.lblPassword.Text = "Contraseña";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblUsername.Location = new System.Drawing.Point(13, 77);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(77, 18);
            this.lblUsername.TabIndex = 11;
            this.lblUsername.Text = "Username";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblCategory.Location = new System.Drawing.Point(13, 11);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(72, 18);
            this.lblCategory.TabIndex = 10;
            this.lblCategory.Text = "Categoría";
            // 
            // txtSite
            // 
            this.txtSite.Location = new System.Drawing.Point(132, 42);
            this.txtSite.Name = "txtSite";
            this.txtSite.Size = new System.Drawing.Size(156, 20);
            this.txtSite.TabIndex = 9;
            // 
            // lblSite
            // 
            this.lblSite.AutoSize = true;
            this.lblSite.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblSite.Location = new System.Drawing.Point(13, 44);
            this.lblSite.Name = "lblSite";
            this.lblSite.Size = new System.Drawing.Size(37, 18);
            this.lblSite.TabIndex = 8;
            this.lblSite.Text = "Sitio";
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(214, 379);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 7;
            this.btnAccept.Text = "Aceptar";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(30, 478);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 7;
            // 
            // AddPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.pnlPasswordEdit);
            this.Controls.Add(this.lblPasswordEdit);
            this.Name = "AddPassword";
            this.Size = new System.Drawing.Size(361, 518);
            this.pnlPasswordEdit.ResumeLayout(false);
            this.pnlPasswordEdit.PerformLayout();
            this.pnlPasswordGenerator.ResumeLayout(false);
            this.pnlPasswordGenerator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upDownLenght)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPasswordEdit;
        private System.Windows.Forms.Panel pnlPasswordEdit;
        private System.Windows.Forms.Panel pnlPasswordGenerator;
        private System.Windows.Forms.Button btnGeneratePassword;
        private System.Windows.Forms.CheckBox checkBoxSpecials;
        private System.Windows.Forms.CheckBox checkBoxDigits;
        private System.Windows.Forms.CheckBox checkBoxLower;
        private System.Windows.Forms.CheckBox checkBoxUpper;
        private System.Windows.Forms.Label lblLenght;
        private System.Windows.Forms.NumericUpDown upDownLenght;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.ComboBox comboBoxCategories;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.TextBox txtSite;
        private System.Windows.Forms.Label lblSite;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Label lblError;
    }
}
