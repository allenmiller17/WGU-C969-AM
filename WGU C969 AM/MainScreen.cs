using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WGU_C969_AM
{
    public partial class MainScreen : Form
    {

        public Login login;

        public MainScreen()
        {
            InitializeComponent();
            CalendarDGV.DataSource = getCalendar(WeekRadio.Checked);
            reminder(CalendarDGV);
        }

        public static string SetApptId = "";

        public static string SetCustName = "";

        bool buttonWasClicked = false;

        private void MainScreen_Load(object sender, EventArgs e)
        {

        }

        public static void reminder(DataGridView calendar)
        {
            foreach (DataGridViewRow row in calendar.Rows)
            {
                DateTime now = DateTime.UtcNow;
                DateTime start = DateTime.Parse(row.Cells[2].Value.ToString()).ToUniversalTime();
                TimeSpan toStartOfAppointment = now - start;
                if (toStartOfAppointment.TotalMinutes >= 15 && toStartOfAppointment.TotalMinutes < 1)
                {
                    MessageBox.Show($"Reminder: You have a meeting with {row.Cells[4].Value} at {row.Cells[2].Value}");
                }
            }
        }

        public static Array getCalendar(bool weekView)
        {

            MySqlConnection n = new MySqlConnection(Data.conString);
            n.Open();

            // Queries the DataBase for all the appointments associated with the logged in user
            string query = $"SELECT customerId, type, start, end, appointmentId, userId FROM appointment WHERE userid = '{Data.getUserId()}'";
            MySqlCommand c = new MySqlCommand(query, n);
            MySqlDataReader r = c.ExecuteReader();

            Dictionary<int, Hashtable> appointments = new Dictionary<int, Hashtable>();

            // Creates a dictionary of all the appointments
            while (r.Read())
            {

                Hashtable appointment = new Hashtable();
                appointment.Add("customerId", r[0]);
                appointment.Add("type", r[1]);
                appointment.Add("start", r[2]);
                appointment.Add("end", r[3]);
                appointment.Add("userId", r[5]);

                appointments.Add(Convert.ToInt32(r[4]), appointment);

            }
            r.Close();

            // Assigns the proper Username to each Appointment dictionary
            foreach (var app in appointments.Values)
            {
                query = $"SELECT userName FROM user WHERE userId = '{app["userId"]}'";
                c = new MySqlCommand(query, n);
                r = c.ExecuteReader();
                r.Read();
                app.Add("userName", r[0]);
                r.Close();
            }

            // Assigns the proper CustomerName to each Appointment dictionary
            foreach (var app in appointments.Values)
            {
                query = $"SELECT customerName FROM customer WHERE customerId = '{app["customerId"]}'";
                c = new MySqlCommand(query, n);
                r = c.ExecuteReader();
                r.Read();
                app.Add("customerName", r[0]);
                r.Close();
            }

            Dictionary<int, Hashtable> parsedAppointments = new Dictionary<int, Hashtable>();

            // Adjusts appointments that will end up in calendar based on if the Week or Month view is chosen.
            foreach (var app in appointments)
            {
                DateTime startTime = DateTime.Parse(app.Value["start"].ToString());
                DateTime endTime = DateTime.Parse(app.Value["end"].ToString());
                DateTime today = DateTime.UtcNow;

                if (weekView == true)
                {
                    DateTime sunday = today.AddDays(-(int)today.DayOfWeek);
                    DateTime saturday = today.AddDays(-(int)today.DayOfWeek + (int)DayOfWeek.Saturday);

                    if (startTime >= sunday && endTime <= saturday)
                    {
                        // only include the appointments that get here
                        parsedAppointments.Add(app.Key, app.Value);
                    }
                }
                else
                {
                    DateTime firstDayOfMonth = new DateTime(today.Year, today.Month, 1);
                    DateTime lastDayOfMonth = new DateTime(today.Year,
                                   today.Month,
                                   DateTime.DaysInMonth(today.Year,
                                                        today.Month)); ;
                    if (startTime >= firstDayOfMonth && endTime <= lastDayOfMonth)
                    {
                        //  only include appointments that get here
                        parsedAppointments.Add(app.Key, app.Value);
                    }
                }
            }

            Data.setAppointments(appointments);
            // Forms final datasource of calendar that will be shown to user
            var appointmentArray = from row in parsedAppointments
                                   select new
                                   {
                                       ID = row.Key,
                                       Type = row.Value["type"],
                                       StartTime = Data.convertToTimezone(row.Value["start"].ToString()),
                                       EndTime = Data.convertToTimezone(row.Value["end"].ToString()),
                                       Customer = row.Value["customerName"]
                                   };

            n.Close();

            return appointmentArray.ToArray();
        }

        public void calendarUpdate()
        {
            bool weekView = true;

            if (WeekRadio.Checked)
            {
                CalendarDGV.DataSource = getCalendar(weekView);
            }
            else
            {
                weekView = false;
                CalendarDGV.DataSource = getCalendar(weekView);
            }
        }
        
        private void AddCustButton_Click(object sender, EventArgs e)
        {
            CreateCustomer createCustomer = new CreateCustomer();
            createCustomer.Show();
        }

        private void EditCustButton_Click(object sender, EventArgs e)
        {
            EditCustomer editCustomer = new EditCustomer();
            editCustomer.Show();
        }

        private void DeleteCustButton_Click(object sender, EventArgs e)
        {
            DeleteCustomer deleteCustomer = new DeleteCustomer();
            deleteCustomer.Show();
        }

        private void MainScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            login.Close();
        }

        private void AppointmentButton_Click(object sender, EventArgs e)
        {
            AppointmentCount appointmentCount = new AppointmentCount();
            appointmentCount.Show();
        }

        private void SchedulesButton_Click(object sender, EventArgs e)
        {
            Schedules schedules = new Schedules();
            schedules.Show();
        }

        private void ReportButton_Click(object sender, EventArgs e)
        {
            CustomerReport customerReport = new CustomerReport();
            customerReport.Show();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddAppointment addAppointment = new AddAppointment();
            addAppointment.mainScreen = this;
            addAppointment.Show();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            buttonWasClicked= true;
            if (buttonWasClicked == true)
            {
                int rowIndex = CalendarDGV.CurrentCell.RowIndex;

                SetApptId = CalendarDGV.Rows[rowIndex].Cells[0].Value.ToString();

                SetCustName = CalendarDGV.Rows[rowIndex].Cells[4].Value.ToString();


            }

            EditAppointment editAppointment = new EditAppointment();
            editAppointment.mainScreen = this;
            editAppointment.Show();
        }

        public static Dictionary<string, string> apptDetails = new Dictionary<string, string>();
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            buttonWasClicked = true;
            if (buttonWasClicked == true)
            {
                if (MessageBox.Show("Are you sure you want to delete this customer?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int rowIndex = CalendarDGV.CurrentCell.RowIndex;

                    string appointmentId = CalendarDGV.Rows[rowIndex].Cells[0].Value.ToString();
                    apptDetails = Data.getAppointmentDetails(appointmentId);

                    removeAppointment();
                    calendarUpdate();
                }
            }
        }

        public static bool removeAppointment()
        {
            MySqlConnection con = new MySqlConnection(Data.conString);
            con.Open();

            //Removes Appointment Tied to Customer
            string remove = $"DELETE FROM appointment" +
                            $" WHERE appointmentId = '{apptDetails["appointmentId"]}'";

            MySqlCommand cmd = new MySqlCommand(remove, con);
            int appointmentRemoved = cmd.ExecuteNonQuery();

            con.Close();

            if (appointmentRemoved != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void WeekRadio_CheckedChanged(object sender, EventArgs e)
        {
            calendarUpdate();
        }

        private void MonthRadio_CheckedChanged(object sender, EventArgs e)
        {
            calendarUpdate();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
