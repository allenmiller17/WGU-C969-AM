namespace WGU_C969_AM
{
    partial class MainScreen
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
            this.HomeLabel = new System.Windows.Forms.Label();
            this.CustomerLabel = new System.Windows.Forms.Label();
            this.ReportsLabel = new System.Windows.Forms.Label();
            this.CalendarLabel = new System.Windows.Forms.Label();
            this.CalendarDGV = new System.Windows.Forms.DataGridView();
            this.WeekRadio = new System.Windows.Forms.RadioButton();
            this.MonthRadio = new System.Windows.Forms.RadioButton();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.AppointmentButton = new System.Windows.Forms.Button();
            this.SchedulesButton = new System.Windows.Forms.Button();
            this.ReportButton = new System.Windows.Forms.Button();
            this.DeleteCustButton = new System.Windows.Forms.Button();
            this.EditCustButton = new System.Windows.Forms.Button();
            this.AddCustButton = new System.Windows.Forms.Button();
            this.CustomerGB = new System.Windows.Forms.GroupBox();
            this.CalendarGB = new System.Windows.Forms.GroupBox();
            this.ReportsGroupBox = new System.Windows.Forms.GroupBox();
            this.CloseButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CalendarDGV)).BeginInit();
            this.CustomerGB.SuspendLayout();
            this.CalendarGB.SuspendLayout();
            this.ReportsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // HomeLabel
            // 
            this.HomeLabel.AutoSize = true;
            this.HomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeLabel.Location = new System.Drawing.Point(332, 23);
            this.HomeLabel.Name = "HomeLabel";
            this.HomeLabel.Size = new System.Drawing.Size(106, 37);
            this.HomeLabel.TabIndex = 0;
            this.HomeLabel.Text = "Home";
            // 
            // CustomerLabel
            // 
            this.CustomerLabel.AutoSize = true;
            this.CustomerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerLabel.Location = new System.Drawing.Point(26, 37);
            this.CustomerLabel.Name = "CustomerLabel";
            this.CustomerLabel.Size = new System.Drawing.Size(59, 13);
            this.CustomerLabel.TabIndex = 1;
            this.CustomerLabel.Text = "Customer";
            // 
            // ReportsLabel
            // 
            this.ReportsLabel.AutoSize = true;
            this.ReportsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportsLabel.Location = new System.Drawing.Point(63, 37);
            this.ReportsLabel.Name = "ReportsLabel";
            this.ReportsLabel.Size = new System.Drawing.Size(51, 13);
            this.ReportsLabel.TabIndex = 2;
            this.ReportsLabel.Text = "Reports";
            // 
            // CalendarLabel
            // 
            this.CalendarLabel.AutoSize = true;
            this.CalendarLabel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.CalendarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalendarLabel.Location = new System.Drawing.Point(57, 96);
            this.CalendarLabel.Name = "CalendarLabel";
            this.CalendarLabel.Size = new System.Drawing.Size(57, 13);
            this.CalendarLabel.TabIndex = 3;
            this.CalendarLabel.Text = "Calendar";
            // 
            // CalendarDGV
            // 
            this.CalendarDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CalendarDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CalendarDGV.Location = new System.Drawing.Point(12, 128);
            this.CalendarDGV.Name = "CalendarDGV";
            this.CalendarDGV.ReadOnly = true;
            this.CalendarDGV.RowHeadersVisible = false;
            this.CalendarDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CalendarDGV.Size = new System.Drawing.Size(864, 239);
            this.CalendarDGV.TabIndex = 4;
            // 
            // WeekRadio
            // 
            this.WeekRadio.AutoSize = true;
            this.WeekRadio.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.WeekRadio.Checked = true;
            this.WeekRadio.Location = new System.Drawing.Point(705, 19);
            this.WeekRadio.Name = "WeekRadio";
            this.WeekRadio.Size = new System.Drawing.Size(54, 17);
            this.WeekRadio.TabIndex = 1;
            this.WeekRadio.TabStop = true;
            this.WeekRadio.Text = "Week";
            this.WeekRadio.UseVisualStyleBackColor = false;
            this.WeekRadio.CheckedChanged += new System.EventHandler(this.WeekRadio_CheckedChanged);
            // 
            // MonthRadio
            // 
            this.MonthRadio.AutoSize = true;
            this.MonthRadio.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.MonthRadio.Location = new System.Drawing.Point(802, 19);
            this.MonthRadio.Name = "MonthRadio";
            this.MonthRadio.Size = new System.Drawing.Size(55, 17);
            this.MonthRadio.TabIndex = 2;
            this.MonthRadio.Text = "Month";
            this.MonthRadio.UseVisualStyleBackColor = false;
            this.MonthRadio.CheckedChanged += new System.EventHandler(this.MonthRadio_CheckedChanged);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(249, 410);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 5;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(125, 410);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(75, 23);
            this.EditButton.TabIndex = 4;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(12, 410);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 3;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // AppointmentButton
            // 
            this.AppointmentButton.Location = new System.Drawing.Point(30, 69);
            this.AppointmentButton.Name = "AppointmentButton";
            this.AppointmentButton.Size = new System.Drawing.Size(119, 23);
            this.AppointmentButton.TabIndex = 6;
            this.AppointmentButton.Text = "Appointment Count";
            this.AppointmentButton.UseVisualStyleBackColor = true;
            this.AppointmentButton.Click += new System.EventHandler(this.AppointmentButton_Click);
            // 
            // SchedulesButton
            // 
            this.SchedulesButton.Location = new System.Drawing.Point(30, 129);
            this.SchedulesButton.Name = "SchedulesButton";
            this.SchedulesButton.Size = new System.Drawing.Size(119, 23);
            this.SchedulesButton.TabIndex = 7;
            this.SchedulesButton.Text = "Schedules";
            this.SchedulesButton.UseVisualStyleBackColor = true;
            this.SchedulesButton.Click += new System.EventHandler(this.SchedulesButton_Click);
            // 
            // ReportButton
            // 
            this.ReportButton.Location = new System.Drawing.Point(30, 190);
            this.ReportButton.Name = "ReportButton";
            this.ReportButton.Size = new System.Drawing.Size(119, 23);
            this.ReportButton.TabIndex = 8;
            this.ReportButton.Text = "Reports";
            this.ReportButton.UseVisualStyleBackColor = true;
            this.ReportButton.Click += new System.EventHandler(this.ReportButton_Click);
            // 
            // DeleteCustButton
            // 
            this.DeleteCustButton.Location = new System.Drawing.Point(20, 190);
            this.DeleteCustButton.Name = "DeleteCustButton";
            this.DeleteCustButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteCustButton.TabIndex = 11;
            this.DeleteCustButton.Text = "Delete";
            this.DeleteCustButton.UseVisualStyleBackColor = true;
            this.DeleteCustButton.Click += new System.EventHandler(this.DeleteCustButton_Click);
            // 
            // EditCustButton
            // 
            this.EditCustButton.Location = new System.Drawing.Point(20, 129);
            this.EditCustButton.Name = "EditCustButton";
            this.EditCustButton.Size = new System.Drawing.Size(75, 23);
            this.EditCustButton.TabIndex = 10;
            this.EditCustButton.Text = "Edit";
            this.EditCustButton.UseVisualStyleBackColor = true;
            this.EditCustButton.Click += new System.EventHandler(this.EditCustButton_Click);
            // 
            // AddCustButton
            // 
            this.AddCustButton.Location = new System.Drawing.Point(20, 69);
            this.AddCustButton.Name = "AddCustButton";
            this.AddCustButton.Size = new System.Drawing.Size(75, 23);
            this.AddCustButton.TabIndex = 9;
            this.AddCustButton.Text = "Add";
            this.AddCustButton.UseVisualStyleBackColor = true;
            this.AddCustButton.Click += new System.EventHandler(this.AddCustButton_Click);
            // 
            // CustomerGB
            // 
            this.CustomerGB.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.CustomerGB.Controls.Add(this.AddCustButton);
            this.CustomerGB.Controls.Add(this.EditCustButton);
            this.CustomerGB.Controls.Add(this.DeleteCustButton);
            this.CustomerGB.Controls.Add(this.CustomerLabel);
            this.CustomerGB.Location = new System.Drawing.Point(1180, 75);
            this.CustomerGB.Name = "CustomerGB";
            this.CustomerGB.Size = new System.Drawing.Size(122, 374);
            this.CustomerGB.TabIndex = 16;
            this.CustomerGB.TabStop = false;
            // 
            // CalendarGB
            // 
            this.CalendarGB.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.CalendarGB.Controls.Add(this.MonthRadio);
            this.CalendarGB.Controls.Add(this.WeekRadio);
            this.CalendarGB.Location = new System.Drawing.Point(0, 75);
            this.CalendarGB.Name = "CalendarGB";
            this.CalendarGB.Size = new System.Drawing.Size(901, 374);
            this.CalendarGB.TabIndex = 17;
            this.CalendarGB.TabStop = false;
            // 
            // ReportsGroupBox
            // 
            this.ReportsGroupBox.Controls.Add(this.ReportsLabel);
            this.ReportsGroupBox.Controls.Add(this.AppointmentButton);
            this.ReportsGroupBox.Controls.Add(this.ReportButton);
            this.ReportsGroupBox.Controls.Add(this.SchedulesButton);
            this.ReportsGroupBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ReportsGroupBox.Location = new System.Drawing.Point(961, 75);
            this.ReportsGroupBox.Name = "ReportsGroupBox";
            this.ReportsGroupBox.Size = new System.Drawing.Size(172, 373);
            this.ReportsGroupBox.TabIndex = 18;
            this.ReportsGroupBox.TabStop = false;
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(1116, 503);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 12;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 538);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.ReportsGroupBox);
            this.Controls.Add(this.CustomerGB);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.CalendarDGV);
            this.Controls.Add(this.CalendarLabel);
            this.Controls.Add(this.HomeLabel);
            this.Controls.Add(this.CalendarGB);
            this.Name = "MainScreen";
            this.Text = "Main Screen";
            this.Load += new System.EventHandler(this.MainScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CalendarDGV)).EndInit();
            this.CustomerGB.ResumeLayout(false);
            this.CustomerGB.PerformLayout();
            this.CalendarGB.ResumeLayout(false);
            this.CalendarGB.PerformLayout();
            this.ReportsGroupBox.ResumeLayout(false);
            this.ReportsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HomeLabel;
        private System.Windows.Forms.Label CustomerLabel;
        private System.Windows.Forms.Label ReportsLabel;
        private System.Windows.Forms.Label CalendarLabel;
        private System.Windows.Forms.DataGridView CalendarDGV;
        private System.Windows.Forms.RadioButton WeekRadio;
        private System.Windows.Forms.RadioButton MonthRadio;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button AppointmentButton;
        private System.Windows.Forms.Button SchedulesButton;
        private System.Windows.Forms.Button ReportButton;
        private System.Windows.Forms.Button DeleteCustButton;
        private System.Windows.Forms.Button EditCustButton;
        private System.Windows.Forms.Button AddCustButton;
        private System.Windows.Forms.GroupBox CustomerGB;
        private System.Windows.Forms.GroupBox CalendarGB;
        private System.Windows.Forms.GroupBox ReportsGroupBox;
        private System.Windows.Forms.Button CloseButton;
    }
}