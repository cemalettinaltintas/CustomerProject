namespace CustomerProject
{
    partial class FrmStatistics
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCityCount = new System.Windows.Forms.Label();
            this.lblCustomerCount = new System.Windows.Forms.Label();
            this.lblCutomerBalance = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Toplam Şehir Sayısı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 120);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Toplam Müşteri Sayısı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 175);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Müşterilerin Toplam Bakiyesi :";
            // 
            // lblCityCount
            // 
            this.lblCityCount.AutoSize = true;
            this.lblCityCount.Location = new System.Drawing.Point(382, 66);
            this.lblCityCount.Name = "lblCityCount";
            this.lblCityCount.Size = new System.Drawing.Size(14, 15);
            this.lblCityCount.TabIndex = 1;
            this.lblCityCount.Text = "0";
            // 
            // lblCustomerCount
            // 
            this.lblCustomerCount.AutoSize = true;
            this.lblCustomerCount.Location = new System.Drawing.Point(382, 120);
            this.lblCustomerCount.Name = "lblCustomerCount";
            this.lblCustomerCount.Size = new System.Drawing.Size(14, 15);
            this.lblCustomerCount.TabIndex = 1;
            this.lblCustomerCount.Text = "0";
            // 
            // lblCutomerBalance
            // 
            this.lblCutomerBalance.AutoSize = true;
            this.lblCutomerBalance.Location = new System.Drawing.Point(382, 175);
            this.lblCutomerBalance.Name = "lblCutomerBalance";
            this.lblCutomerBalance.Size = new System.Drawing.Size(14, 15);
            this.lblCutomerBalance.TabIndex = 1;
            this.lblCutomerBalance.Text = "0";
            // 
            // FrmStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 267);
            this.Controls.Add(this.lblCutomerBalance);
            this.Controls.Add(this.lblCustomerCount);
            this.Controls.Add(this.lblCityCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmStatistics";
            this.Text = "FrmStatistics";
            this.Load += new System.EventHandler(this.FrmStatistics_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCityCount;
        private System.Windows.Forms.Label lblCustomerCount;
        private System.Windows.Forms.Label lblCutomerBalance;
    }
}