namespace ARMSWinClient
{
    partial class frmMainWelcomeForm
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
            this.IblTitle = new System.Windows.Forms.Label();
            this.btnPOS = new System.Windows.Forms.Button();
            this.btnERP = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IblTitle
            // 
            this.IblTitle.AutoSize = true;
            this.IblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IblTitle.Location = new System.Drawing.Point(206, 9);
            this.IblTitle.Name = "IblTitle";
            this.IblTitle.Size = new System.Drawing.Size(290, 29);
            this.IblTitle.TabIndex = 0;
            this.IblTitle.Text = "EZRental POS System";
            this.IblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.IblTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnPOS
            // 
            this.btnPOS.Location = new System.Drawing.Point(188, 41);
            this.btnPOS.Name = "btnPOS";
            this.btnPOS.Size = new System.Drawing.Size(331, 48);
            this.btnPOS.TabIndex = 1;
            this.btnPOS.Text = "Point-of-Sales and Rentals";
            this.btnPOS.UseVisualStyleBackColor = true;
            this.btnPOS.Click += new System.EventHandler(this.btnPOS_Click);
            // 
            // btnERP
            // 
            this.btnERP.Location = new System.Drawing.Point(188, 95);
            this.btnERP.Name = "btnERP";
            this.btnERP.Size = new System.Drawing.Size(331, 43);
            this.btnERP.TabIndex = 2;
            this.btnERP.Text = "Enterprise Resource Planning (ERP) System Portal";
            this.btnERP.UseVisualStyleBackColor = true;
            this.btnERP.Click += new System.EventHandler(this.btnERP_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(188, 144);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(331, 47);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmMainWelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 362);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnERP);
            this.Controls.Add(this.btnPOS);
            this.Controls.Add(this.IblTitle);
            this.Name = "frmMainWelcomeForm";
            this.Text = "EZRental POS System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IblTitle;
        private System.Windows.Forms.Button btnPOS;
        private System.Windows.Forms.Button btnERP;
        private System.Windows.Forms.Button btnExit;
    }
}

