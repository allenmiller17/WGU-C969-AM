using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace WGU_C969_AM
{
    public partial class Schedules : Form
    {
        public struct UserReport
        {
            public int userID;
            public string userName;
            public string type;
            public string start;
            public string end;
            public string customerName;
        }

        public Schedules()
        {
            InitializeComponent();
            SchedulesDGV.DataSource = generateReport();
        }

        private void Schedules_Load(object sender, EventArgs e)
        {

        }

        public static Array generateReport()
        {
            Dictionary<int, Hashtable> Report = Data.getAppointments();

            var apptArray = from row in Report
                            select new
                            {
                                UserName = row.Value["userName"],
                                Type = row.Value["type"],
                                Start = Data.convertToTimezone(row.Value["start"].ToString()),
                                End = Data.convertToTimezone(row.Value["end"].ToString()),
                                Customer = row.Value["customer"]
                            };
            return apptArray.ToArray();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void SchedulesDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SchedulesDGV.AutoResizeColumns();
            SchedulesDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
    }
}
