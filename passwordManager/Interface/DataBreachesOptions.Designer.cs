
namespace Interface
{
    partial class DataBreachesOptions
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
            this.btnTxtFile = new System.Windows.Forms.Button();
            this.btnPlainText = new System.Windows.Forms.Button();
            this.lblSelectFormat = new System.Windows.Forms.Label();
            this.lblHistoric = new System.Windows.Forms.Label();
            this.btnViewHistoric = new System.Windows.Forms.Button();
            this.lblChequeo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTxtFile
            // 
            this.btnTxtFile.Location = new System.Drawing.Point(65, 190);
            this.btnTxtFile.Name = "btnTxtFile";
            this.btnTxtFile.Size = new System.Drawing.Size(121, 34);
            this.btnTxtFile.TabIndex = 4;
            this.btnTxtFile.Text = "Archivo txt";
            this.btnTxtFile.UseMnemonic = false;
            this.btnTxtFile.UseVisualStyleBackColor = true;
            this.btnTxtFile.Click += new System.EventHandler(this.btnTxtFile_Click);
            // 
            // btnPlainText
            // 
            this.btnPlainText.Location = new System.Drawing.Point(64, 134);
            this.btnPlainText.Name = "btnPlainText";
            this.btnPlainText.Size = new System.Drawing.Size(121, 34);
            this.btnPlainText.TabIndex = 5;
            this.btnPlainText.Text = "Texto plano";
            this.btnPlainText.UseVisualStyleBackColor = true;
            this.btnPlainText.Click += new System.EventHandler(this.btnPlainText_Click);
            // 
            // lblSelectFormat
            // 
            this.lblSelectFormat.AutoSize = true;
            this.lblSelectFormat.Location = new System.Drawing.Point(61, 97);
            this.lblSelectFormat.Name = "lblSelectFormat";
            this.lblSelectFormat.Size = new System.Drawing.Size(247, 13);
            this.lblSelectFormat.TabIndex = 6;
            this.lblSelectFormat.Text = "Seleccione el formato para importar Data Breaches";
            // 
            // lblHistoric
            // 
            this.lblHistoric.AutoSize = true;
            this.lblHistoric.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistoric.Location = new System.Drawing.Point(61, 285);
            this.lblHistoric.Name = "lblHistoric";
            this.lblHistoric.Size = new System.Drawing.Size(230, 20);
            this.lblHistoric.TabIndex = 8;
            this.lblHistoric.Text = "Historico de Data Breaches";
            // 
            // btnViewHistoric
            // 
            this.btnViewHistoric.Location = new System.Drawing.Point(64, 328);
            this.btnViewHistoric.Name = "btnViewHistoric";
            this.btnViewHistoric.Size = new System.Drawing.Size(121, 34);
            this.btnViewHistoric.TabIndex = 7;
            this.btnViewHistoric.Text = "Ver";
            this.btnViewHistoric.UseMnemonic = false;
            this.btnViewHistoric.UseVisualStyleBackColor = true;
            this.btnViewHistoric.Click += new System.EventHandler(this.btnViewHistoric_Click);
            // 
            // lblChequeo
            // 
            this.lblChequeo.AutoSize = true;
            this.lblChequeo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChequeo.Location = new System.Drawing.Point(60, 65);
            this.lblChequeo.Name = "lblChequeo";
            this.lblChequeo.Size = new System.Drawing.Size(231, 20);
            this.lblChequeo.TabIndex = 9;
            this.lblChequeo.Text = "Chequeo de Data Breaches";
            // 
            // DataBreachesOptions
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.lblChequeo);
            this.Controls.Add(this.lblHistoric);
            this.Controls.Add(this.btnViewHistoric);
            this.Controls.Add(this.lblSelectFormat);
            this.Controls.Add(this.btnPlainText);
            this.Controls.Add(this.btnTxtFile);
            this.Name = "DataBreachesOptions";
            this.Size = new System.Drawing.Size(604, 446);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTxtFile;
        private System.Windows.Forms.Button btnPlainText;
        private System.Windows.Forms.Label lblSelectFormat;
        private System.Windows.Forms.Label lblHistoric;
        private System.Windows.Forms.Button btnViewHistoric;
        private System.Windows.Forms.Label lblChequeo;
    }
}
