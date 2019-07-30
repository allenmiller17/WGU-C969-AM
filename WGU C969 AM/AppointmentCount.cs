using System;
using System.Collections;
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
    public struct AppointmentReport
    {
        public string month;
        public string appointmentType;
        public int count;
    }
    public partial class AppointmentCount : Form
    {
        public AppointmentCount()
        {
            InitializeComponent();
            CountDGV.DataSource = getReport();
        }

        public static Array getReport()
        {
            List<AppointmentReport> appointmentReports = new List<AppointmentReport>();
            List<Hashtable> appointmentTypes = new List<Hashtable>();
            SortedList months = new SortedList();

            months.Add(1, "January");
            months.Add(2, "February");
            months.Add(3, "March");
            months.Add(4, "April");
            months.Add(5, "May");
            months.Add(6, "June");
            months.Add(7, "July");
            months.Add(8, "August");
            months.Add(9, "September");
            months.Add(10, "October");
            months.Add(11, "November");
            months.Add(12, "December");

            foreach (var appointment in Data.getAppointments().Values)
            {
                int appointmentMonth = DateTime.Parse(appointment["start"].ToString()).Month;

                bool dup = false;
                foreach (AppointmentReport app in appointmentReports)
                {
                    if (app.month == months[appointmentMonth].ToString() && app.appointmentType == appointment["type"].ToString())
                    {
                        dup = true;
                    }
                }

                if (!dup)
                {
                    AppointmentReport appointmentReport = new AppointmentReport();
                    appointmentReport.month = months[appointmentMonth].ToString();
                    appointmentReport.appointmentType = appointment["type"].ToString();

                    //Lambda used to help with counting
                    appointmentReport.count = Data.getAppointments().
                        Where(a => a.Value["type"].ToString() ==
                        appointment["type"].ToString() &&
                        DateTime.Parse(a.Value["start"].ToString()).
                        Month == appointmentMonth).Count();

                    appointmentReports.Add(appointmentReport);
                }
            }

            var arrayOfAppointments = from row in appointmentReports select new { Month = row.month, Type = row.appointmentType, Count = row.count };

            return arrayOfAppointments.ToArray();
        }
        private void CountDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AppointmentCount_Load(object sender, EventArgs e)
        {

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
