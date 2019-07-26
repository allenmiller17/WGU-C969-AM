using System;
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
    public partial class DeleteAppointment : Form
    {
        public MainScreen mainScreen;

        public DeleteAppointment()
        {
            InitializeComponent();
        }

        public static Dictionary<string, string> apptDetails = new Dictionary<string, string>();

        public static bool removeAppointment ()
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

        private void DeleteAppointment_Load(object sender, EventArgs e)
        {

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string appointmentId = SearchBox.Text;
            apptDetails = Data.getAppointmentDetails(appointmentId);
            TypeBox.Text = apptDetails["type"];
            CustomerIdBox.Text = apptDetails["customerId"];
            StartBox.Text = apptDetails["start"];
            EndBox.Text = apptDetails["end"];
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            //Confirm Delete
            DialogResult confirmRemove = MessageBox.Show("Removing appointment cannot be undone. Confirm?", "Confirm", MessageBoxButtons.YesNo);
            if (confirmRemove == DialogResult.Yes)
            {
                if (removeAppointment())
                {
                    mainScreen.calendarUpdate();
                    MessageBox.Show("Customer appointment successfully removed.");
                }
                else
                {
                    MessageBox.Show("Could not remove appointment, please try again.");
                }
            }
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
