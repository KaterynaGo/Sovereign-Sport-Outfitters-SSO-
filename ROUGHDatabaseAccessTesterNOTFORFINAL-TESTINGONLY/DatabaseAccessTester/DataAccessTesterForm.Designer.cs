namespace DatabaseAccessTester
{
    partial class frmDataAccessTesterForm
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.rtxtResultant = new System.Windows.Forms.RichTextBox();
            this.btnTestConnection = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(355, 9);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(423, 29);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "C# to MySQL Data Connection Test";
            // 
            // rtxtResultant
            // 
            this.rtxtResultant.Location = new System.Drawing.Point(13, 375);
            this.rtxtResultant.Name = "rtxtResultant";
            this.rtxtResultant.ReadOnly = true;
            this.rtxtResultant.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtxtResultant.Size = new System.Drawing.Size(1087, 307);
            this.rtxtResultant.TabIndex = 1;
            this.rtxtResultant.Text = "";
            // 
            // btnTestConnection
            // 
            this.btnTestConnection.Location = new System.Drawing.Point(13, 69);
            this.btnTestConnection.Name = "btnTestConnection";
            this.btnTestConnection.Size = new System.Drawing.Size(143, 36);
            this.btnTestConnection.TabIndex = 2;
            this.btnTestConnection.Text = "Test Connection";
            this.btnTestConnection.UseVisualStyleBackColor = true;
            this.btnTestConnection.Click += new System.EventHandler(this.btnTestConnection_Click);
            // 
            // frmDataAccessTesterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 694);
            this.Controls.Add(this.btnTestConnection);
            this.Controls.Add(this.rtxtResultant);
            this.Controls.Add(this.lblWelcome);
            this.Name = "frmDataAccessTesterForm";
            this.Text = "C# to MySQL Test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        public System.Windows.Forms.RichTextBox rtxtResultant;
        private System.Windows.Forms.Button btnTestConnection;
    }
}

