
namespace BGMOrderAutomation.View
{
    partial class BasketDetailPage
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
            this.lblDate = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.orderDetailList = new System.Windows.Forms.ListView();
            this.idColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.itemNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.itemTaxColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.itemQuantityColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.totalPriceColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.radioCash = new System.Windows.Forms.RadioButton();
            this.radioCredit = new System.Windows.Forms.RadioButton();
            this.radioCheck = new System.Windows.Forms.RadioButton();
            this.btnAddBasket = new System.Windows.Forms.Button();
            this.lblTotalTax = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(24, 17);
            this.lblDate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(174, 76);
            this.lblDate.TabIndex = 38;
            this.lblDate.Text = "Date";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Location = new System.Drawing.Point(896, 17);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(70, 76);
            this.lblStatus.TabIndex = 39;
            this.lblStatus.Text = "_";
            // 
            // orderDetailList
            // 
            this.orderDetailList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(62)))));
            this.orderDetailList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idColumn,
            this.itemNameColumn,
            this.itemTaxColumn,
            this.itemQuantityColumn,
            this.totalPriceColumn});
            this.orderDetailList.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.orderDetailList.ForeColor = System.Drawing.Color.White;
            this.orderDetailList.HideSelection = false;
            this.orderDetailList.Location = new System.Drawing.Point(38, 94);
            this.orderDetailList.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.orderDetailList.Name = "orderDetailList";
            this.orderDetailList.Size = new System.Drawing.Size(1074, 469);
            this.orderDetailList.TabIndex = 50;
            this.orderDetailList.UseCompatibleStateImageBehavior = false;
            this.orderDetailList.View = System.Windows.Forms.View.Details;
            // 
            // idColumn
            // 
            this.idColumn.Text = "ID";
            this.idColumn.Width = 73;
            // 
            // itemNameColumn
            // 
            this.itemNameColumn.Text = "Name";
            this.itemNameColumn.Width = 192;
            // 
            // itemTaxColumn
            // 
            this.itemTaxColumn.Text = "Tax";
            this.itemTaxColumn.Width = 122;
            // 
            // itemQuantityColumn
            // 
            this.itemQuantityColumn.Text = "Quantity";
            this.itemQuantityColumn.Width = 200;
            // 
            // totalPriceColumn
            // 
            this.totalPriceColumn.Text = "Total Price";
            this.totalPriceColumn.Width = 332;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(118, 602);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(281, 63);
            this.label3.TabIndex = 51;
            this.label3.Text = "Total Tax :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(142, 660);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(255, 63);
            this.label4.TabIndex = 52;
            this.label4.Text = "Subtotal :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 742);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(388, 76);
            this.label5.TabIndex = 53;
            this.label5.Text = "Total Price :";
            // 
            // radioCash
            // 
            this.radioCash.AutoSize = true;
            this.radioCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.radioCash.ForeColor = System.Drawing.Color.White;
            this.radioCash.Location = new System.Drawing.Point(452, 848);
            this.radioCash.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.radioCash.Name = "radioCash";
            this.radioCash.Size = new System.Drawing.Size(168, 59);
            this.radioCash.TabIndex = 55;
            this.radioCash.TabStop = true;
            this.radioCash.Text = "Cash";
            this.radioCash.UseVisualStyleBackColor = true;
            // 
            // radioCredit
            // 
            this.radioCredit.AutoSize = true;
            this.radioCredit.Checked = true;
            this.radioCredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.radioCredit.ForeColor = System.Drawing.Color.White;
            this.radioCredit.Location = new System.Drawing.Point(238, 848);
            this.radioCredit.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.radioCredit.Name = "radioCredit";
            this.radioCredit.Size = new System.Drawing.Size(183, 59);
            this.radioCredit.TabIndex = 54;
            this.radioCredit.TabStop = true;
            this.radioCredit.Text = "Credit";
            this.radioCredit.UseVisualStyleBackColor = true;
            // 
            // radioCheck
            // 
            this.radioCheck.AutoSize = true;
            this.radioCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.radioCheck.ForeColor = System.Drawing.Color.White;
            this.radioCheck.Location = new System.Drawing.Point(662, 848);
            this.radioCheck.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.radioCheck.Name = "radioCheck";
            this.radioCheck.Size = new System.Drawing.Size(192, 59);
            this.radioCheck.TabIndex = 56;
            this.radioCheck.TabStop = true;
            this.radioCheck.Text = "Check";
            this.radioCheck.UseVisualStyleBackColor = true;
            // 
            // btnAddBasket
            // 
            this.btnAddBasket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(62)))));
            this.btnAddBasket.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBasket.ForeColor = System.Drawing.Color.White;
            this.btnAddBasket.Location = new System.Drawing.Point(804, 917);
            this.btnAddBasket.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnAddBasket.Name = "btnAddBasket";
            this.btnAddBasket.Size = new System.Drawing.Size(326, 98);
            this.btnAddBasket.TabIndex = 57;
            this.btnAddBasket.Text = "Go Payment";
            this.btnAddBasket.UseVisualStyleBackColor = false;
            this.btnAddBasket.Click += new System.EventHandler(this.btnAddBasket_Click);
            // 
            // lblTotalTax
            // 
            this.lblTotalTax.AutoSize = true;
            this.lblTotalTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblTotalTax.ForeColor = System.Drawing.Color.White;
            this.lblTotalTax.Location = new System.Drawing.Point(831, 588);
            this.lblTotalTax.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTotalTax.Name = "lblTotalTax";
            this.lblTotalTax.Size = new System.Drawing.Size(281, 63);
            this.lblTotalTax.TabIndex = 58;
            this.lblTotalTax.Text = "Total Tax :";
            this.lblTotalTax.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblSubTotal.ForeColor = System.Drawing.Color.White;
            this.lblSubTotal.Location = new System.Drawing.Point(831, 651);
            this.lblSubTotal.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(281, 63);
            this.lblSubTotal.TabIndex = 59;
            this.lblSubTotal.Text = "Total Tax :";
            this.lblSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lblTotalPrice.ForeColor = System.Drawing.Color.White;
            this.lblTotalPrice.Location = new System.Drawing.Point(724, 742);
            this.lblTotalPrice.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(388, 76);
            this.lblTotalPrice.TabIndex = 60;
            this.lblTotalPrice.Text = "Total Price :";
            this.lblTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BasketDetailPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(1154, 1038);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.lblSubTotal);
            this.Controls.Add(this.lblTotalTax);
            this.Controls.Add(this.btnAddBasket);
            this.Controls.Add(this.radioCheck);
            this.Controls.Add(this.radioCash);
            this.Controls.Add(this.radioCredit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.orderDetailList);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblDate);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "BasketDetailPage";
            this.Text = "Basket Detail Page";
            this.Load += new System.EventHandler(this.BasketDetailPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ListView orderDetailList;
        private System.Windows.Forms.ColumnHeader idColumn;
        private System.Windows.Forms.ColumnHeader itemNameColumn;
        private System.Windows.Forms.ColumnHeader itemTaxColumn;
        private System.Windows.Forms.ColumnHeader itemQuantityColumn;
        private System.Windows.Forms.ColumnHeader totalPriceColumn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioCash;
        private System.Windows.Forms.RadioButton radioCredit;
        private System.Windows.Forms.RadioButton radioCheck;
        private System.Windows.Forms.Button btnAddBasket;
        private System.Windows.Forms.Label lblTotalTax;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label lblTotalPrice;
    }
}