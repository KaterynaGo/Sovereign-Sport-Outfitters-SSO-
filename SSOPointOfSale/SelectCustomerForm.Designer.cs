namespace SSOPointOfSale
{
    partial class frmSelectCustomerForm
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
            this.lblPleaseSelectACustomer = new System.Windows.Forms.Label();
            this.lblCustomerTemp1 = new System.Windows.Forms.Label();
            this.btnNewCustomer = new System.Windows.Forms.Button();
            this.btnCustomerCancel = new System.Windows.Forms.Button();
            this.customerGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCustFirstName = new System.Windows.Forms.TextBox();
            this.txtCustLastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCustPhone = new System.Windows.Forms.TextBox();
            this.emaillbl = new System.Windows.Forms.Label();
            this.txtCustEmail = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.customerGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPleaseSelectACustomer
            // 
            this.lblPleaseSelectACustomer.AutoSize = true;
            this.lblPleaseSelectACustomer.Font = new System.Drawing.Font("Calibri", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPleaseSelectACustomer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPleaseSelectACustomer.Location = new System.Drawing.Point(114, 9);
            this.lblPleaseSelectACustomer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPleaseSelectACustomer.Name = "lblPleaseSelectACustomer";
            this.lblPleaseSelectACustomer.Size = new System.Drawing.Size(325, 46);
            this.lblPleaseSelectACustomer.TabIndex = 0;
            this.lblPleaseSelectACustomer.Text = "Add New Customer";
            // 
            // lblCustomerTemp1
            // 
            this.lblCustomerTemp1.AutoSize = true;
            this.lblCustomerTemp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerTemp1.Location = new System.Drawing.Point(53, 417);
            this.lblCustomerTemp1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCustomerTemp1.Name = "lblCustomerTemp1";
            this.lblCustomerTemp1.Size = new System.Drawing.Size(713, 31);
            this.lblCustomerTemp1.TabIndex = 6;
            this.lblCustomerTemp1.Text = "THIS IS WHERE TEH CUSTOMER GRIDVIEW GOES";
            // 
            // btnNewCustomer
            // 
            this.btnNewCustomer.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewCustomer.Location = new System.Drawing.Point(32, 255);
            this.btnNewCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.btnNewCustomer.Name = "btnNewCustomer";
            this.btnNewCustomer.Size = new System.Drawing.Size(224, 39);
            this.btnNewCustomer.TabIndex = 7;
            this.btnNewCustomer.Text = "Submit";
            this.btnNewCustomer.UseVisualStyleBackColor = true;
            this.btnNewCustomer.Click += new System.EventHandler(this.btnNewCustomer_Click);
            // 
            // btnCustomerCancel
            // 
            this.btnCustomerCancel.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerCancel.Location = new System.Drawing.Point(311, 255);
            this.btnCustomerCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCustomerCancel.Name = "btnCustomerCancel";
            this.btnCustomerCancel.Size = new System.Drawing.Size(224, 39);
            this.btnCustomerCancel.TabIndex = 8;
            this.btnCustomerCancel.Text = "Exit";
            this.btnCustomerCancel.UseVisualStyleBackColor = true;
            this.btnCustomerCancel.Click += new System.EventHandler(this.btnCustomerCancel_Click);
            // 
            // customerGridView
            // 
            this.customerGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerGridView.Location = new System.Drawing.Point(78, 314);
            this.customerGridView.Name = "customerGridView";
            this.customerGridView.Size = new System.Drawing.Size(416, 175);
            this.customerGridView.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(29, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "First name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(29, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Last name:";
            // 
            // txtCustFirstName
            // 
            this.txtCustFirstName.Location = new System.Drawing.Point(138, 73);
            this.txtCustFirstName.Name = "txtCustFirstName";
            this.txtCustFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtCustFirstName.TabIndex = 12;
            // 
            // txtCustLastName
            // 
            this.txtCustLastName.Location = new System.Drawing.Point(138, 111);
            this.txtCustLastName.Name = "txtCustLastName";
            this.txtCustLastName.Size = new System.Drawing.Size(100, 20);
            this.txtCustLastName.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(29, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 24);
            this.label3.TabIndex = 14;
            this.label3.Text = "Phone #:";
            // 
            // txtCustPhone
            // 
            this.txtCustPhone.Location = new System.Drawing.Point(138, 146);
            this.txtCustPhone.Name = "txtCustPhone";
            this.txtCustPhone.Size = new System.Drawing.Size(100, 20);
            this.txtCustPhone.TabIndex = 15;
            // 
            // emaillbl
            // 
            this.emaillbl.AutoSize = true;
            this.emaillbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emaillbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.emaillbl.Location = new System.Drawing.Point(29, 181);
            this.emaillbl.Name = "emaillbl";
            this.emaillbl.Size = new System.Drawing.Size(62, 24);
            this.emaillbl.TabIndex = 16;
            this.emaillbl.Text = "Email:";
            // 
            // txtCustEmail
            // 
            this.txtCustEmail.Location = new System.Drawing.Point(138, 185);
            this.txtCustEmail.Name = "txtCustEmail";
            this.txtCustEmail.Size = new System.Drawing.Size(100, 20);
            this.txtCustEmail.TabIndex = 17;
            // 
            // frmSelectCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(577, 501);
            this.Controls.Add(this.txtCustEmail);
            this.Controls.Add(this.emaillbl);
            this.Controls.Add(this.txtCustPhone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCustLastName);
            this.Controls.Add(this.txtCustFirstName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.customerGridView);
            this.Controls.Add(this.btnCustomerCancel);
            this.Controls.Add(this.btnNewCustomer);
            this.Controls.Add(this.lblCustomerTemp1);
            this.Controls.Add(this.lblPleaseSelectACustomer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmSelectCustomerForm";
            this.ShowIcon = false;
            this.Text = "Please Select Customer";
            ((System.ComponentModel.ISupportInitialize)(this.customerGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPleaseSelectACustomer;
        private System.Windows.Forms.Label lblCustomerTemp1;
        private System.Windows.Forms.Button btnNewCustomer;
        private System.Windows.Forms.Button btnCustomerCancel;
        private System.Windows.Forms.DataGridView customerGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCustFirstName;
        private System.Windows.Forms.TextBox txtCustLastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCustPhone;
        private System.Windows.Forms.Label emaillbl;
        private System.Windows.Forms.TextBox txtCustEmail;
    }
}