
namespace BGMOrderAutomation.View
{
    partial class CustomerHomePage
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
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.userList = new System.Windows.Forms.ListView();
            this.idColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.userNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.totalColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnViewAllItems = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lblCompanyName.ForeColor = System.Drawing.Color.White;
            this.lblCompanyName.Location = new System.Drawing.Point(24, 17);
            this.lblCompanyName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(614, 91);
            this.lblCompanyName.TabIndex = 35;
            this.lblCompanyName.Text = "Company Name";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lblCustomerName.ForeColor = System.Drawing.Color.White;
            this.lblCustomerName.Location = new System.Drawing.Point(26, 108);
            this.lblCustomerName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(519, 76);
            this.lblCustomerName.TabIndex = 36;
            this.lblCustomerName.Text = "Customer Name";
            // 
            // userList
            // 
            this.userList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(62)))));
            this.userList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idColumn,
            this.userNameColumn,
            this.totalColumn});
            this.userList.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.userList.ForeColor = System.Drawing.Color.White;
            this.userList.HideSelection = false;
            this.userList.Location = new System.Drawing.Point(40, 237);
            this.userList.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.userList.Name = "userList";
            this.userList.Size = new System.Drawing.Size(754, 360);
            this.userList.TabIndex = 39;
            this.userList.UseCompatibleStateImageBehavior = false;
            this.userList.View = System.Windows.Forms.View.Details;
            // 
            // idColumn
            // 
            this.idColumn.Text = "ID";
            this.idColumn.Width = 110;
            // 
            // userNameColumn
            // 
            this.userNameColumn.Text = "User Name";
            this.userNameColumn.Width = 322;
            // 
            // totalColumn
            // 
            this.totalColumn.Text = "Total";
            this.totalColumn.Width = 114;
            // 
            // btnViewAllItems
            // 
            this.btnViewAllItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(62)))));
            this.btnViewAllItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAllItems.ForeColor = System.Drawing.Color.White;
            this.btnViewAllItems.Location = new System.Drawing.Point(40, 660);
            this.btnViewAllItems.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnViewAllItems.Name = "btnViewAllItems";
            this.btnViewAllItems.Size = new System.Drawing.Size(758, 113);
            this.btnViewAllItems.TabIndex = 40;
            this.btnViewAllItems.Text = "View All Items";
            this.btnViewAllItems.UseVisualStyleBackColor = false;
            this.btnViewAllItems.Click += new System.EventHandler(this.btnViewAllItems_Click);
            // 
            // CustomerHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(850, 815);
            this.Controls.Add(this.btnViewAllItems);
            this.Controls.Add(this.userList);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.lblCompanyName);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "CustomerHomePage";
            this.Text = "Customer Home Page";
            this.Load += new System.EventHandler(this.CustomerHomePage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.ListView userList;
        private System.Windows.Forms.ColumnHeader idColumn;
        private System.Windows.Forms.ColumnHeader userNameColumn;
        private System.Windows.Forms.ColumnHeader totalColumn;
        private System.Windows.Forms.Button btnViewAllItems;
    }
}