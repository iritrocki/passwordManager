namespace Interface
{
    partial class CreditCardList
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
            this.lblCreditCardList = new System.Windows.Forms.Label();
            this.lblErrorCreditCard = new System.Windows.Forms.Label();
            this.btnDeleteCreditCard = new System.Windows.Forms.Button();
            this.btnModifyCreditCard = new System.Windows.Forms.Button();
            this.btnAddCreditCard = new System.Windows.Forms.Button();
            this.listViewCreditCards = new System.Windows.Forms.ListView();
            this.chCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCompany = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chExpiration = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lblCreditCardList
            // 
            this.lblCreditCardList.AutoSize = true;
            this.lblCreditCardList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreditCardList.Location = new System.Drawing.Point(25, 35);
            this.lblCreditCardList.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCreditCardList.Name = "lblCreditCardList";
            this.lblCreditCardList.Size = new System.Drawing.Size(163, 20);
            this.lblCreditCardList.TabIndex = 0;
            this.lblCreditCardList.Text = "Listado de Tarjetas";
            // 
            // lblErrorCreditCard
            // 
            this.lblErrorCreditCard.AutoSize = true;
            this.lblErrorCreditCard.ForeColor = System.Drawing.Color.Red;
            this.lblErrorCreditCard.Location = new System.Drawing.Point(26, 362);
            this.lblErrorCreditCard.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblErrorCreditCard.Name = "lblErrorCreditCard";
            this.lblErrorCreditCard.Size = new System.Drawing.Size(29, 13);
            this.lblErrorCreditCard.TabIndex = 4;
            this.lblErrorCreditCard.Text = "Error";
            // 
            // btnDeleteCreditCard
            // 
            this.btnDeleteCreditCard.AutoSize = true;
            this.btnDeleteCreditCard.Location = new System.Drawing.Point(480, 388);
            this.btnDeleteCreditCard.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteCreditCard.Name = "btnDeleteCreditCard";
            this.btnDeleteCreditCard.Size = new System.Drawing.Size(98, 36);
            this.btnDeleteCreditCard.TabIndex = 3;
            this.btnDeleteCreditCard.Text = "Eliminar";
            this.btnDeleteCreditCard.UseVisualStyleBackColor = true;
            this.btnDeleteCreditCard.Click += new System.EventHandler(this.btnDeleteCreditCard_Click);
            // 
            // btnModifyCreditCard
            // 
            this.btnModifyCreditCard.AutoSize = true;
            this.btnModifyCreditCard.Location = new System.Drawing.Point(378, 388);
            this.btnModifyCreditCard.Margin = new System.Windows.Forms.Padding(2);
            this.btnModifyCreditCard.Name = "btnModifyCreditCard";
            this.btnModifyCreditCard.Size = new System.Drawing.Size(98, 36);
            this.btnModifyCreditCard.TabIndex = 2;
            this.btnModifyCreditCard.Text = "Modificar";
            this.btnModifyCreditCard.UseVisualStyleBackColor = true;
            this.btnModifyCreditCard.Click += new System.EventHandler(this.btnModifyCreditCard_Click);
            // 
            // btnAddCreditCard
            // 
            this.btnAddCreditCard.AutoSize = true;
            this.btnAddCreditCard.Location = new System.Drawing.Point(276, 388);
            this.btnAddCreditCard.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddCreditCard.Name = "btnAddCreditCard";
            this.btnAddCreditCard.Size = new System.Drawing.Size(98, 36);
            this.btnAddCreditCard.TabIndex = 1;
            this.btnAddCreditCard.Text = "Agregar";
            this.btnAddCreditCard.UseVisualStyleBackColor = true;
            this.btnAddCreditCard.Click += new System.EventHandler(this.btnAddCreditCard_Click);
            // 
            // listViewCreditCards
            // 
            this.listViewCreditCards.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chCategory,
            this.chName,
            this.chCompany,
            this.chNumber,
            this.chExpiration});
            this.listViewCreditCards.GridLines = true;
            this.listViewCreditCards.HideSelection = false;
            this.listViewCreditCards.Location = new System.Drawing.Point(29, 83);
            this.listViewCreditCards.Margin = new System.Windows.Forms.Padding(2);
            this.listViewCreditCards.Name = "listViewCreditCards";
            this.listViewCreditCards.Size = new System.Drawing.Size(549, 252);
            this.listViewCreditCards.TabIndex = 0;
            this.listViewCreditCards.UseCompatibleStateImageBehavior = false;
            this.listViewCreditCards.View = System.Windows.Forms.View.Details;
            // 
            // chCategory
            // 
            this.chCategory.Text = "Categoria";
            this.chCategory.Width = 100;
            // 
            // chName
            // 
            this.chName.Text = "Nombre";
            this.chName.Width = 100;
            // 
            // chCompany
            // 
            this.chCompany.Text = "Tipo";
            this.chCompany.Width = 100;
            // 
            // chNumber
            // 
            this.chNumber.Text = "Tarjeta";
            this.chNumber.Width = 100;
            // 
            // chExpiration
            // 
            this.chExpiration.Text = "Vencimiento";
            this.chExpiration.Width = 135;
            // 
            // CreditCardList
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.btnDeleteCreditCard);
            this.Controls.Add(this.lblErrorCreditCard);
            this.Controls.Add(this.btnModifyCreditCard);
            this.Controls.Add(this.btnAddCreditCard);
            this.Controls.Add(this.lblCreditCardList);
            this.Controls.Add(this.listViewCreditCards);
            this.Name = "CreditCardList";
            this.Size = new System.Drawing.Size(604, 446);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCreditCardList;
        private System.Windows.Forms.ListView listViewCreditCards;
        private System.Windows.Forms.Button btnAddCreditCard;
        private System.Windows.Forms.ColumnHeader chCategory;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chCompany;
        private System.Windows.Forms.ColumnHeader chNumber;
        private System.Windows.Forms.ColumnHeader chExpiration;
        private System.Windows.Forms.Label lblErrorCreditCard;
        private System.Windows.Forms.Button btnDeleteCreditCard;
        private System.Windows.Forms.Button btnModifyCreditCard;
    }
}
