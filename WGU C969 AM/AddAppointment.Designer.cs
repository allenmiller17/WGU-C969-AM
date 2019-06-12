namespace WGU_C969_AM
{
    partial class AddAppointment
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
            this.AddAppointmentLabel = new System.Windows.Forms.Label();
            this.CustomerIdLabel = new System.Windows.Forms.Label();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.StartLabel = new System.Windows.Forms.Label();
            this.EndLabel = new System.Windows.Forms.Label();
            this.CustomerIdBox = new System.Windows.Forms.TextBox();
            this.TypeBox = new System.Windows.Forms.TextBox();
            this.AddAppointmentButton = new System.Windows.Forms.Button();
            this.CancelAppointmentButton = new System.Windows.Forms.Button();
            this.StartPicker = new System.Windows.Forms.DateTimePicker();
            this.EndPicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // AddAppointmentLabel
            // 
            this.AddAppointmentLabel.AutoSize = true;
            this.AddAppointmentLabel.Location = new System.Drawing.Point(141, 51);
            this.AddAppointmentLabel.Name = "AddAppointmentLabel";
            this.AddAppointmentLabel.Size = new System.Drawing.Size(176, 13);
            this.AddAppointmentLabel.TabIndex = 0;
            this.AddAppointmentLabel.Text = "Add an appointment to the calendar";
            this.AddAppointmentLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // CustomerIdLabel
            // 
            this.CustomerIdLabel.AutoSize = true;
            this.CustomerIdLabel.Location = new System.Drawing.Point(12, 87);
            this.CustomerIdLabel.Name = "CustomerIdLabel";
            this.CustomerIdLabel.Size = new System.Drawing.Size(63, 13);
            this.CustomerIdLabel.TabIndex = 1;
            this.CustomerIdLabel.Text = "Customer Id";
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Location = new System.Drawing.Point(12, 161);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(31, 13);
            this.TypeLabel.TabIndex = 2;
            this.TypeLabel.Text = "Type";
            // 
            // StartLabel
            // 
            this.StartLabel.AutoSize = true;
            this.StartLabel.Location = new System.Drawing.Point(12, 234);
            this.StartLabel.Name = "StartLabel";
            this.StartLabel.Size = new System.Drawing.Size(102, 13);
            this.StartLabel.TabIndex = 3;
            this.StartLabel.Text = "Start Date and Time";
            // 
            // EndLabel
            // 
            this.EndLabel.AutoSize = true;
            this.EndLabel.Location = new System.Drawing.Point(12, 327);
            this.EndLabel.Name = "EndLabel";
            this.EndLabel.Size = new System.Drawing.Size(99, 13);
            this.EndLabel.TabIndex = 4;
            this.EndLabel.Text = "End Date and Time";
            // 
            // CustomerIdBox
            // 
            this.CustomerIdBox.Location = new System.Drawing.Point(144, 80);
            this.CustomerIdBox.Name = "CustomerIdBox";
            this.CustomerIdBox.Size = new System.Drawing.Size(100, 20);
            this.CustomerIdBox.TabIndex = 5;
            this.CustomerIdBox.TextChanged += new System.EventHandler(this.CustomerIdBox_TextChanged);
            // 
            // TypeBox
            // 
            this.TypeBox.Location = new System.Drawing.Point(144, 154);
            this.TypeBox.Name = "TypeBox";
            this.TypeBox.Size = new System.Drawing.Size(100, 20);
            this.TypeBox.TabIndex = 8;
            this.TypeBox.TextChanged += new System.EventHandler(this.TypeBox_TextChanged);
            // 
            // AddAppointmentButton
            // 
            this.AddAppointmentButton.Location = new System.Drawing.Point(144, 380);
            this.AddAppointmentButton.Name = "AddAppointmentButton";
            this.AddAppointmentButton.Size = new System.Drawing.Size(75, 23);
            this.AddAppointmentButton.TabIndex = 9;
            this.AddAppointmentButton.Text = "Add";
            this.AddAppointmentButton.UseVisualStyleBackColor = true;
            this.AddAppointmentButton.Click += new System.EventHandler(this.AddAppointmentButton_Click);
            // 
            // CancelAppointmentButton
            // 
            this.CancelAppointmentButton.Location = new System.Drawing.Point(242, 380);
            this.CancelAppointmentButton.Name = "CancelAppointmentButton";
            this.CancelAppointmentButton.Size = new System.Drawing.Size(75, 23);
            this.CancelAppointmentButton.TabIndex = 10;
            this.CancelAppointmentButton.Text = "Cancel";
            this.CancelAppointmentButton.UseVisualStyleBackColor = true;
            this.CancelAppointmentButton.Click += new System.EventHandler(this.CancelAppointmentButton_Click);
            // 
            // StartPicker
            // 
            this.StartPicker.CustomFormat = "hh:mm tt MMMM dd, yyyy";
            this.StartPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.StartPicker.Location = new System.Drawing.Point(144, 227);
            this.StartPicker.Name = "StartPicker";
            this.StartPicker.Size = new System.Drawing.Size(200, 20);
            this.StartPicker.TabIndex = 11;
            this.StartPicker.Value = new System.DateTime(2019, 5, 27, 15, 44, 15, 0);
            this.StartPicker.ValueChanged += new System.EventHandler(this.StartPicker_ValueChanged);
            // 
            // EndPicker
            // 
            this.EndPicker.CustomFormat = "hh:mm tt MMMM dd, yyyy";
            this.EndPicker.Location = new System.Drawing.Point(144, 320);
            this.EndPicker.Name = "EndPicker";
            this.EndPicker.Size = new System.Drawing.Size(200, 20);
            this.EndPicker.TabIndex = 12;
            this.EndPicker.Value = new System.DateTime(2019, 5, 27, 15, 49, 7, 0);
            this.EndPicker.ValueChanged += new System.EventHandler(this.EndPicker_ValueChanged);
            // 
            // AddAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 461);
            this.Controls.Add(this.EndPicker);
            this.Controls.Add(this.StartPicker);
            this.Controls.Add(this.CancelAppointmentButton);
            this.Controls.Add(this.AddAppointmentButton);
            this.Controls.Add(this.TypeBox);
            this.Controls.Add(this.CustomerIdBox);
            this.Controls.Add(this.EndLabel);
            this.Controls.Add(this.StartLabel);
            this.Controls.Add(this.TypeLabel);
            this.Controls.Add(this.CustomerIdLabel);
            this.Controls.Add(this.AddAppointmentLabel);
            this.Name = "AddAppointment";
            this.Text = "Add Appointment";
            this.Load += new System.EventHandler(this.AddAppointment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AddAppointmentLabel;
        private System.Windows.Forms.Label CustomerIdLabel;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.Label StartLabel;
        private System.Windows.Forms.Label EndLabel;
        private System.Windows.Forms.TextBox CustomerIdBox;
        private System.Windows.Forms.TextBox TypeBox;
        private System.Windows.Forms.Button AddAppointmentButton;
        private System.Windows.Forms.Button CancelAppointmentButton;
        private System.Windows.Forms.DateTimePicker startTimePicker;
        private System.Windows.Forms.DateTimePicker endTimePicker;
        private System.Windows.Forms.DateTimePicker StartPicker;
        private System.Windows.Forms.DateTimePicker EndPicker;
    }
}

