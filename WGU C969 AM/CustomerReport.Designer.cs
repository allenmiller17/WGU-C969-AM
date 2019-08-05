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
            this.Close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ReportDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // ReportDGV
            // 
            this.ReportDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ReportDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReportDGV.Location = new System.Drawing.Point(29, 103);
            this.ReportDGV.Name = "ReportDGV";
            this.ReportDGV.ReadOnly = true;
            this.ReportDGV.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ReportDGV.RowHeadersVisible = false;
            this.ReportDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
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
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(383, 415);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(75, 23);
            this.Close.TabIndex = 4;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // CustomerReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 450);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.ReportLabel);
            this.Controls.Add(this.ReportDGV);
            this.Name = "CustomerReport";
            this.Text = "Customer Report";
            this.Load += new System.EventHandler(this.CustomerReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReportDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ReportDGV;
        private System.Windows.Forms.Label ReportLabel;
        private System.Windows.Forms.Button Close;
    }
}