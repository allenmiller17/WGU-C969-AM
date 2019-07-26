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
using MySql.Data.MySqlClient;

namespace WGU_C969_AM
{
    public struct Customer
    {
        public string customerName;
        public int apptCount;
    }

    public partial class CustomerReport : Form
    {
        public CustomerReport()
        {
            InitializeComponent();
            ReportDGV.DataSource = generateReport();
        }

        private void CustomerReport_Load(object sender, EventArgs e)
        {

        }

        public static DataTable generateReport()
        {
            //Display appointment count by customer
            Dictionary<int, Hashtable> appointments = Data.getAppointments();

            DataTable dataTable = new DataTable();
            dataTable.Clear();
            dataTable.Columns.Add("Customer");
            dataTable.Columns.Add("Appointments");

            //Lambda used to distinctly select customer from list of appointments
            IEnumerable<string> cust = appointments.Select(i => i.Value["customerName"].ToString()).Distinct();

            //Lambda used to give count of customer appointments
            foreach (string customer in cust)
            {
                DataRow row = dataTable.NewRow();
                row["Customer"] = customer;
                row["Appointments"] = appointments.Where(i => i.Value["customerName"].ToString() == customer.ToString()).Count().ToString();
                dataTable.Rows.Add(row);
            }

            return dataTable;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddAppointment addAppointment = new AddAppointment();
            addAppointment.Show();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            EditAppointment editAppointment = new EditAppointment();
            editAppointment.Show();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DeleteAppointment deleteAppointment = new DeleteAppointment();
            deleteAppointment.Show();
        }
    }
}
