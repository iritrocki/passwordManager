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
            this.pnlCreditCardList = new System.Windows.Forms.Panel();
            this.listViewCreditCards = new System.Windows.Forms.ListView();
            this.chCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCompany = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chExpiration = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAddCreditCard = new System.Windows.Forms.Button();
            this.btnModifyCreditCard = new System.Windows.Forms.Button();
            this.btnDeleteCreditCard = new System.Windows.Forms.Button();
            this.lblErrorCreditCard = new System.Windows.Forms.Label();
            this.pnlCreditCardList.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCreditCardList
            // 
            this.lblCreditCardList.AutoSize = true;
            this.lblCreditCardList.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreditCardList.Location = new System.Drawing.Point(107, 147);
            this.lblCreditCardList.Name = "lblCreditCardList";
            this.lblCreditCardList.Size = new System.Drawing.Size(336, 42);
            this.lblCreditCardList.TabIndex = 0;
            this.lblCreditCardList.Text = "Listado de Tarjetas";
            // 
            // pnlCreditCardList
            // 
            this.pnlCreditCardList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCreditCardList.Controls.Add(this.lblErrorCreditCard);
            this.pnlCreditCardList.Controls.Add(this.btnDeleteCreditCard);
            this.pnlCreditCardList.Controls.Add(this.btnModifyCreditCard);
            this.pnlCreditCardList.Controls.Add(this.btnAddCreditCard);
            this.pnlCreditCardList.Controls.Add(this.listViewCreditCards);
            this.pnlCreditCardList.Location = new System.Drawing.Point(112, 212);
            this.pnlCreditCardList.Name = "pnlCreditCardList";
            this.pnlCreditCardList.Size = new System.Drawing.Size(1119, 595);
            this.pnlCreditCardList.TabIndex = 1;
            // 
            // listViewCreditCards
            // 
            this.listViewCreditCards.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chCategory,
            this.chName,
            this.chCompany,
            this.chNumber,
            this.chExpiration});
            this.listViewCreditCards.HideSelection = false;
            this.listViewCreditCards.Location = new System.Drawing.Point(36, 23);
            this.listViewCreditCards.Name = "listViewCreditCards";
            this.listViewCreditCards.Size = new System.Drawing.Size(922, 481);
            this.listViewCreditCards.TabIndex = 0;
            this.listViewCreditCards.UseCompatibleStateImageBehavior = false;
            this.listViewCreditCards.View = System.Windows.Forms.View.Details;
            // 
            // chCategory
            // 
            this.chCategory.Text = "Categoria";
            this.chCategory.Width = 176;
            // 
            // chName
            // 
            this.chName.Text = "Nombre";
            this.chName.Width = 208;
            // 
            // chCompany
            // 
            this.chCompany.Text = "Tipo";
            this.chCompany.Width = 135;
            // 
            // chNumber
            // 
            this.chNumber.Text = "Tarjeta";
            this.chNumber.Width = 253;
            // 
            // chExpiration
            // 
            this.chExpiration.Text = "Vencimiento";
            this.chExpiration.Width = 141;
            // 
            // btnAddCreditCard
            // 
            this.btnAddCreditCard.Location = new System.Drawing.Point(472, 521);
            this.btnAddCreditCard.Name = "btnAddCreditCard";
            this.btnAddCreditCard.Size = new System.Drawing.Size(174, 54);
            this.btnAddCreditCard.TabIndex = 1;
            this.btnAddCreditCard.Text = "Agregar";
            this.btnAddCreditCard.UseVisualStyleBackColor = true;
            this.btnAddCreditCard.Click += new System.EventHandler(this.btnAddCreditCard_Click);
            // 
            // btnModifyCreditCard
            // 
            this.btnModifyCreditCard.Location = new System.Drawing.Point(662, 521);
            this.btnModifyCreditCard.Name = "btnModifyCreditCard";
            this.btnModifyCreditCard.Size = new System.Drawing.Size(174, 56);
            this.btnModifyCreditCard.TabIndex = 2;
            this.btnModifyCreditCard.Text = "Modificar";
            this.btnModifyCreditCard.UseVisualStyleBackColor = true;
            this.btnModifyCreditCard.Click += new System.EventHandler(this.btnModifyCreditCard_Click);
            // 
            // btnDeleteCreditCard
            // 
            this.btnDeleteCreditCard.Location = new System.Drawing.Point(842, 521);
            this.btnDeleteCreditCard.Name = "btnDeleteCreditCard";
            this.btnDeleteCreditCard.Size = new System.Drawing.Size(174, 56);
            this.btnDeleteCreditCard.TabIndex = 3;
            this.btnDeleteCreditCard.Text = "Eliminar";
            this.btnDeleteCreditCard.UseVisualStyleBackColor = true;
            this.btnDeleteCreditCard.Click += new System.EventHandler(this.btnDeleteCreditCard_Click);
            // 
            // lblErrorDeletingCreditCard
            // 
            this.lblErrorCreditCard.AutoSize = true;
            this.lblErrorCreditCard.ForeColor = System.Drawing.Color.Red;
            this.lblErrorCreditCard.Location = new System.Drawing.Point(36, 521);
            this.lblErrorCreditCard.Name = "lblErrorDeletingCreditCard";
            this.lblErrorCreditCard.Size = new System.Drawing.Size(0, 25);
            this.lblErrorCreditCard.TabIndex = 4;
            // 
            // CreditCardList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlCreditCardList);
            this.Controls.Add(this.lblCreditCardList);
            this.Name = "CreditCardList";
            this.Size = new System.Drawing.Size(1350, 1091);
            this.pnlCreditCardList.ResumeLayout(false);
            this.pnlCreditCardList.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCreditCardList;
        private System.Windows.Forms.Panel pnlCreditCardList;
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
