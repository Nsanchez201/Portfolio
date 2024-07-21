namespace ARMSWinClient
{
    partial class frmERPSystemForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreditCardMS = new System.Windows.Forms.Button();
            this.btnBehicleInventoryMS = new System.Windows.Forms.Button();
            this.btnCRM = new System.Windows.Forms.Button();
            this.btnHR = new System.Windows.Forms.Button();
            this.btnMarketingMS = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCustomerFieldServicesMS = new System.Windows.Forms.Button();
            this.btnFinanceOperationsMS = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(638, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enterprise Resource Planning (ERP) System Portal";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnCreditCardMS
            // 
            this.btnCreditCardMS.Location = new System.Drawing.Point(186, 55);
            this.btnCreditCardMS.Name = "btnCreditCardMS";
            this.btnCreditCardMS.Size = new System.Drawing.Size(432, 42);
            this.btnCreditCardMS.TabIndex = 1;
            this.btnCreditCardMS.Text = "Credit Card Management System";
            this.btnCreditCardMS.UseVisualStyleBackColor = true;
            this.btnCreditCardMS.Click += new System.EventHandler(this.btnCreditCardMS_Click);
            // 
            // btnBehicleInventoryMS
            // 
            this.btnBehicleInventoryMS.Location = new System.Drawing.Point(186, 103);
            this.btnBehicleInventoryMS.Name = "btnBehicleInventoryMS";
            this.btnBehicleInventoryMS.Size = new System.Drawing.Size(432, 38);
            this.btnBehicleInventoryMS.TabIndex = 2;
            this.btnBehicleInventoryMS.Text = "Vehicle Inventory Maagement System(Coming Soon)";
            this.btnBehicleInventoryMS.UseVisualStyleBackColor = true;
            // 
            // btnCRM
            // 
            this.btnCRM.Location = new System.Drawing.Point(186, 147);
            this.btnCRM.Name = "btnCRM";
            this.btnCRM.Size = new System.Drawing.Size(432, 38);
            this.btnCRM.TabIndex = 3;
            this.btnCRM.Text = "Customer Relationship Management (CRM) System (Coming Soon)";
            this.btnCRM.UseVisualStyleBackColor = true;
            // 
            // btnHR
            // 
            this.btnHR.Location = new System.Drawing.Point(186, 191);
            this.btnHR.Name = "btnHR";
            this.btnHR.Size = new System.Drawing.Size(432, 35);
            this.btnHR.TabIndex = 4;
            this.btnHR.Text = "Human Resource Management System (Coming Soon)";
            this.btnHR.UseVisualStyleBackColor = true;
            // 
            // btnMarketingMS
            // 
            this.btnMarketingMS.Location = new System.Drawing.Point(186, 274);
            this.btnMarketingMS.Name = "btnMarketingMS";
            this.btnMarketingMS.Size = new System.Drawing.Size(432, 41);
            this.btnMarketingMS.TabIndex = 5;
            this.btnMarketingMS.Text = "Marketing System ( Coming Soon)";
            this.btnMarketingMS.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(186, 370);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(432, 36);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit ERP System";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCustomerFieldServicesMS
            // 
            this.btnCustomerFieldServicesMS.Location = new System.Drawing.Point(186, 321);
            this.btnCustomerFieldServicesMS.Name = "btnCustomerFieldServicesMS";
            this.btnCustomerFieldServicesMS.Size = new System.Drawing.Size(432, 43);
            this.btnCustomerFieldServicesMS.TabIndex = 7;
            this.btnCustomerFieldServicesMS.Text = "Customer and Field System (Coming Soon)";
            this.btnCustomerFieldServicesMS.UseVisualStyleBackColor = true;
            // 
            // btnFinanceOperationsMS
            // 
            this.btnFinanceOperationsMS.Location = new System.Drawing.Point(186, 232);
            this.btnFinanceOperationsMS.Name = "btnFinanceOperationsMS";
            this.btnFinanceOperationsMS.Size = new System.Drawing.Size(432, 36);
            this.btnFinanceOperationsMS.TabIndex = 8;
            this.btnFinanceOperationsMS.Text = "Finance and Operations System (Coming Soon)";
            this.btnFinanceOperationsMS.UseVisualStyleBackColor = true;
            // 
            // frmERPSystemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFinanceOperationsMS);
            this.Controls.Add(this.btnCustomerFieldServicesMS);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnMarketingMS);
            this.Controls.Add(this.btnHR);
            this.Controls.Add(this.btnCRM);
            this.Controls.Add(this.btnBehicleInventoryMS);
            this.Controls.Add(this.btnCreditCardMS);
            this.Controls.Add(this.label1);
            this.Name = "frmERPSystemForm";
            this.Text = "Enterprise Resoruse Planning (ERP) System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreditCardMS;
        private System.Windows.Forms.Button btnBehicleInventoryMS;
        private System.Windows.Forms.Button btnCRM;
        private System.Windows.Forms.Button btnHR;
        private System.Windows.Forms.Button btnMarketingMS;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCustomerFieldServicesMS;
        private System.Windows.Forms.Button btnFinanceOperationsMS;
    }
}