namespace WGU_C969_AM
{
    partial class AppointmentCount
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
            this.CountLabel = new System.Windows.Forms.Label();
            this.CountDGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.CountDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // CountLabel
            // 
            this.CountLabel.AutoSize = true;
            this.CountLabel.Location = new System.Drawing.Point(115, 46);
            this.CountLabel.Name = "CountLabel";
            this.CountLabel.Size = new System.Drawing.Size(165, 13);
            this.CountLabel.TabIndex = 0;
            this.CountLabel.Text = "Appointment type count by month";
            // 
            // CountDGV
            // 
            this.CountDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CountDGV.Location = new System.Drawing.Point(54, 95);
            this.CountDGV.Name = "CountDGV";
            this.CountDGV.Size = new System.Drawing.Size(294, 304);
            this.CountDGV.TabIndex = 1;
            // 
            // AppointmentCount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 461);
            this.Controls.Add(this.CountDGV);
            this.Controls.Add(this.CountLabel);
            this.Name = "AppointmentCount";
            this.Text = "Appointment Count";
            ((System.ComponentModel.ISupportInitialize)(this.CountDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CountLabel;
        private System.Windows.Forms.DataGridView CountDGV;
    }
}