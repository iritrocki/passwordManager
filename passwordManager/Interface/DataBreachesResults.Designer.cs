
namespace Interface
{
    partial class DataBreachesResults
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
            this.lblResultados = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanelPasswords = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelCreditCards = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // lblResultados
            // 
            this.lblResultados.AutoSize = true;
            this.lblResultados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblResultados.Location = new System.Drawing.Point(28, 31);
            this.lblResultados.Name = "lblResultados";
            this.lblResultados.Size = new System.Drawing.Size(91, 20);
            this.lblResultados.TabIndex = 0;
            this.lblResultados.Text = "Resultado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Las siguientes contraseñas han sido expuestas:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Las siguientes tarjetas han sido expuestas:";
            // 
            // tableLayoutPanelPasswords
            // 
            this.tableLayoutPanelPasswords.ColumnCount = 2;
            this.tableLayoutPanelPasswords.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.05323F));
            this.tableLayoutPanelPasswords.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.94677F));
            this.tableLayoutPanelPasswords.Location = new System.Drawing.Point(32, 128);
            this.tableLayoutPanelPasswords.Name = "tableLayoutPanelPasswords";
            this.tableLayoutPanelPasswords.RowCount = 2;
            this.tableLayoutPanelPasswords.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelPasswords.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelPasswords.Size = new System.Drawing.Size(526, 41);
            this.tableLayoutPanelPasswords.TabIndex = 3;
            // 
            // tableLayoutPanelCreditCards
            // 
            this.tableLayoutPanelCreditCards.ColumnCount = 2;
            this.tableLayoutPanelCreditCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.05323F));
            this.tableLayoutPanelCreditCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.94677F));
            this.tableLayoutPanelCreditCards.Location = new System.Drawing.Point(32, 264);
            this.tableLayoutPanelCreditCards.Name = "tableLayoutPanelCreditCards";
            this.tableLayoutPanelCreditCards.RowCount = 2;
            this.tableLayoutPanelCreditCards.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelCreditCards.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelCreditCards.Size = new System.Drawing.Size(526, 41);
            this.tableLayoutPanelCreditCards.TabIndex = 4;
            // 
            // DataBreachesResults
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.tableLayoutPanelCreditCards);
            this.Controls.Add(this.tableLayoutPanelPasswords);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblResultados);
            this.Name = "DataBreachesResults";
            this.Size = new System.Drawing.Size(604, 446);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResultados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelPasswords;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelCreditCards;
    }
}
