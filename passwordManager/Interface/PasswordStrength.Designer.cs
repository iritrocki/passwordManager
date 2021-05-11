namespace Interface
{
    partial class PasswordStrength
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
            this.lblPasswordStrength = new System.Windows.Forms.Label();
            this.lblPasswordColor = new System.Windows.Forms.Label();
            this.lblNumberOfPasswords = new System.Windows.Forms.Label();
            this.lblRedPassword = new System.Windows.Forms.Label();
            this.lblOrangePasswords = new System.Windows.Forms.Label();
            this.lblYellowPasswords = new System.Windows.Forms.Label();
            this.lblLightGreenPassword = new System.Windows.Forms.Label();
            this.lblDarkGreenPassword = new System.Windows.Forms.Label();
            this.btnViewRed = new System.Windows.Forms.Button();
            this.btnViewOrange = new System.Windows.Forms.Button();
            this.btnViewYellow = new System.Windows.Forms.Button();
            this.btnViewLightGreen = new System.Windows.Forms.Button();
            this.btnViewDarkGreen = new System.Windows.Forms.Button();
            this.lblNumberRed = new System.Windows.Forms.Label();
            this.lblNumberOrange = new System.Windows.Forms.Label();
            this.lblNumberYellow = new System.Windows.Forms.Label();
            this.lblNumberLightGreen = new System.Windows.Forms.Label();
            this.lblNumberDarkGreen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPasswordStrength
            // 
            this.lblPasswordStrength.AutoSize = true;
            this.lblPasswordStrength.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblPasswordStrength.Location = new System.Drawing.Point(83, 53);
            this.lblPasswordStrength.Name = "lblPasswordStrength";
            this.lblPasswordStrength.Size = new System.Drawing.Size(321, 20);
            this.lblPasswordStrength.TabIndex = 0;
            this.lblPasswordStrength.Text = "Reporte de Fortalezas de Contraseñas";
            // 
            // lblPasswordColor
            // 
            this.lblPasswordColor.AutoSize = true;
            this.lblPasswordColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblPasswordColor.Location = new System.Drawing.Point(84, 106);
            this.lblPasswordColor.Name = "lblPasswordColor";
            this.lblPasswordColor.Size = new System.Drawing.Size(53, 17);
            this.lblPasswordColor.TabIndex = 1;
            this.lblPasswordColor.Text = "Grupo";
            // 
            // lblNumberOfPasswords
            // 
            this.lblNumberOfPasswords.AutoSize = true;
            this.lblNumberOfPasswords.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblNumberOfPasswords.Location = new System.Drawing.Point(274, 106);
            this.lblNumberOfPasswords.Name = "lblNumberOfPasswords";
            this.lblNumberOfPasswords.Size = new System.Drawing.Size(191, 17);
            this.lblNumberOfPasswords.TabIndex = 2;
            this.lblNumberOfPasswords.Text = "Cantidad de Contraseñas";
            // 
            // lblRedPassword
            // 
            this.lblRedPassword.AutoSize = true;
            this.lblRedPassword.Location = new System.Drawing.Point(88, 155);
            this.lblRedPassword.Name = "lblRedPassword";
            this.lblRedPassword.Size = new System.Drawing.Size(29, 13);
            this.lblRedPassword.TabIndex = 3;
            this.lblRedPassword.Text = "Rojo";
            // 
            // lblOrangePasswords
            // 
            this.lblOrangePasswords.AutoSize = true;
            this.lblOrangePasswords.Location = new System.Drawing.Point(88, 200);
            this.lblOrangePasswords.Name = "lblOrangePasswords";
            this.lblOrangePasswords.Size = new System.Drawing.Size(44, 13);
            this.lblOrangePasswords.TabIndex = 4;
            this.lblOrangePasswords.Text = "Naranja";
            // 
            // lblYellowPasswords
            // 
            this.lblYellowPasswords.AutoSize = true;
            this.lblYellowPasswords.Location = new System.Drawing.Point(88, 243);
            this.lblYellowPasswords.Name = "lblYellowPasswords";
            this.lblYellowPasswords.Size = new System.Drawing.Size(43, 13);
            this.lblYellowPasswords.TabIndex = 5;
            this.lblYellowPasswords.Text = "Amarillo";
            // 
            // lblLightGreenPassword
            // 
            this.lblLightGreenPassword.AutoSize = true;
            this.lblLightGreenPassword.Location = new System.Drawing.Point(88, 286);
            this.lblLightGreenPassword.Name = "lblLightGreenPassword";
            this.lblLightGreenPassword.Size = new System.Drawing.Size(62, 13);
            this.lblLightGreenPassword.TabIndex = 6;
            this.lblLightGreenPassword.Text = "Verde Claro";
            // 
            // lblDarkGreenPassword
            // 
            this.lblDarkGreenPassword.AutoSize = true;
            this.lblDarkGreenPassword.Location = new System.Drawing.Point(88, 328);
            this.lblDarkGreenPassword.Name = "lblDarkGreenPassword";
            this.lblDarkGreenPassword.Size = new System.Drawing.Size(72, 13);
            this.lblDarkGreenPassword.TabIndex = 7;
            this.lblDarkGreenPassword.Text = "Verde Oscuro";
            // 
            // btnViewRed
            // 
            this.btnViewRed.AutoSize = true;
            this.btnViewRed.Location = new System.Drawing.Point(400, 150);
            this.btnViewRed.Name = "btnViewRed";
            this.btnViewRed.Size = new System.Drawing.Size(65, 23);
            this.btnViewRed.TabIndex = 8;
            this.btnViewRed.Text = "Ver";
            this.btnViewRed.UseVisualStyleBackColor = true;
            this.btnViewRed.Click += new System.EventHandler(this.btnViewRed_Click);
            // 
            // btnViewOrange
            // 
            this.btnViewOrange.AutoSize = true;
            this.btnViewOrange.Location = new System.Drawing.Point(400, 195);
            this.btnViewOrange.Name = "btnViewOrange";
            this.btnViewOrange.Size = new System.Drawing.Size(65, 23);
            this.btnViewOrange.TabIndex = 9;
            this.btnViewOrange.Text = "Ver";
            this.btnViewOrange.UseVisualStyleBackColor = true;
            this.btnViewOrange.Click += new System.EventHandler(this.btnViewOrange_Click);
            // 
            // btnViewYellow
            // 
            this.btnViewYellow.AutoSize = true;
            this.btnViewYellow.Location = new System.Drawing.Point(400, 238);
            this.btnViewYellow.Name = "btnViewYellow";
            this.btnViewYellow.Size = new System.Drawing.Size(65, 23);
            this.btnViewYellow.TabIndex = 10;
            this.btnViewYellow.Text = "Ver";
            this.btnViewYellow.UseVisualStyleBackColor = true;
            this.btnViewYellow.Click += new System.EventHandler(this.btnViewYellow_Click);
            // 
            // btnViewLightGreen
            // 
            this.btnViewLightGreen.AutoSize = true;
            this.btnViewLightGreen.Location = new System.Drawing.Point(400, 281);
            this.btnViewLightGreen.Name = "btnViewLightGreen";
            this.btnViewLightGreen.Size = new System.Drawing.Size(65, 23);
            this.btnViewLightGreen.TabIndex = 11;
            this.btnViewLightGreen.Text = "Ver";
            this.btnViewLightGreen.UseVisualStyleBackColor = true;
            this.btnViewLightGreen.Click += new System.EventHandler(this.btnViewLightGreen_Click);
            // 
            // btnViewDarkGreen
            // 
            this.btnViewDarkGreen.AutoSize = true;
            this.btnViewDarkGreen.Location = new System.Drawing.Point(400, 323);
            this.btnViewDarkGreen.Name = "btnViewDarkGreen";
            this.btnViewDarkGreen.Size = new System.Drawing.Size(65, 23);
            this.btnViewDarkGreen.TabIndex = 12;
            this.btnViewDarkGreen.Text = "Ver";
            this.btnViewDarkGreen.UseVisualStyleBackColor = true;
            this.btnViewDarkGreen.Click += new System.EventHandler(this.btnViewDarkGreen_Click);
            // 
            // lblNumberRed
            // 
            this.lblNumberRed.AutoSize = true;
            this.lblNumberRed.Location = new System.Drawing.Point(283, 155);
            this.lblNumberRed.Name = "lblNumberRed";
            this.lblNumberRed.Size = new System.Drawing.Size(13, 13);
            this.lblNumberRed.TabIndex = 13;
            this.lblNumberRed.Text = "0";
            // 
            // lblNumberOrange
            // 
            this.lblNumberOrange.AutoSize = true;
            this.lblNumberOrange.Location = new System.Drawing.Point(283, 200);
            this.lblNumberOrange.Name = "lblNumberOrange";
            this.lblNumberOrange.Size = new System.Drawing.Size(13, 13);
            this.lblNumberOrange.TabIndex = 14;
            this.lblNumberOrange.Text = "0";
            // 
            // lblNumberYellow
            // 
            this.lblNumberYellow.AutoSize = true;
            this.lblNumberYellow.Location = new System.Drawing.Point(283, 243);
            this.lblNumberYellow.Name = "lblNumberYellow";
            this.lblNumberYellow.Size = new System.Drawing.Size(13, 13);
            this.lblNumberYellow.TabIndex = 15;
            this.lblNumberYellow.Text = "0";
            // 
            // lblNumberLightGreen
            // 
            this.lblNumberLightGreen.AutoSize = true;
            this.lblNumberLightGreen.Location = new System.Drawing.Point(283, 286);
            this.lblNumberLightGreen.Name = "lblNumberLightGreen";
            this.lblNumberLightGreen.Size = new System.Drawing.Size(13, 13);
            this.lblNumberLightGreen.TabIndex = 16;
            this.lblNumberLightGreen.Text = "0";
            // 
            // lblNumberDarkGreen
            // 
            this.lblNumberDarkGreen.AutoSize = true;
            this.lblNumberDarkGreen.Location = new System.Drawing.Point(283, 328);
            this.lblNumberDarkGreen.Name = "lblNumberDarkGreen";
            this.lblNumberDarkGreen.Size = new System.Drawing.Size(13, 13);
            this.lblNumberDarkGreen.TabIndex = 17;
            this.lblNumberDarkGreen.Text = "0";
            // 
            // PasswordStrength
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.lblNumberDarkGreen);
            this.Controls.Add(this.lblNumberLightGreen);
            this.Controls.Add(this.lblNumberYellow);
            this.Controls.Add(this.lblNumberOrange);
            this.Controls.Add(this.lblNumberRed);
            this.Controls.Add(this.btnViewDarkGreen);
            this.Controls.Add(this.btnViewLightGreen);
            this.Controls.Add(this.btnViewYellow);
            this.Controls.Add(this.btnViewOrange);
            this.Controls.Add(this.btnViewRed);
            this.Controls.Add(this.lblDarkGreenPassword);
            this.Controls.Add(this.lblLightGreenPassword);
            this.Controls.Add(this.lblYellowPasswords);
            this.Controls.Add(this.lblOrangePasswords);
            this.Controls.Add(this.lblRedPassword);
            this.Controls.Add(this.lblNumberOfPasswords);
            this.Controls.Add(this.lblPasswordColor);
            this.Controls.Add(this.lblPasswordStrength);
            this.Name = "PasswordStrength";
            this.Size = new System.Drawing.Size(604, 446);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPasswordStrength;
        private System.Windows.Forms.Label lblPasswordColor;
        private System.Windows.Forms.Label lblNumberOfPasswords;
        private System.Windows.Forms.Label lblRedPassword;
        private System.Windows.Forms.Label lblOrangePasswords;
        private System.Windows.Forms.Label lblYellowPasswords;
        private System.Windows.Forms.Label lblLightGreenPassword;
        private System.Windows.Forms.Label lblDarkGreenPassword;
        private System.Windows.Forms.Button btnViewRed;
        private System.Windows.Forms.Button btnViewOrange;
        private System.Windows.Forms.Button btnViewYellow;
        private System.Windows.Forms.Button btnViewLightGreen;
        private System.Windows.Forms.Button btnViewDarkGreen;
        private System.Windows.Forms.Label lblNumberRed;
        private System.Windows.Forms.Label lblNumberOrange;
        private System.Windows.Forms.Label lblNumberYellow;
        private System.Windows.Forms.Label lblNumberLightGreen;
        private System.Windows.Forms.Label lblNumberDarkGreen;
    }
}
