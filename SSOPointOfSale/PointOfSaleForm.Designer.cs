namespace SSOPointOfSale
{
    public partial class frmPointOfSaleForm
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
            this.rtxtReceipt = new System.Windows.Forms.RichTextBox();
            this.txtEmployeeId = new System.Windows.Forms.TextBox();
            this.txtEmployeePassword = new System.Windows.Forms.TextBox();
            this.lblOrderTemp2 = new System.Windows.Forms.Label();
            this.empIdLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.btnRegisterUnlock = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.btnOrderPayment = new System.Windows.Forms.Button();
            this.btnOrderAddItem = new System.Windows.Forms.Button();
            this.btnOrderCustomer = new System.Windows.Forms.Button();
            this.btnOrderRemoveItem = new System.Windows.Forms.Button();
            this.btnOrderVoid = new System.Windows.Forms.Button();
            this.btnOrderTotal = new System.Windows.Forms.Button();
            this.productGridView = new System.Windows.Forms.DataGridView();
            this.customerGridView = new System.Windows.Forms.DataGridView();
            this.btnSearchItem = new System.Windows.Forms.Button();
            this.btnSearchCustomer = new System.Windows.Forms.Button();
            this.txtSearchItem = new System.Windows.Forms.TextBox();
            this.txtSearchCustomer = new System.Windows.Forms.TextBox();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.btnViewAllItem = new System.Windows.Forms.Button();
            this.btnViewAllCustomers = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.productGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // rtxtReceipt
            // 
            this.rtxtReceipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtReceipt.Location = new System.Drawing.Point(565, 1);
            this.rtxtReceipt.Margin = new System.Windows.Forms.Padding(2);
            this.rtxtReceipt.Name = "rtxtReceipt";
            this.rtxtReceipt.ReadOnly = true;
            this.rtxtReceipt.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtxtReceipt.Size = new System.Drawing.Size(410, 647);
            this.rtxtReceipt.TabIndex = 0;
            this.rtxtReceipt.Text = "";
            // 
            // txtEmployeeId
            // 
            this.txtEmployeeId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeId.Location = new System.Drawing.Point(437, 338);
            this.txtEmployeeId.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmployeeId.Name = "txtEmployeeId";
            this.txtEmployeeId.Size = new System.Drawing.Size(225, 26);
            this.txtEmployeeId.TabIndex = 10;
            // 
            // txtEmployeePassword
            // 
            this.txtEmployeePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeePassword.Location = new System.Drawing.Point(437, 370);
            this.txtEmployeePassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmployeePassword.Name = "txtEmployeePassword";
            this.txtEmployeePassword.PasswordChar = '*';
            this.txtEmployeePassword.Size = new System.Drawing.Size(225, 26);
            this.txtEmployeePassword.TabIndex = 11;
            // 
            // lblOrderTemp2
            // 
            this.lblOrderTemp2.AutoSize = true;
            this.lblOrderTemp2.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderTemp2.Location = new System.Drawing.Point(9, 175);
            this.lblOrderTemp2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOrderTemp2.Name = "lblOrderTemp2";
            this.lblOrderTemp2.Size = new System.Drawing.Size(542, 37);
            this.lblOrderTemp2.TabIndex = 12;
            this.lblOrderTemp2.Text = "THIS IS WHERE TEH ITEM GRIDVIEW GOES";
            this.lblOrderTemp2.Visible = false;
            // 
            // empIdLabel
            // 
            this.empIdLabel.AutoSize = true;
            this.empIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empIdLabel.ForeColor = System.Drawing.Color.White;
            this.empIdLabel.Location = new System.Drawing.Point(329, 340);
            this.empIdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.empIdLabel.Name = "empIdLabel";
            this.empIdLabel.Size = new System.Drawing.Size(104, 20);
            this.empIdLabel.TabIndex = 15;
            this.empIdLabel.Text = "Employee ID:";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.ForeColor = System.Drawing.Color.White;
            this.passwordLabel.Location = new System.Drawing.Point(329, 373);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(82, 20);
            this.passwordLabel.TabIndex = 16;
            this.passwordLabel.Text = "Password:";
            // 
            // btnRegisterUnlock
            // 
            this.btnRegisterUnlock.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterUnlock.Location = new System.Drawing.Point(332, 242);
            this.btnRegisterUnlock.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegisterUnlock.Name = "btnRegisterUnlock";
            this.btnRegisterUnlock.Size = new System.Drawing.Size(329, 81);
            this.btnRegisterUnlock.TabIndex = 17;
            this.btnRegisterUnlock.Text = "Unlock register";
            this.btnRegisterUnlock.UseVisualStyleBackColor = true;
            this.btnRegisterUnlock.Click += new System.EventHandler(this.btnRegisterUnlock_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(9, 604);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(120, 32);
            this.btnExit.TabIndex = 18;
            this.btnExit.Text = "Close register";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployee.Location = new System.Drawing.Point(136, 604);
            this.btnEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(190, 32);
            this.btnEmployee.TabIndex = 19;
            this.btnEmployee.Text = "Lock";
            this.btnEmployee.UseVisualStyleBackColor = true;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // btnOrderPayment
            // 
            this.btnOrderPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderPayment.Location = new System.Drawing.Point(437, 604);
            this.btnOrderPayment.Margin = new System.Windows.Forms.Padding(2);
            this.btnOrderPayment.Name = "btnOrderPayment";
            this.btnOrderPayment.Size = new System.Drawing.Size(120, 32);
            this.btnOrderPayment.TabIndex = 20;
            this.btnOrderPayment.Text = "Payment";
            this.btnOrderPayment.UseVisualStyleBackColor = true;
            this.btnOrderPayment.Click += new System.EventHandler(this.btnOrderPayment_Click);
            // 
            // btnOrderAddItem
            // 
            this.btnOrderAddItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderAddItem.Location = new System.Drawing.Point(9, 50);
            this.btnOrderAddItem.Margin = new System.Windows.Forms.Padding(2);
            this.btnOrderAddItem.Name = "btnOrderAddItem";
            this.btnOrderAddItem.Size = new System.Drawing.Size(120, 32);
            this.btnOrderAddItem.TabIndex = 21;
            this.btnOrderAddItem.Text = "Add item";
            this.btnOrderAddItem.UseVisualStyleBackColor = true;
            this.btnOrderAddItem.Click += new System.EventHandler(this.btnOrderAddItem_Click);
            // 
            // btnOrderCustomer
            // 
            this.btnOrderCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderCustomer.Location = new System.Drawing.Point(9, 13);
            this.btnOrderCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.btnOrderCustomer.Name = "btnOrderCustomer";
            this.btnOrderCustomer.Size = new System.Drawing.Size(120, 32);
            this.btnOrderCustomer.TabIndex = 22;
            this.btnOrderCustomer.Text = "New Customer";
            this.btnOrderCustomer.UseVisualStyleBackColor = true;
            this.btnOrderCustomer.Click += new System.EventHandler(this.btnOrderCustomer_Click);
            // 
            // btnOrderRemoveItem
            // 
            this.btnOrderRemoveItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderRemoveItem.Location = new System.Drawing.Point(136, 50);
            this.btnOrderRemoveItem.Margin = new System.Windows.Forms.Padding(2);
            this.btnOrderRemoveItem.Name = "btnOrderRemoveItem";
            this.btnOrderRemoveItem.Size = new System.Drawing.Size(120, 32);
            this.btnOrderRemoveItem.TabIndex = 23;
            this.btnOrderRemoveItem.Text = "Remove item";
            this.btnOrderRemoveItem.UseVisualStyleBackColor = true;
            // 
            // btnOrderVoid
            // 
            this.btnOrderVoid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderVoid.Location = new System.Drawing.Point(437, 13);
            this.btnOrderVoid.Margin = new System.Windows.Forms.Padding(2);
            this.btnOrderVoid.Name = "btnOrderVoid";
            this.btnOrderVoid.Size = new System.Drawing.Size(120, 32);
            this.btnOrderVoid.TabIndex = 24;
            this.btnOrderVoid.Text = "Void order";
            this.btnOrderVoid.UseVisualStyleBackColor = true;
            this.btnOrderVoid.Click += new System.EventHandler(this.btnOrderVoid_Click);
            // 
            // btnOrderTotal
            // 
            this.btnOrderTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderTotal.Location = new System.Drawing.Point(437, 50);
            this.btnOrderTotal.Margin = new System.Windows.Forms.Padding(2);
            this.btnOrderTotal.Name = "btnOrderTotal";
            this.btnOrderTotal.Size = new System.Drawing.Size(120, 32);
            this.btnOrderTotal.TabIndex = 25;
            this.btnOrderTotal.Text = "Total";
            this.btnOrderTotal.UseVisualStyleBackColor = true;
            this.btnOrderTotal.Click += new System.EventHandler(this.btnOrderTotal_Click);
            // 
            // productGridView
            // 
            this.productGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productGridView.Location = new System.Drawing.Point(9, 114);
            this.productGridView.Margin = new System.Windows.Forms.Padding(2);
            this.productGridView.Name = "productGridView";
            this.productGridView.RowTemplate.Height = 24;
            this.productGridView.Size = new System.Drawing.Size(551, 170);
            this.productGridView.TabIndex = 26;
            // 
            // customerGridView
            // 
            this.customerGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerGridView.Location = new System.Drawing.Point(7, 386);
            this.customerGridView.Margin = new System.Windows.Forms.Padding(2);
            this.customerGridView.Name = "customerGridView";
            this.customerGridView.RowTemplate.Height = 24;
            this.customerGridView.Size = new System.Drawing.Size(554, 122);
            this.customerGridView.TabIndex = 27;
            // 
            // btnSearchItem
            // 
            this.btnSearchItem.Location = new System.Drawing.Point(270, 306);
            this.btnSearchItem.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchItem.Name = "btnSearchItem";
            this.btnSearchItem.Size = new System.Drawing.Size(56, 19);
            this.btnSearchItem.TabIndex = 28;
            this.btnSearchItem.Text = "Search";
            this.btnSearchItem.UseVisualStyleBackColor = true;
            this.btnSearchItem.Click += new System.EventHandler(this.btnSearchItem_Click);
            // 
            // btnSearchCustomer
            // 
            this.btnSearchCustomer.Location = new System.Drawing.Point(300, 534);
            this.btnSearchCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchCustomer.Name = "btnSearchCustomer";
            this.btnSearchCustomer.Size = new System.Drawing.Size(56, 19);
            this.btnSearchCustomer.TabIndex = 29;
            this.btnSearchCustomer.Text = "search";
            this.btnSearchCustomer.UseVisualStyleBackColor = true;
            this.btnSearchCustomer.Click += new System.EventHandler(this.btnSearchCustomer_Click);
            // 
            // txtSearchItem
            // 
            this.txtSearchItem.Location = new System.Drawing.Point(95, 306);
            this.txtSearchItem.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchItem.Name = "txtSearchItem";
            this.txtSearchItem.Size = new System.Drawing.Size(162, 20);
            this.txtSearchItem.TabIndex = 30;
            // 
            // txtSearchCustomer
            // 
            this.txtSearchCustomer.Location = new System.Drawing.Point(122, 535);
            this.txtSearchCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchCustomer.Name = "txtSearchCustomer";
            this.txtSearchCustomer.Size = new System.Drawing.Size(162, 20);
            this.txtSearchCustomer.TabIndex = 31;
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblProduct.Location = new System.Drawing.Point(9, 306);
            this.lblProduct.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(78, 13);
            this.lblProduct.TabIndex = 32;
            this.lblProduct.Text = "Product Name:";
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCustomer.Location = new System.Drawing.Point(9, 534);
            this.lblCustomer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(108, 13);
            this.lblCustomer.TabIndex = 33;
            this.lblCustomer.Text = "Customer Last Name:";
            // 
            // btnViewAllItem
            // 
            this.btnViewAllItem.Location = new System.Drawing.Point(344, 306);
            this.btnViewAllItem.Margin = new System.Windows.Forms.Padding(2);
            this.btnViewAllItem.Name = "btnViewAllItem";
            this.btnViewAllItem.Size = new System.Drawing.Size(56, 19);
            this.btnViewAllItem.TabIndex = 34;
            this.btnViewAllItem.Text = "View All";
            this.btnViewAllItem.UseVisualStyleBackColor = true;
            this.btnViewAllItem.Click += new System.EventHandler(this.btnViewAllItem_Click);
            // 
            // btnViewAllCustomers
            // 
            this.btnViewAllCustomers.Location = new System.Drawing.Point(370, 533);
            this.btnViewAllCustomers.Margin = new System.Windows.Forms.Padding(2);
            this.btnViewAllCustomers.Name = "btnViewAllCustomers";
            this.btnViewAllCustomers.Size = new System.Drawing.Size(56, 19);
            this.btnViewAllCustomers.TabIndex = 35;
            this.btnViewAllCustomers.Text = "View All";
            this.btnViewAllCustomers.UseVisualStyleBackColor = true;
            this.btnViewAllCustomers.Click += new System.EventHandler(this.btnViewAllCustomers_Click);
            // 
            // frmPointOfSaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(973, 648);
            this.Controls.Add(this.btnViewAllCustomers);
            this.Controls.Add(this.btnViewAllItem);
            this.Controls.Add(this.lblCustomer);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.txtSearchCustomer);
            this.Controls.Add(this.txtSearchItem);
            this.Controls.Add(this.btnSearchCustomer);
            this.Controls.Add(this.btnSearchItem);
            this.Controls.Add(this.customerGridView);
            this.Controls.Add(this.productGridView);
            this.Controls.Add(this.btnOrderTotal);
            this.Controls.Add(this.btnOrderVoid);
            this.Controls.Add(this.btnOrderRemoveItem);
            this.Controls.Add(this.btnOrderCustomer);
            this.Controls.Add(this.btnOrderAddItem);
            this.Controls.Add(this.btnOrderPayment);
            this.Controls.Add(this.btnEmployee);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRegisterUnlock);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.empIdLabel);
            this.Controls.Add(this.lblOrderTemp2);
            this.Controls.Add(this.txtEmployeePassword);
            this.Controls.Add(this.txtEmployeeId);
            this.Controls.Add(this.rtxtReceipt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "frmPointOfSaleForm";
            this.Text = "Sovereign Sports Outfitters point of sale";
            this.Load += new System.EventHandler(this.frmPointOfSaleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxtReceipt;
        private System.Windows.Forms.Label lblOrderTemp2;
        private System.Windows.Forms.Label empIdLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Button btnRegisterUnlock;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Button btnOrderPayment;
        private System.Windows.Forms.Button btnOrderAddItem;
        private System.Windows.Forms.Button btnOrderCustomer;
        private System.Windows.Forms.Button btnOrderRemoveItem;
        private System.Windows.Forms.Button btnOrderVoid;
        private System.Windows.Forms.Button btnOrderTotal;
        public System.Windows.Forms.TextBox txtEmployeeId;
        public System.Windows.Forms.TextBox txtEmployeePassword;
        private System.Windows.Forms.DataGridView productGridView;
        private System.Windows.Forms.DataGridView customerGridView;
        private System.Windows.Forms.Button btnSearchItem;
        private System.Windows.Forms.Button btnSearchCustomer;
        private System.Windows.Forms.TextBox txtSearchItem;
        private System.Windows.Forms.TextBox txtSearchCustomer;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Button btnViewAllItem;
        private System.Windows.Forms.Button btnViewAllCustomers;
    }
}

