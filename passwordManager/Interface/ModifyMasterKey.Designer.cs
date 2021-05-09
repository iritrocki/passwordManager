namespace Interface
{
    partial class ModifyMasterKey
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
            this.lblUpdateMasterkey = new System.Windows.Forms.Label();
            this.lblActualPassword = new System.Windows.Forms.Label();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.txtActualPassword = new System.Windows.Forms.TextBox();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.btnModifyMasterkey = new System.Windows.Forms.Button();
            this.lblFeedBackModification = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblUpdateMasterkey
            // 
            this.lblUpdateMasterkey.AutoSize = true;
            this.lblUpdateMasterkey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblUpdateMasterkey.Location = new System.Drawing.Point(45, 46);
            this.lblUpdateMasterkey.Name = "lblUpdateMasterkey";
            this.lblUpdateMasterkey.Size = new System.Drawing.Size(257, 20);
            this.lblUpdateMasterkey.TabIndex = 0;
            this.lblUpdateMasterkey.Text = "Actualizacion de clave maestra";
            // 
            // lblActualPassword
            // 
            this.lblActualPassword.AutoSize = true;
            this.lblActualPassword.Location = new System.Drawing.Point(49, 114);
            this.lblActualPassword.Name = "lblActualPassword";
            this.lblActualPassword.Size = new System.Drawing.Size(93, 13);
            this.lblActualPassword.TabIndex = 1;
            this.lblActualPassword.Text = "Contraseña actual";
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Location = new System.Drawing.Point(49, 180);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(94, 13);
            this.lblNewPassword.TabIndex = 2;
            this.lblNewPassword.Text = "Contraseña nueva";
            // 
            // txtActualPassword
            // 
            this.txtActualPassword.Location = new System.Drawing.Point(202, 111);
            this.txtActualPassword.Name = "txtActualPassword";
            this.txtActualPassword.Size = new System.Drawing.Size(100, 20);
            this.txtActualPassword.TabIndex = 3;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(202, 177);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(100, 20);
            this.txtNewPassword.TabIndex = 4;
            // 
            // btnModifyMasterkey
            // 
            this.btnModifyMasterkey.Location = new System.Drawing.Point(142, 224);
            this.btnModifyMasterkey.Name = "btnModifyMasterkey";
            this.btnModifyMasterkey.Size = new System.Drawing.Size(75, 23);
            this.btnModifyMasterkey.TabIndex = 5;
            this.btnModifyMasterkey.Text = "Modificar";
            this.btnModifyMasterkey.UseVisualStyleBackColor = true;
            this.btnModifyMasterkey.Click += new System.EventHandler(this.btnModifyMasterkey_Click);
            // 
            // lblFeedBackModification
            // 
            this.lblFeedBackModification.AutoSize = true;
            this.lblFeedBackModification.ForeColor = System.Drawing.Color.Red;
            this.lblFeedBackModification.Location = new System.Drawing.Point(52, 261);
            this.lblFeedBackModification.Name = "lblFeedBackModification";
            this.lblFeedBackModification.Size = new System.Drawing.Size(0, 13);
            this.lblFeedBackModification.TabIndex = 6;
            // 
            // ModifyMasterKey
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.lblFeedBackModification);
            this.Controls.Add(this.btnModifyMasterkey);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.txtActualPassword);
            this.Controls.Add(this.lblNewPassword);
            this.Controls.Add(this.lblActualPassword);
            this.Controls.Add(this.lblUpdateMasterkey);
            this.Name = "ModifyMasterKey";
            this.Size = new System.Drawing.Size(604, 446);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUpdateMasterkey;
        private System.Windows.Forms.Label lblActualPassword;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.TextBox txtActualPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Button btnModifyMasterkey;
        private System.Windows.Forms.Label lblFeedBackModification;
    }
}
