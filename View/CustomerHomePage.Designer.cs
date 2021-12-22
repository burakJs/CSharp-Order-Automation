
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "1",
            "Burak",
            "35.86"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "2",
            "Mislina",
            "97.55"}, -1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "3",
            "Gülistan",
            "125.75"}, -1);
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.userList = new System.Windows.Forms.ListView();
            this.idColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.userNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.totalColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnViewAllItems = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Forte", 30F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(295, 44);
            this.label4.TabIndex = 35;
            this.label4.Text = "Company Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Forte", 25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 37);
            this.label1.TabIndex = 36;
            this.label1.Text = "Customer Name";
            // 
            // userList
            // 
            this.userList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(62)))));
            this.userList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idColumn,
            this.userNameColumn,
            this.totalColumn});
            this.userList.Font = new System.Drawing.Font("Forte", 16F);
            this.userList.ForeColor = System.Drawing.Color.White;
            this.userList.HideSelection = false;
            this.userList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.userList.Location = new System.Drawing.Point(20, 123);
            this.userList.Name = "userList";
            this.userList.Size = new System.Drawing.Size(379, 189);
            this.userList.TabIndex = 39;
            this.userList.UseCompatibleStateImageBehavior = false;
            this.userList.View = System.Windows.Forms.View.Details;
            this.userList.Click += new System.EventHandler(this.userList_Click);
            // 
            // idColumn
            // 
            this.idColumn.Text = "ID";
            this.idColumn.Width = 38;
            // 
            // userNameColumn
            // 
            this.userNameColumn.Text = "User Name";
            this.userNameColumn.Width = 221;
            // 
            // totalColumn
            // 
            this.totalColumn.Text = "Total";
            this.totalColumn.Width = 114;
            // 
            // btnViewAllItems
            // 
            this.btnViewAllItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(62)))));
            this.btnViewAllItems.Font = new System.Drawing.Font("Forte", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAllItems.ForeColor = System.Drawing.Color.White;
            this.btnViewAllItems.Location = new System.Drawing.Point(20, 343);
            this.btnViewAllItems.Name = "btnViewAllItems";
            this.btnViewAllItems.Size = new System.Drawing.Size(379, 59);
            this.btnViewAllItems.TabIndex = 40;
            this.btnViewAllItems.Text = "View All Items";
            this.btnViewAllItems.UseVisualStyleBackColor = false;
            this.btnViewAllItems.Click += new System.EventHandler(this.btnViewAllItems_Click);
            // 
            // CustomerHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(425, 424);
            this.Controls.Add(this.btnViewAllItems);
            this.Controls.Add(this.userList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Name = "CustomerHomePage";
            this.Text = "Customer Home Page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView userList;
        private System.Windows.Forms.ColumnHeader idColumn;
        private System.Windows.Forms.ColumnHeader userNameColumn;
        private System.Windows.Forms.ColumnHeader totalColumn;
        private System.Windows.Forms.Button btnViewAllItems;
    }
}