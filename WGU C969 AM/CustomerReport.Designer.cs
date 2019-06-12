namespace WGU_C969_AM
{
    partial class CustomerReport
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
            this.ReportDGV = new System.Windows.Forms.DataGridView();
            this.ReportLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ReportDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // ReportDGV
            // 
            this.ReportDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReportDGV.Location = new System.Drawing.Point(29, 103);
            this.ReportDGV.Name = "ReportDGV";
            this.ReportDGV.Size = new System.Drawing.Size(429, 296);
            this.ReportDGV.TabIndex = 0;
            // 
            // ReportLabel
            // 
            this.ReportLabel.AutoSize = true;
            this.ReportLabel.Location = new System.Drawing.Point(164, 43);
            this.ReportLabel.Name = "ReportLabel";
            this.ReportLabel.Size = new System.Drawing.Size(144, 13);
            this.ReportLabel.TabIndex = 1;
            this.ReportLabel.Text = "Customers with appointments";
            // 
            // CustomerReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 450);
            this.Controls.Add(this.ReportLabel);
            this.Controls.Add(this.ReportDGV);
            this.Name = "CustomerReport";
            this.Text = "Customer Report";
            ((System.ComponentModel.ISupportInitialize)(this.ReportDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ReportDGV;
        private System.Windows.Forms.Label ReportLabel;
    }
}