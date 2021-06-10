
namespace Interface
{
    partial class DataBreachesHistory
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
            this.listViewDateSelection = new System.Windows.Forms.ListView();
            this.chDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblDataBreachHistory = new System.Windows.Forms.Label();
            this.btnViewDataBreach = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listViewDateSelection
            // 
            this.listViewDateSelection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewDateSelection.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chDate});
            this.listViewDateSelection.GridLines = true;
            this.listViewDateSelection.HideSelection = false;
            this.listViewDateSelection.Location = new System.Drawing.Point(34, 86);
            this.listViewDateSelection.Name = "listViewDateSelection";
            this.listViewDateSelection.Size = new System.Drawing.Size(536, 252);
            this.listViewDateSelection.TabIndex = 6;
            this.listViewDateSelection.UseCompatibleStateImageBehavior = false;
            this.listViewDateSelection.View = System.Windows.Forms.View.Details;
            // 
            // chDate
            // 
            this.chDate.Text = "Fecha";
            this.chDate.Width = 532;
            // 
            // lblDataBreachHistory
            // 
            this.lblDataBreachHistory.AutoSize = true;
            this.lblDataBreachHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataBreachHistory.Location = new System.Drawing.Point(30, 32);
            this.lblDataBreachHistory.Name = "lblDataBreachHistory";
            this.lblDataBreachHistory.Size = new System.Drawing.Size(263, 24);
            this.lblDataBreachHistory.TabIndex = 7;
            this.lblDataBreachHistory.Text = "Histórico de Data Breaches";
            this.lblDataBreachHistory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnViewDataBreach
            // 
            this.btnViewDataBreach.AutoSize = true;
            this.btnViewDataBreach.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewDataBreach.Location = new System.Drawing.Point(438, 384);
            this.btnViewDataBreach.Name = "btnViewDataBreach";
            this.btnViewDataBreach.Size = new System.Drawing.Size(132, 34);
            this.btnViewDataBreach.TabIndex = 8;
            this.btnViewDataBreach.Text = "Ver resultado";
            this.btnViewDataBreach.UseVisualStyleBackColor = true;
            this.btnViewDataBreach.Click += new System.EventHandler(this.btnViewDataBreach_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(31, 353);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(29, 13);
            this.lblError.TabIndex = 10;
            this.lblError.Text = "Error";
            // 
            // DataBreachesHistory
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnViewDataBreach);
            this.Controls.Add(this.lblDataBreachHistory);
            this.Controls.Add(this.listViewDateSelection);
            this.Name = "DataBreachesHistory";
            this.Size = new System.Drawing.Size(604, 446);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewDateSelection;
        private System.Windows.Forms.ColumnHeader chDate;
        private System.Windows.Forms.Label lblDataBreachHistory;
        private System.Windows.Forms.Button btnViewDataBreach;
        private System.Windows.Forms.Label lblError;
    }
}
