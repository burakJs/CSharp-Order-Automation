
namespace BGMOrderAutomation.View
{
    partial class UserHomePage
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
            this.lblUsername = new System.Windows.Forms.Label();
            this.itemList = new System.Windows.Forms.ListView();
            this.idColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.itemNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.itemPriceColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.itemTaxColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.txtItemID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddBasket = new System.Windows.Forms.Button();
            this.comboItemQuantity = new System.Windows.Forms.ComboBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(32, 42);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(370, 76);
            this.lblUsername.TabIndex = 37;
            this.lblUsername.Text = "User Name";
            // 
            // itemList
            // 
            this.itemList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(62)))));
            this.itemList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idColumn,
            this.itemNameColumn,
            this.itemPriceColumn,
            this.itemTaxColumn});
            this.itemList.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.itemList.ForeColor = System.Drawing.Color.White;
            this.itemList.HideSelection = false;
            this.itemList.Location = new System.Drawing.Point(45, 186);
            this.itemList.Margin = new System.Windows.Forms.Padding(6);
            this.itemList.Name = "itemList";
            this.itemList.Size = new System.Drawing.Size(756, 567);
            this.itemList.TabIndex = 49;
            this.itemList.UseCompatibleStateImageBehavior = false;
            this.itemList.View = System.Windows.Forms.View.Details;
            this.itemList.Click += new System.EventHandler(this.itemList_Click);
            // 
            // idColumn
            // 
            this.idColumn.Text = "ID";
            this.idColumn.Width = 105;
            // 
            // itemNameColumn
            // 
            this.itemNameColumn.Text = "Name";
            this.itemNameColumn.Width = 260;
            // 
            // itemPriceColumn
            // 
            this.itemPriceColumn.Text = "Price";
            this.itemPriceColumn.Width = 180;
            // 
            // itemTaxColumn
            // 
            this.itemTaxColumn.Text = "Tax";
            this.itemTaxColumn.Width = 130;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(840, 312);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 55);
            this.label3.TabIndex = 52;
            this.label3.Text = "Quantity";
            // 
            // txtItemID
            // 
            this.txtItemID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(62)))));
            this.txtItemID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItemID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtItemID.ForeColor = System.Drawing.Color.White;
            this.txtItemID.Location = new System.Drawing.Point(1052, 200);
            this.txtItemID.Margin = new System.Windows.Forms.Padding(6);
            this.txtItemID.Name = "txtItemID";
            this.txtItemID.ReadOnly = true;
            this.txtItemID.Size = new System.Drawing.Size(214, 51);
            this.txtItemID.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(840, 210);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 55);
            this.label2.TabIndex = 50;
            this.label2.Text = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(824, 444);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(291, 55);
            this.label4.TabIndex = 54;
            this.label4.Text = "Total Price : ";
            // 
            // btnAddBasket
            // 
            this.btnAddBasket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(62)))));
            this.btnAddBasket.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBasket.ForeColor = System.Drawing.Color.White;
            this.btnAddBasket.Location = new System.Drawing.Point(834, 638);
            this.btnAddBasket.Margin = new System.Windows.Forms.Padding(6);
            this.btnAddBasket.Name = "btnAddBasket";
            this.btnAddBasket.Size = new System.Drawing.Size(434, 115);
            this.btnAddBasket.TabIndex = 55;
            this.btnAddBasket.Text = "Add Basket";
            this.btnAddBasket.UseVisualStyleBackColor = false;
            this.btnAddBasket.Click += new System.EventHandler(this.btnAddBasket_Click);
            // 
            // comboItemQuantity
            // 
            this.comboItemQuantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(62)))));
            this.comboItemQuantity.Cursor = System.Windows.Forms.Cursors.Default;
            this.comboItemQuantity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboItemQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboItemQuantity.ForeColor = System.Drawing.Color.White;
            this.comboItemQuantity.FormattingEnabled = true;
            this.comboItemQuantity.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30"});
            this.comboItemQuantity.Location = new System.Drawing.Point(1052, 312);
            this.comboItemQuantity.Margin = new System.Windows.Forms.Padding(6);
            this.comboItemQuantity.Name = "comboItemQuantity";
            this.comboItemQuantity.Size = new System.Drawing.Size(212, 47);
            this.comboItemQuantity.TabIndex = 56;
            this.comboItemQuantity.SelectedIndexChanged += new System.EventHandler(this.comboItemQuantity_SelectedIndexChanged);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(62)))));
            this.btnBack.BackgroundImage = global::BGMOrderAutomation.Properties.Resources.basket_icon;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(1166, 42);
            this.btnBack.Margin = new System.Windows.Forms.Padding(6);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(102, 90);
            this.btnBack.TabIndex = 48;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBasket_Click);
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblTotalPrice.ForeColor = System.Drawing.Color.White;
            this.lblTotalPrice.Location = new System.Drawing.Point(1103, 444);
            this.lblTotalPrice.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(91, 55);
            this.lblTotalPrice.TabIndex = 57;
            this.lblTotalPrice.Text = "0 $";
            // 
            // UserHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(1300, 815);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.comboItemQuantity);
            this.Controls.Add(this.btnAddBasket);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtItemID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.itemList);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblUsername);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "UserHomePage";
            this.Text = "User Home Page";
            this.Load += new System.EventHandler(this.UserHomePage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ListView itemList;
        private System.Windows.Forms.ColumnHeader idColumn;
        private System.Windows.Forms.ColumnHeader itemNameColumn;
        private System.Windows.Forms.ColumnHeader itemPriceColumn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtItemID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddBasket;
        private System.Windows.Forms.ComboBox comboItemQuantity;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.ColumnHeader itemTaxColumn;
    }
}