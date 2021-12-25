
namespace BGMOrderAutomation.View
{
    partial class CheckPaymentPage
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
            this.btnAddBasket = new System.Windows.Forms.Button();
            this.lblVerified = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtBankID = new System.Windows.Forms.TextBox();
            this.lblTotalPrice = new System.Windows.Forms.Label();
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
            this.btnBack.Location = new System.Drawing.Point(20, 17);
            this.btnBack.Margin = new System.Windows.Forms.Padding(6);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(102, 90);
            this.btnBack.TabIndex = 71;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnAddBasket
            // 
            this.btnAddBasket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(62)))));
            this.btnAddBasket.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBasket.ForeColor = System.Drawing.Color.White;
            this.btnAddBasket.Location = new System.Drawing.Point(578, 596);
            this.btnAddBasket.Margin = new System.Windows.Forms.Padding(6);
            this.btnAddBasket.Name = "btnAddBasket";
            this.btnAddBasket.Size = new System.Drawing.Size(326, 98);
            this.btnAddBasket.TabIndex = 70;
            this.btnAddBasket.Text = "Buy";
            this.btnAddBasket.UseVisualStyleBackColor = false;
            this.btnAddBasket.Click += new System.EventHandler(this.btnAddBasket_Click);
            // 
            // lblVerified
            // 
            this.lblVerified.AutoSize = true;
            this.lblVerified.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lblVerified.ForeColor = System.Drawing.Color.White;
            this.lblVerified.Location = new System.Drawing.Point(130, 463);
            this.lblVerified.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblVerified.Name = "lblVerified";
            this.lblVerified.Size = new System.Drawing.Size(660, 76);
            this.lblVerified.TabIndex = 69;
            this.lblVerified.Text = "Verified / Not Verified";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(166, 325);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 55);
            this.label2.TabIndex = 68;
            this.label2.Text = "Bank ID :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(94, 244);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(329, 55);
            this.label4.TabIndex = 67;
            this.label4.Text = "Check Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(88, 148);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(315, 63);
            this.label3.TabIndex = 66;
            this.label3.Text = "Total Price :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(212, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(493, 76);
            this.label1.TabIndex = 65;
            this.label1.Text = "Credit Payment";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(62)))));
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtName.ForeColor = System.Drawing.Color.White;
            this.txtName.Location = new System.Drawing.Point(400, 240);
            this.txtName.Margin = new System.Windows.Forms.Padding(6);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(412, 51);
            this.txtName.TabIndex = 72;
            // 
            // txtBankID
            // 
            this.txtBankID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(62)))));
            this.txtBankID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBankID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBankID.ForeColor = System.Drawing.Color.White;
            this.txtBankID.Location = new System.Drawing.Point(400, 323);
            this.txtBankID.Margin = new System.Windows.Forms.Padding(6);
            this.txtBankID.Name = "txtBankID";
            this.txtBankID.Size = new System.Drawing.Size(412, 51);
            this.txtBankID.TabIndex = 73;
            this.txtBankID.TextChanged += new System.EventHandler(this.txtBankID_TextChanged);
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblTotalPrice.ForeColor = System.Drawing.Color.White;
            this.lblTotalPrice.Location = new System.Drawing.Point(405, 148);
            this.lblTotalPrice.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(315, 63);
            this.lblTotalPrice.TabIndex = 74;
            this.lblTotalPrice.Text = "Total Price :";
            // 
            // CheckPaymentPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(930, 731);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.txtBankID);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAddBasket);
            this.Controls.Add(this.lblVerified);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "CheckPaymentPage";
            this.Text = "CheckPaymentPage";
            this.Load += new System.EventHandler(this.CheckPaymentPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAddBasket;
        private System.Windows.Forms.Label lblVerified;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtBankID;
        private System.Windows.Forms.Label lblTotalPrice;
    }
}