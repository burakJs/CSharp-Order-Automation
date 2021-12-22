
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "1",
            "Apple",
            "%8",
            "3",
            "24 $"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "2",
            "Strawberry",
            "%18",
            "5",
            "35.50 $"}, -1);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Forte", 25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 37);
            this.label1.TabIndex = 38;
            this.label1.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Forte", 25F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(448, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 37);
            this.label2.TabIndex = 39;
            this.label2.Text = "Status";
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
            this.orderDetailList.Font = new System.Drawing.Font("Forte", 16F);
            this.orderDetailList.ForeColor = System.Drawing.Color.White;
            this.orderDetailList.HideSelection = false;
            this.orderDetailList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.orderDetailList.Location = new System.Drawing.Point(19, 49);
            this.orderDetailList.Name = "orderDetailList";
            this.orderDetailList.Size = new System.Drawing.Size(539, 246);
            this.orderDetailList.TabIndex = 50;
            this.orderDetailList.UseCompatibleStateImageBehavior = false;
            this.orderDetailList.View = System.Windows.Forms.View.Details;
            // 
            // idColumn
            // 
            this.idColumn.Text = "ID";
            this.idColumn.Width = 42;
            // 
            // itemNameColumn
            // 
            this.itemNameColumn.Text = "Name";
            this.itemNameColumn.Width = 192;
            // 
            // itemTaxColumn
            // 
            this.itemTaxColumn.Text = "Tax";
            this.itemTaxColumn.Width = 70;
            // 
            // itemQuantityColumn
            // 
            this.itemQuantityColumn.Text = "Quantity";
            this.itemQuantityColumn.Width = 98;
            // 
            // totalPriceColumn
            // 
            this.totalPriceColumn.Text = "Total Price";
            this.totalPriceColumn.Width = 133;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Forte", 20F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(59, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 30);
            this.label3.TabIndex = 51;
            this.label3.Text = "Total Tax :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Forte", 20F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(71, 343);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 30);
            this.label4.TabIndex = 52;
            this.label4.Text = "Subtotal :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Forte", 25F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(6, 386);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 37);
            this.label5.TabIndex = 53;
            this.label5.Text = "Total Price :";
            // 
            // radioCash
            // 
            this.radioCash.AutoSize = true;
            this.radioCash.Font = new System.Drawing.Font("Forte", 18F);
            this.radioCash.ForeColor = System.Drawing.Color.White;
            this.radioCash.Location = new System.Drawing.Point(226, 441);
            this.radioCash.Name = "radioCash";
            this.radioCash.Size = new System.Drawing.Size(81, 30);
            this.radioCash.TabIndex = 55;
            this.radioCash.TabStop = true;
            this.radioCash.Text = "Cash";
            this.radioCash.UseVisualStyleBackColor = true;
            // 
            // radioCredit
            // 
            this.radioCredit.AutoSize = true;
            this.radioCredit.Checked = true;
            this.radioCredit.Font = new System.Drawing.Font("Forte", 18F);
            this.radioCredit.ForeColor = System.Drawing.Color.White;
            this.radioCredit.Location = new System.Drawing.Point(119, 441);
            this.radioCredit.Name = "radioCredit";
            this.radioCredit.Size = new System.Drawing.Size(91, 30);
            this.radioCredit.TabIndex = 54;
            this.radioCredit.TabStop = true;
            this.radioCredit.Text = "Credit";
            this.radioCredit.UseVisualStyleBackColor = true;
            // 
            // radioCheck
            // 
            this.radioCheck.AutoSize = true;
            this.radioCheck.Font = new System.Drawing.Font("Forte", 18F);
            this.radioCheck.ForeColor = System.Drawing.Color.White;
            this.radioCheck.Location = new System.Drawing.Point(331, 441);
            this.radioCheck.Name = "radioCheck";
            this.radioCheck.Size = new System.Drawing.Size(88, 30);
            this.radioCheck.TabIndex = 56;
            this.radioCheck.TabStop = true;
            this.radioCheck.Text = "Check";
            this.radioCheck.UseVisualStyleBackColor = true;
            // 
            // btnAddBasket
            // 
            this.btnAddBasket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(62)))));
            this.btnAddBasket.Font = new System.Drawing.Font("Forte", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBasket.ForeColor = System.Drawing.Color.White;
            this.btnAddBasket.Location = new System.Drawing.Point(402, 477);
            this.btnAddBasket.Name = "btnAddBasket";
            this.btnAddBasket.Size = new System.Drawing.Size(163, 51);
            this.btnAddBasket.TabIndex = 57;
            this.btnAddBasket.Text = "Go Payment";
            this.btnAddBasket.UseVisualStyleBackColor = false;
            this.btnAddBasket.Click += new System.EventHandler(this.btnAddBasket_Click);
            // 
            // BasketDetailPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(577, 540);
            this.Controls.Add(this.btnAddBasket);
            this.Controls.Add(this.radioCheck);
            this.Controls.Add(this.radioCash);
            this.Controls.Add(this.radioCredit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.orderDetailList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BasketDetailPage";
            this.Text = "Basket Detail Page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
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
    }
}