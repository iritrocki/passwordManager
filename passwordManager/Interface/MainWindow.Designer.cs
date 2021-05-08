
namespace Interface
{
    partial class MainWindow
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
            this.btnPasswordList = new System.Windows.Forms.Button();
            this.btnCreditCardList = new System.Windows.Forms.Button();
            this.btnCategoryList = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCheckDataBreaches = new System.Windows.Forms.Button();
            this.btnChangeMasterKey = new System.Windows.Forms.Button();
            this.pnlMainUserControl = new System.Windows.Forms.Panel();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPasswordList
            // 
            this.btnPasswordList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnPasswordList.Location = new System.Drawing.Point(17, 176);
            this.btnPasswordList.Name = "btnPasswordList";
            this.btnPasswordList.Size = new System.Drawing.Size(193, 69);
            this.btnPasswordList.TabIndex = 1;
            this.btnPasswordList.Text = "Listado de contraseñas";
            this.btnPasswordList.UseVisualStyleBackColor = true;
            this.btnPasswordList.Click += new System.EventHandler(this.btnPasswordList_Click);
            // 
            // btnCreditCardList
            // 
            this.btnCreditCardList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCreditCardList.Location = new System.Drawing.Point(17, 101);
            this.btnCreditCardList.Name = "btnCreditCardList";
            this.btnCreditCardList.Size = new System.Drawing.Size(193, 69);
            this.btnCreditCardList.TabIndex = 2;
            this.btnCreditCardList.Text = "Listado de tarjetas de crédito";
            this.btnCreditCardList.UseVisualStyleBackColor = true;
            this.btnCreditCardList.Click += new System.EventHandler(this.btnCreditCardList_Click);
            // 
            // btnCategoryList
            // 
            this.btnCategoryList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCategoryList.Location = new System.Drawing.Point(17, 253);
            this.btnCategoryList.Name = "btnCategoryList";
            this.btnCategoryList.Size = new System.Drawing.Size(193, 69);
            this.btnCategoryList.TabIndex = 3;
            this.btnCategoryList.Text = "Listado de categorías";
            this.btnCategoryList.UseVisualStyleBackColor = true;
            this.btnCategoryList.Click += new System.EventHandler(this.btnCategoryList_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(17, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 69);
            this.button1.TabIndex = 4;
            this.button1.Text = "Reporte de fortaleza de contraseñas";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnCheckDataBreaches
            // 
            this.btnCheckDataBreaches.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCheckDataBreaches.Location = new System.Drawing.Point(17, 403);
            this.btnCheckDataBreaches.Name = "btnCheckDataBreaches";
            this.btnCheckDataBreaches.Size = new System.Drawing.Size(193, 69);
            this.btnCheckDataBreaches.TabIndex = 5;
            this.btnCheckDataBreaches.Text = "Chequear Data Breaches";
            this.btnCheckDataBreaches.UseVisualStyleBackColor = true;
            // 
            // btnChangeMasterKey
            // 
            this.btnChangeMasterKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnChangeMasterKey.Location = new System.Drawing.Point(17, 478);
            this.btnChangeMasterKey.Name = "btnChangeMasterKey";
            this.btnChangeMasterKey.Size = new System.Drawing.Size(193, 69);
            this.btnChangeMasterKey.TabIndex = 6;
            this.btnChangeMasterKey.Text = "Modificar clave maestra";
            this.btnChangeMasterKey.UseVisualStyleBackColor = true;
            // 
            // pnlMainUserControl
            // 
            this.pnlMainUserControl.Location = new System.Drawing.Point(228, 101);
            this.pnlMainUserControl.Name = "pnlMainUserControl";
            this.pnlMainUserControl.Size = new System.Drawing.Size(604, 446);
            this.pnlMainUserControl.TabIndex = 7;
            // 
            // btnSignOut
            // 
            this.btnSignOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnSignOut.Location = new System.Drawing.Point(702, 28);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(130, 36);
            this.btnSignOut.TabIndex = 8;
            this.btnSignOut.Text = "Cerrar sesión";
            this.btnSignOut.UseVisualStyleBackColor = true;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(10, 28);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(532, 55);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Gestor de contraseñas";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(22F, 42F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 563);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnSignOut);
            this.Controls.Add(this.pnlMainUserControl);
            this.Controls.Add(this.btnChangeMasterKey);
            this.Controls.Add(this.btnCheckDataBreaches);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCategoryList);
            this.Controls.Add(this.btnCreditCardList);
            this.Controls.Add(this.btnPasswordList);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MainWindow";
            this.Text = "Gestor de contraseñas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPasswordList;
        private System.Windows.Forms.Button btnCreditCardList;
        private System.Windows.Forms.Button btnCategoryList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCheckDataBreaches;
        private System.Windows.Forms.Button btnChangeMasterKey;
        private System.Windows.Forms.Panel pnlMainUserControl;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.Label lblTitle;
    }
}

