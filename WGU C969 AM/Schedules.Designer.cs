namespace WGU_C969_AM
{
    partial class Schedules
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
            this.SchedulesDGV = new System.Windows.Forms.DataGridView();
            this.SchedulesLabel = new System.Windows.Forms.Label();
            this.Close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SchedulesDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // SchedulesDGV
            // 
            this.SchedulesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SchedulesDGV.Location = new System.Drawing.Point(37, 104);
            this.SchedulesDGV.Name = "SchedulesDGV";
            this.SchedulesDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.SchedulesDGV.Size = new System.Drawing.Size(707, 274);
            this.SchedulesDGV.TabIndex = 0;
            this.SchedulesDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SchedulesDGV_CellContentClick);
            // 
            // SchedulesLabel
            // 
            this.SchedulesLabel.AutoSize = true;
            this.SchedulesLabel.Location = new System.Drawing.Point(366, 53);
            this.SchedulesLabel.Name = "SchedulesLabel";
            this.SchedulesLabel.Size = new System.Drawing.Size(94, 13);
            this.SchedulesLabel.TabIndex = 1;
            this.SchedulesLabel.Text = "Current Schedules";
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(669, 415);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(75, 23);
            this.Close.TabIndex = 2;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Schedules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.SchedulesLabel);
            this.Controls.Add(this.SchedulesDGV);
            this.Name = "Schedules";
            this.Text = "Schedules";
            this.Load += new System.EventHandler(this.Schedules_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SchedulesDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView SchedulesDGV;
        private System.Windows.Forms.Label SchedulesLabel;
        private System.Windows.Forms.Button Close;
    }
}