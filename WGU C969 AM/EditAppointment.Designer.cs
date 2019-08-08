namespace WGU_C969_AM
{
    partial class EditAppointment
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
            this.EditLabel = new System.Windows.Forms.Label();
            this.CustNameLbl = new System.Windows.Forms.Label();
            this.CustomerIdLabel = new System.Windows.Forms.Label();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.StartLabel = new System.Windows.Forms.Label();
            this.EndLabel = new System.Windows.Forms.Label();
            this.TypeBox = new System.Windows.Forms.TextBox();
            this.CustomerIdBox = new System.Windows.Forms.TextBox();
            this.EndPicker = new System.Windows.Forms.DateTimePicker();
            this.StartPicker = new System.Windows.Forms.DateTimePicker();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.ApptIdLbl = new System.Windows.Forms.Label();
            this.ApptBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // EditLabel
            // 
            this.EditLabel.AutoSize = true;
            this.EditLabel.Location = new System.Drawing.Point(150, 18);
            this.EditLabel.Name = "EditLabel";
            this.EditLabel.Size = new System.Drawing.Size(87, 13);
            this.EditLabel.TabIndex = 0;
            this.EditLabel.Text = "Edit Appointment";
            // 
            // CustNameLbl
            // 
            this.CustNameLbl.AutoSize = true;
            this.CustNameLbl.Location = new System.Drawing.Point(12, 70);
            this.CustNameLbl.Name = "CustNameLbl";
            this.CustNameLbl.Size = new System.Drawing.Size(82, 13);
            this.CustNameLbl.TabIndex = 1;
            this.CustNameLbl.Text = "Customer Name";
            // 
            // CustomerIdLabel
            // 
            this.CustomerIdLabel.AutoSize = true;
            this.CustomerIdLabel.Location = new System.Drawing.Point(12, 119);
            this.CustomerIdLabel.Name = "CustomerIdLabel";
            this.CustomerIdLabel.Size = new System.Drawing.Size(63, 13);
            this.CustomerIdLabel.TabIndex = 2;
            this.CustomerIdLabel.Text = "Customer Id";
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Location = new System.Drawing.Point(12, 225);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(31, 13);
            this.TypeLabel.TabIndex = 3;
            this.TypeLabel.Text = "Type";
            // 
            // StartLabel
            // 
            this.StartLabel.AutoSize = true;
            this.StartLabel.Location = new System.Drawing.Point(12, 274);
            this.StartLabel.Name = "StartLabel";
            this.StartLabel.Size = new System.Drawing.Size(55, 13);
            this.StartLabel.TabIndex = 4;
            this.StartLabel.Text = "Start Time";
            // 
            // EndLabel
            // 
            this.EndLabel.AutoSize = true;
            this.EndLabel.Location = new System.Drawing.Point(12, 335);
            this.EndLabel.Name = "EndLabel";
            this.EndLabel.Size = new System.Drawing.Size(52, 13);
            this.EndLabel.TabIndex = 5;
            this.EndLabel.Text = "End Time";
            // 
            // TypeBox
            // 
            this.TypeBox.Location = new System.Drawing.Point(147, 218);
            this.TypeBox.Name = "TypeBox";
            this.TypeBox.Size = new System.Drawing.Size(100, 20);
            this.TypeBox.TabIndex = 4;
            // 
            // CustomerIdBox
            // 
            this.CustomerIdBox.Location = new System.Drawing.Point(147, 112);
            this.CustomerIdBox.Name = "CustomerIdBox";
            this.CustomerIdBox.ReadOnly = true;
            this.CustomerIdBox.Size = new System.Drawing.Size(100, 20);
            this.CustomerIdBox.TabIndex = 3;
            this.CustomerIdBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // EndPicker
            // 
            this.EndPicker.CustomFormat = "hh:mm tt MMMM dd, yyyy";
            this.EndPicker.Location = new System.Drawing.Point(147, 329);
            this.EndPicker.MinDate = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.EndPicker.Name = "EndPicker";
            this.EndPicker.Size = new System.Drawing.Size(200, 20);
            this.EndPicker.TabIndex = 6;
            this.EndPicker.Value = new System.DateTime(2019, 7, 25, 20, 9, 48, 0);
            this.EndPicker.ValueChanged += new System.EventHandler(this.EndPicker_ValueChanged);
            // 
            // StartPicker
            // 
            this.StartPicker.CustomFormat = "hh:mm tt MMMM dd, yyyy";
            this.StartPicker.Location = new System.Drawing.Point(147, 268);
            this.StartPicker.MinDate = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.StartPicker.Name = "StartPicker";
            this.StartPicker.Size = new System.Drawing.Size(200, 20);
            this.StartPicker.TabIndex = 5;
            this.StartPicker.Value = new System.DateTime(2019, 7, 25, 12, 0, 0, 0);
            this.StartPicker.ValueChanged += new System.EventHandler(this.StartPicker_ValueChanged);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(253, 389);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 8;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(147, 389);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 7;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(147, 63);
            this.NameBox.Name = "NameBox";
            this.NameBox.ReadOnly = true;
            this.NameBox.Size = new System.Drawing.Size(100, 20);
            this.NameBox.TabIndex = 1;
            this.NameBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
            // 
            // ApptIdLbl
            // 
            this.ApptIdLbl.AutoSize = true;
            this.ApptIdLbl.Location = new System.Drawing.Point(12, 168);
            this.ApptIdLbl.Name = "ApptIdLbl";
            this.ApptIdLbl.Size = new System.Drawing.Size(78, 13);
            this.ApptIdLbl.TabIndex = 9;
            this.ApptIdLbl.Text = "Appointment Id";
            // 
            // ApptBox
            // 
            this.ApptBox.Location = new System.Drawing.Point(147, 161);
            this.ApptBox.Name = "ApptBox";
            this.ApptBox.ReadOnly = true;
            this.ApptBox.Size = new System.Drawing.Size(100, 20);
            this.ApptBox.TabIndex = 10;
            // 
            // EditAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 461);
            this.Controls.Add(this.ApptBox);
            this.Controls.Add(this.ApptIdLbl);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.StartPicker);
            this.Controls.Add(this.EndPicker);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.CustomerIdBox);
            this.Controls.Add(this.TypeBox);
            this.Controls.Add(this.EndLabel);
            this.Controls.Add(this.StartLabel);
            this.Controls.Add(this.TypeLabel);
            this.Controls.Add(this.CustomerIdLabel);
            this.Controls.Add(this.CustNameLbl);
            this.Controls.Add(this.EditLabel);
            this.Name = "EditAppointment";
            this.Text = "Edit Appointment";
            this.Load += new System.EventHandler(this.EditAppointment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EditLabel;
        private System.Windows.Forms.Label CustNameLbl;
        private System.Windows.Forms.Label CustomerIdLabel;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.Label StartLabel;
        private System.Windows.Forms.Label EndLabel;
        private System.Windows.Forms.TextBox TypeBox;
        private System.Windows.Forms.TextBox CustomerIdBox;
        private System.Windows.Forms.DateTimePicker EndPicker;
        private System.Windows.Forms.DateTimePicker StartPicker;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label ApptIdLbl;
        private System.Windows.Forms.TextBox ApptBox;
    }
}