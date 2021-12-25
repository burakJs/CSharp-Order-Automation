
namespace BGMOrderAutomation.View
{
    partial class CustomerItemsPage
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
            this.btnBack = new System.Windows.Forms.Button();
            this.companyItemList = new System.Windows.Forms.ListView();
            this.idColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.itemNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.quantityColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.taxColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.priceForUnit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblCompanyTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(62)))));
            this.btnBack.BackgroundImage = global::BGMOrderAutomation.Properties.Resources.back_arrow;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(24, 19);
            this.btnBack.Margin = new System.Windows.Forms.Padding(6);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(102, 90);
            this.btnBack.TabIndex = 47;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // companyItemList
            // 
            this.companyItemList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(62)))));
            this.companyItemList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idColumn,
            this.itemNameColumn,
            this.quantityColumn,
            this.columnHeader1,
            this.taxColumn,
            this.priceForUnit});
            this.companyItemList.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.companyItemList.ForeColor = System.Drawing.Color.White;
            this.companyItemList.HideSelection = false;
            this.companyItemList.Location = new System.Drawing.Point(24, 185);
            this.companyItemList.Margin = new System.Windows.Forms.Padding(6);
            this.companyItemList.Name = "companyItemList";
            this.companyItemList.Size = new System.Drawing.Size(1010, 523);
            this.companyItemList.TabIndex = 46;
            this.companyItemList.UseCompatibleStateImageBehavior = false;
            this.companyItemList.View = System.Windows.Forms.View.Details;
            this.companyItemList.DoubleClick += new System.EventHandler(this.companyItemList_DoubleClick);
            // 
            // idColumn
            // 
            this.idColumn.Text = "ID";
            this.idColumn.Width = 38;
            // 
            // itemNameColumn
            // 
            this.itemNameColumn.Text = "Name";
            this.itemNameColumn.Width = 244;
            // 
            // quantityColumn
            // 
            this.quantityColumn.Text = "Quantity";
            this.quantityColumn.Width = 210;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Weight";
            this.columnHeader1.Width = 307;
            // 
            // taxColumn
            // 
            this.taxColumn.Text = "Tax";
            this.taxColumn.Width = 129;
            // 
            // priceForUnit
            // 
            this.priceForUnit.Text = "Price";
            this.priceForUnit.Width = 173;
            // 
            // lblCompanyTitle
            // 
            this.lblCompanyTitle.AutoSize = true;
            this.lblCompanyTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lblCompanyTitle.ForeColor = System.Drawing.Color.White;
            this.lblCompanyTitle.Location = new System.Drawing.Point(168, 25);
            this.lblCompanyTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCompanyTitle.Name = "lblCompanyTitle";
            this.lblCompanyTitle.Size = new System.Drawing.Size(885, 91);
            this.lblCompanyTitle.TabIndex = 44;
            this.lblCompanyTitle.Text = "Company Name\'s Items";
            this.lblCompanyTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CustomerItemsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(1066, 746);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.companyItemList);
            this.Controls.Add(this.lblCompanyTitle);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "CustomerItemsPage";
            this.Text = "CustomerItemsPage";
            this.Load += new System.EventHandler(this.CustomerItemsPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ListView companyItemList;
        private System.Windows.Forms.ColumnHeader idColumn;
        private System.Windows.Forms.ColumnHeader itemNameColumn;
        private System.Windows.Forms.ColumnHeader quantityColumn;
        private System.Windows.Forms.ColumnHeader priceForUnit;
        private System.Windows.Forms.Label lblCompanyTitle;
        private System.Windows.Forms.ColumnHeader taxColumn;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}