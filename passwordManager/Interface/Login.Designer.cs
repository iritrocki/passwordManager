
namespace Interface
{
    partial class Login
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblError = new System.Windows.Forms.Label();
            this.lblMasterKey = new System.Windows.Forms.Label();
            this.btnAcceptMasterKey = new System.Windows.Forms.Button();
            this.txtMasterKey = new System.Windows.Forms.TextBox();
            this.lblLogIn = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblError);
            this.panel1.Controls.Add(this.lblMasterKey);
            this.panel1.Controls.Add(this.btnAcceptMasterKey);
            this.panel1.Controls.Add(this.txtMasterKey);
            this.panel1.Location = new System.Drawing.Point(61, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(388, 145);
            this.panel1.TabIndex = 4;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(127, 62);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 4;
            // 
            // lblMasterKey
            // 
            this.lblMasterKey.AutoSize = true;
            this.lblMasterKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMasterKey.Location = new System.Drawing.Point(15, 37);
            this.lblMasterKey.Name = "lblMasterKey";
            this.lblMasterKey.Size = new System.Drawing.Size(85, 18);
            this.lblMasterKey.TabIndex = 1;
            this.lblMasterKey.Text = "Contraseña";
            // 
            // btnAcceptMasterKey
            // 
            this.btnAcceptMasterKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnAcceptMasterKey.Location = new System.Drawing.Point(295, 95);
            this.btnAcceptMasterKey.Name = "btnAcceptMasterKey";
            this.btnAcceptMasterKey.Size = new System.Drawing.Size(75, 26);
            this.btnAcceptMasterKey.TabIndex = 3;
            this.btnAcceptMasterKey.Text = "Aceptar";
            this.btnAcceptMasterKey.UseVisualStyleBackColor = true;
            this.btnAcceptMasterKey.Click += new System.EventHandler(this.btnAcceptMasterKey_Click);
            // 
            // txtMasterKey
            // 
            this.txtMasterKey.Location = new System.Drawing.Point(127, 35);
            this.txtMasterKey.Name = "txtMasterKey";
            this.txtMasterKey.Size = new System.Drawing.Size(243, 20);
            this.txtMasterKey.TabIndex = 2;
            // 
            // lblLogIn
            // 
            this.lblLogIn.AutoSize = true;
            this.lblLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogIn.Location = new System.Drawing.Point(57, 49);
            this.lblLogIn.Name = "lblLogIn";
            this.lblLogIn.Size = new System.Drawing.Size(76, 20);
            this.lblLogIn.TabIndex = 0;
            this.lblLogIn.Text = "Ingresar";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 287);
            this.Controls.Add(this.lblLogIn);
            this.Controls.Add(this.panel1);
            this.Name = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblMasterKey;
        private System.Windows.Forms.Button btnAcceptMasterKey;
        private System.Windows.Forms.TextBox txtMasterKey;
        private System.Windows.Forms.Label lblLogIn;
    }
}