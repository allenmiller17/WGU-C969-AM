﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WGU_C969_AM
{
    public partial class AddAppointment : Form
    {
        public MainScreen mainScreen;

        public AddAppointment()
        {
            InitializeComponent();
            EndPicker.Value = EndPicker.Value.AddHours(1);
        }

        public static bool ConflictingAppointment(DateTime start, DateTime end)
        {
            foreach (var appointment in Data.getAppointments().Values)
            {
                if (start < DateTime.Parse(appointment["end"].ToString()) && DateTime.Parse(appointment["start"].ToString()) < end)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool outsideOfBusinessHours(DateTime startTime, DateTime endTime)
        {
            startTime = startTime.ToLocalTime();
            endTime = endTime.ToLocalTime();

            //Business Hours 9:00 am to 5:00 pm
            DateTime businessStartTime = DateTime.Today.AddHours(9);
            DateTime businessEndTime = DateTime.Today.AddHours(17);
            if (startTime.TimeOfDay >= businessStartTime.TimeOfDay && startTime.TimeOfDay < businessEndTime.TimeOfDay &&
                endTime.TimeOfDay > businessStartTime.TimeOfDay && endTime.TimeOfDay <= businessEndTime.TimeOfDay)
            {
                return false;
            }

            return true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddAppointment_Load(object sender, EventArgs e)
        {

        }

        private void CustomerIdBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void TypeBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddAppointmentButton_Click(object sender, EventArgs e)
        {
            string timeStamp = Data.createTimestamp();
            int userId = Data.getCurrentUserId();
            string username = Data.getCurrentUserName();

            DateTime startTime = StartPicker.Value.ToUniversalTime();
            DateTime endTime = EndPicker.Value.ToUniversalTime();

            try
            {
                if (ConflictingAppointment(startTime, endTime))
                {
                    //throw new appointmentException();
                }
                else
                {
                    try
                    {
                        if (outsideOfBusinessHours (startTime, endTime))
                        {
                            throw new appointmentException();
                        }
                        else
                        {
                            Data.createRecord(timeStamp, username, "appointment", $"'{CustomerIdBox.Text}', '{StartPicker.Value.ToUniversalTime().ToString("u")}'," +
                                $"'{EndPicker.Value.ToUniversalTime().ToString("u")}', '{TypeBox.Text}'", userId);
                        }
                    }
                    catch (appointmentException ex)
                    {

                        ex.outsideOfBusinessHours();
                    }
                }
            }
            catch (appointmentException ex)
            {

                ex.appointmentOverlap();
            }
        }

        private void CancelAppointmentButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StartPicker_ValueChanged(object sender, EventArgs e)
        {
            StartPicker.Format = DateTimePickerFormat.Custom;
            StartPicker.CustomFormat = "hh:mm MMMM dd, yyyy";
        }

        private void EndPicker_ValueChanged(object sender, EventArgs e)
        {
            EndPicker.Format = DateTimePickerFormat.Custom;
            EndPicker.CustomFormat = "hh:mm MMMM dd, yyyy";
        }
    }
}