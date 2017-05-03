namespace SSOPointOfSale
{
    partial class SelectPaymentForm
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
            this.cbxPaymentType = new System.Windows.Forms.ComboBox();
            this.btnConfirmPayment = new System.Windows.Forms.Button();
            this.btnBackToOrder = new System.Windows.Forms.Button();
            this.lblPaymentResult = new System.Windows.Forms.Label();
            this.lblPleaseConfirmPayment = new System.Windows.Forms.Label();
            this.btnOrderComplete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbxPaymentType
            // 
            this.cbxPaymentType.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxPaymentType.FormattingEnabled = true;
            this.cbxPaymentType.Location = new System.Drawing.Point(12, 191);
            this.cbxPaymentType.Name = "cbxPaymentType";
            this.cbxPaymentType.Size = new System.Drawing.Size(475, 36);
            this.cbxPaymentType.TabIndex = 0;
            // 
            // btnConfirmPayment
            // 
            this.btnConfirmPayment.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnConfirmPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmPayment.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmPayment.Location = new System.Drawing.Point(13, 251);
            this.btnConfirmPayment.Name = "btnConfirmPayment";
            this.btnConfirmPayment.Size = new System.Drawing.Size(474, 62);
            this.btnConfirmPayment.TabIndex = 1;
            this.btnConfirmPayment.Text = "Confirm Payment";
            this.btnConfirmPayment.UseVisualStyleBackColor = false;
            this.btnConfirmPayment.Click += new System.EventHandler(this.btnConfirmPayment_Click);
            // 
            // btnBackToOrder
            // 
            this.btnBackToOrder.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnBackToOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackToOrder.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToOrder.Location = new System.Drawing.Point(13, 319);
            this.btnBackToOrder.Name = "btnBackToOrder";
            this.btnBackToOrder.Size = new System.Drawing.Size(474, 62);
            this.btnBackToOrder.TabIndex = 2;
            this.btnBackToOrder.Text = "Back To Order";
            this.btnBackToOrder.UseVisualStyleBackColor = false;
            this.btnBackToOrder.Click += new System.EventHandler(this.btnBackToOrder_Click);
            // 
            // lblPaymentResult
            // 
            this.lblPaymentResult.AutoSize = true;
            this.lblPaymentResult.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentResult.Location = new System.Drawing.Point(126, 432);
            this.lblPaymentResult.Name = "lblPaymentResult";
            this.lblPaymentResult.Size = new System.Drawing.Size(0, 35);
            this.lblPaymentResult.TabIndex = 3;
            // 
            // lblPleaseConfirmPayment
            // 
            this.lblPleaseConfirmPayment.AutoSize = true;
            this.lblPleaseConfirmPayment.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPleaseConfirmPayment.Location = new System.Drawing.Point(73, 80);
            this.lblPleaseConfirmPayment.Name = "lblPleaseConfirmPayment";
            this.lblPleaseConfirmPayment.Size = new System.Drawing.Size(351, 40);
            this.lblPleaseConfirmPayment.TabIndex = 4;
            this.lblPleaseConfirmPayment.Text = "Please Confirm Payment";
            // 
            // btnOrderComplete
            // 
            this.btnOrderComplete.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnOrderComplete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderComplete.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderComplete.Location = new System.Drawing.Point(13, 595);
            this.btnOrderComplete.Name = "btnOrderComplete";
            this.btnOrderComplete.Size = new System.Drawing.Size(474, 62);
            this.btnOrderComplete.TabIndex = 5;
            this.btnOrderComplete.Text = "Order Complete";
            this.btnOrderComplete.UseVisualStyleBackColor = false;
            this.btnOrderComplete.Click += new System.EventHandler(this.btnOrderComplete_Click);
            // 
            // SelectPaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(497, 669);
            this.Controls.Add(this.btnOrderComplete);
            this.Controls.Add(this.lblPleaseConfirmPayment);
            this.Controls.Add(this.lblPaymentResult);
            this.Controls.Add(this.btnBackToOrder);
            this.Controls.Add(this.btnConfirmPayment);
            this.Controls.Add(this.cbxPaymentType);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "SelectPaymentForm";
            this.ShowIcon = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxPaymentType;
        private System.Windows.Forms.Button btnConfirmPayment;
        private System.Windows.Forms.Button btnBackToOrder;
        private System.Windows.Forms.Label lblPaymentResult;
        private System.Windows.Forms.Label lblPleaseConfirmPayment;
        private System.Windows.Forms.Button btnOrderComplete;
    }
}