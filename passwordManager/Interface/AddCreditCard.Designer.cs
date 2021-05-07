namespace Interface
{
    partial class AddCreditCard
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
            this.btnAcceptNewCreditCard = new System.Windows.Forms.Button();
            this.lblCreditCardName = new System.Windows.Forms.Label();
            this.lblCreditCardCompany = new System.Windows.Forms.Label();
            this.lblCreditCardNumber = new System.Windows.Forms.Label();
            this.lblCreditCardCode = new System.Windows.Forms.Label();
            this.lblCreditCardExpiration = new System.Windows.Forms.Label();
            this.lblCreditCardNotes = new System.Windows.Forms.Label();
            this.comboBoxCreditCardCategory = new System.Windows.Forms.ComboBox();
            this.txtCreditCardName = new System.Windows.Forms.TextBox();
            this.txtCreditCardCompany = new System.Windows.Forms.TextBox();
            this.txtCreditCardNumber = new System.Windows.Forms.TextBox();
            this.txtCreditCardCode = new System.Windows.Forms.TextBox();
            this.txtCreditCardExpiration = new System.Windows.Forms.TextBox();
            this.txtCreditCardNotes = new System.Windows.Forms.TextBox();
            this.lblCreditCardCategory = new System.Windows.Forms.Label();
            this.lblCreditCardError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCreditCardList
            // 
            this.lblCreditCardList.AutoSize = true;
            this.lblCreditCardList.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreditCardList.Location = new System.Drawing.Point(99, 81);
            this.lblCreditCardList.Name = "lblCreditCardList";
            this.lblCreditCardList.Size = new System.Drawing.Size(197, 55);
            this.lblCreditCardList.TabIndex = 0;
            this.lblCreditCardList.Text = "Tarjetas";
            // 
            // btnAcceptNewCreditCard
            // 
            this.btnAcceptNewCreditCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAcceptNewCreditCard.Location = new System.Drawing.Point(660, 831);
            this.btnAcceptNewCreditCard.Name = "btnAcceptNewCreditCard";
            this.btnAcceptNewCreditCard.Size = new System.Drawing.Size(174, 54);
            this.btnAcceptNewCreditCard.TabIndex = 2;
            this.btnAcceptNewCreditCard.Text = "Aceptar";
            this.btnAcceptNewCreditCard.UseVisualStyleBackColor = true;
            this.btnAcceptNewCreditCard.Click += new System.EventHandler(this.btnAcceptNewCreditCard_Click);
            // 
            // lblCreditCardName
            // 
            this.lblCreditCardName.AutoSize = true;
            this.lblCreditCardName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreditCardName.Location = new System.Drawing.Point(102, 253);
            this.lblCreditCardName.Name = "lblCreditCardName";
            this.lblCreditCardName.Size = new System.Drawing.Size(132, 37);
            this.lblCreditCardName.TabIndex = 4;
            this.lblCreditCardName.Text = "Nombre";
            // 
            // lblCreditCardCompany
            // 
            this.lblCreditCardCompany.AutoSize = true;
            this.lblCreditCardCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreditCardCompany.Location = new System.Drawing.Point(102, 325);
            this.lblCreditCardCompany.Name = "lblCreditCardCompany";
            this.lblCreditCardCompany.Size = new System.Drawing.Size(80, 37);
            this.lblCreditCardCompany.TabIndex = 5;
            this.lblCreditCardCompany.Text = "Tipo";
            // 
            // lblCreditCardNumber
            // 
            this.lblCreditCardNumber.AutoSize = true;
            this.lblCreditCardNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreditCardNumber.Location = new System.Drawing.Point(102, 390);
            this.lblCreditCardNumber.Name = "lblCreditCardNumber";
            this.lblCreditCardNumber.Size = new System.Drawing.Size(132, 37);
            this.lblCreditCardNumber.TabIndex = 6;
            this.lblCreditCardNumber.Text = "Numero";
            // 
            // lblCreditCardCode
            // 
            this.lblCreditCardCode.AutoSize = true;
            this.lblCreditCardCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreditCardCode.Location = new System.Drawing.Point(102, 461);
            this.lblCreditCardCode.Name = "lblCreditCardCode";
            this.lblCreditCardCode.Size = new System.Drawing.Size(119, 37);
            this.lblCreditCardCode.TabIndex = 7;
            this.lblCreditCardCode.Text = "Codigo";
            // 
            // lblCreditCardExpiration
            // 
            this.lblCreditCardExpiration.AutoSize = true;
            this.lblCreditCardExpiration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreditCardExpiration.Location = new System.Drawing.Point(102, 542);
            this.lblCreditCardExpiration.Name = "lblCreditCardExpiration";
            this.lblCreditCardExpiration.Size = new System.Drawing.Size(193, 37);
            this.lblCreditCardExpiration.TabIndex = 8;
            this.lblCreditCardExpiration.Text = "Vencimiento";
            // 
            // lblCreditCardNotes
            // 
            this.lblCreditCardNotes.AutoSize = true;
            this.lblCreditCardNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreditCardNotes.Location = new System.Drawing.Point(102, 620);
            this.lblCreditCardNotes.Name = "lblCreditCardNotes";
            this.lblCreditCardNotes.Size = new System.Drawing.Size(102, 37);
            this.lblCreditCardNotes.TabIndex = 9;
            this.lblCreditCardNotes.Text = "Notas";
            // 
            // comboBoxCreditCardCategory
            // 
            this.comboBoxCreditCardCategory.FormattingEnabled = true;
            this.comboBoxCreditCardCategory.Location = new System.Drawing.Point(397, 181);
            this.comboBoxCreditCardCategory.Name = "comboBoxCreditCardCategory";
            this.comboBoxCreditCardCategory.Size = new System.Drawing.Size(437, 33);
            this.comboBoxCreditCardCategory.TabIndex = 10;
            // 
            // txtCreditCardName
            // 
            this.txtCreditCardName.Location = new System.Drawing.Point(397, 259);
            this.txtCreditCardName.Name = "txtCreditCardName";
            this.txtCreditCardName.Size = new System.Drawing.Size(437, 31);
            this.txtCreditCardName.TabIndex = 11;
            // 
            // txtCreditCardCompany
            // 
            this.txtCreditCardCompany.Location = new System.Drawing.Point(397, 331);
            this.txtCreditCardCompany.Name = "txtCreditCardCompany";
            this.txtCreditCardCompany.Size = new System.Drawing.Size(437, 31);
            this.txtCreditCardCompany.TabIndex = 12;
            // 
            // txtCreditCardNumber
            // 
            this.txtCreditCardNumber.Location = new System.Drawing.Point(397, 395);
            this.txtCreditCardNumber.Name = "txtCreditCardNumber";
            this.txtCreditCardNumber.Size = new System.Drawing.Size(437, 31);
            this.txtCreditCardNumber.TabIndex = 13;
            // 
            // txtCreditCardCode
            // 
            this.txtCreditCardCode.Location = new System.Drawing.Point(397, 466);
            this.txtCreditCardCode.Name = "txtCreditCardCode";
            this.txtCreditCardCode.Size = new System.Drawing.Size(437, 31);
            this.txtCreditCardCode.TabIndex = 14;
            // 
            // txtCreditCardExpiration
            // 
            this.txtCreditCardExpiration.Location = new System.Drawing.Point(397, 548);
            this.txtCreditCardExpiration.Name = "txtCreditCardExpiration";
            this.txtCreditCardExpiration.Size = new System.Drawing.Size(437, 31);
            this.txtCreditCardExpiration.TabIndex = 15;
            // 
            // txtCreditCardNotes
            // 
            this.txtCreditCardNotes.Location = new System.Drawing.Point(397, 626);
            this.txtCreditCardNotes.Multiline = true;
            this.txtCreditCardNotes.Name = "txtCreditCardNotes";
            this.txtCreditCardNotes.Size = new System.Drawing.Size(437, 175);
            this.txtCreditCardNotes.TabIndex = 16;
            // 
            // lblCreditCardCategory
            // 
            this.lblCreditCardCategory.AutoSize = true;
            this.lblCreditCardCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreditCardCategory.Location = new System.Drawing.Point(102, 181);
            this.lblCreditCardCategory.Name = "lblCreditCardCategory";
            this.lblCreditCardCategory.Size = new System.Drawing.Size(146, 37);
            this.lblCreditCardCategory.TabIndex = 17;
            this.lblCreditCardCategory.Text = "Category";
            // 
            // lblCreditCardError
            // 
            this.lblCreditCardError.AutoSize = true;
            this.lblCreditCardError.ForeColor = System.Drawing.Color.Red;
            this.lblCreditCardError.Location = new System.Drawing.Point(109, 820);
            this.lblCreditCardError.Name = "lblCreditCardError";
            this.lblCreditCardError.Size = new System.Drawing.Size(0, 25);
            this.lblCreditCardError.TabIndex = 18;
            // 
            // AddCreditCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblCreditCardError);
            this.Controls.Add(this.lblCreditCardCategory);
            this.Controls.Add(this.txtCreditCardNotes);
            this.Controls.Add(this.txtCreditCardExpiration);
            this.Controls.Add(this.txtCreditCardCode);
            this.Controls.Add(this.txtCreditCardNumber);
            this.Controls.Add(this.txtCreditCardCompany);
            this.Controls.Add(this.txtCreditCardName);
            this.Controls.Add(this.comboBoxCreditCardCategory);
            this.Controls.Add(this.lblCreditCardNotes);
            this.Controls.Add(this.lblCreditCardExpiration);
            this.Controls.Add(this.lblCreditCardCode);
            this.Controls.Add(this.lblCreditCardNumber);
            this.Controls.Add(this.lblCreditCardCompany);
            this.Controls.Add(this.lblCreditCardName);
            this.Controls.Add(this.btnAcceptNewCreditCard);
            this.Controls.Add(this.lblCreditCardList);
            this.Name = "AddCreditCard";
            this.Size = new System.Drawing.Size(1025, 955);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCreditCardList;
        private System.Windows.Forms.Button btnAcceptNewCreditCard;
        private System.Windows.Forms.Label lblCreditCardName;
        private System.Windows.Forms.Label lblCreditCardCompany;
        private System.Windows.Forms.Label lblCreditCardNumber;
        private System.Windows.Forms.Label lblCreditCardCode;
        private System.Windows.Forms.Label lblCreditCardExpiration;
        private System.Windows.Forms.Label lblCreditCardNotes;
        private System.Windows.Forms.ComboBox comboBoxCreditCardCategory;
        private System.Windows.Forms.TextBox txtCreditCardName;
        private System.Windows.Forms.TextBox txtCreditCardCompany;
        private System.Windows.Forms.TextBox txtCreditCardNumber;
        private System.Windows.Forms.TextBox txtCreditCardCode;
        private System.Windows.Forms.TextBox txtCreditCardExpiration;
        private System.Windows.Forms.TextBox txtCreditCardNotes;
        private System.Windows.Forms.Label lblCreditCardCategory;
        private System.Windows.Forms.Label lblCreditCardError;
    }
}
