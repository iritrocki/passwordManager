
namespace Interface
{
    partial class DataBreaches
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
            this.lblDataBreaches = new System.Windows.Forms.Label();
            this.lblExposedText = new System.Windows.Forms.Label();
            this.txtDataBreaches = new System.Windows.Forms.TextBox();
            this.btnVerify = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDataBreaches
            // 
            this.lblDataBreaches.AutoSize = true;
            this.lblDataBreaches.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataBreaches.Location = new System.Drawing.Point(44, 39);
            this.lblDataBreaches.Name = "lblDataBreaches";
            this.lblDataBreaches.Size = new System.Drawing.Size(129, 20);
            this.lblDataBreaches.TabIndex = 0;
            this.lblDataBreaches.Text = "Data Breaches";
            // 
            // lblExposedText
            // 
            this.lblExposedText.AutoSize = true;
            this.lblExposedText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExposedText.Location = new System.Drawing.Point(47, 94);
            this.lblExposedText.Name = "lblExposedText";
            this.lblExposedText.Size = new System.Drawing.Size(109, 18);
            this.lblExposedText.TabIndex = 1;
            this.lblExposedText.Text = "Texto expuesto";
            // 
            // txtDataBreaches
            // 
            this.txtDataBreaches.Location = new System.Drawing.Point(48, 125);
            this.txtDataBreaches.Multiline = true;
            this.txtDataBreaches.Name = "txtDataBreaches";
            this.txtDataBreaches.Size = new System.Drawing.Size(507, 224);
            this.txtDataBreaches.TabIndex = 2;
            // 
            // btnVerify
            // 
            this.btnVerify.Location = new System.Drawing.Point(434, 372);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(121, 34);
            this.btnVerify.TabIndex = 3;
            this.btnVerify.Text = "Verificar";
            this.btnVerify.UseVisualStyleBackColor = true;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // DataBreaches
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.btnVerify);
            this.Controls.Add(this.txtDataBreaches);
            this.Controls.Add(this.lblExposedText);
            this.Controls.Add(this.lblDataBreaches);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DataBreaches";
            this.Size = new System.Drawing.Size(604, 446);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDataBreaches;
        private System.Windows.Forms.Label lblExposedText;
        private System.Windows.Forms.TextBox txtDataBreaches;
        private System.Windows.Forms.Button btnVerify;
    }
}
