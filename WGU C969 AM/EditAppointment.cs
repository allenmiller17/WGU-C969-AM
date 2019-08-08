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
    public partial class EditAppointment : Form
    {
        public MainScreen mainScreen;

        public EditAppointment()
        {
            InitializeComponent();
            openForm();
        }

        public static Dictionary<string, string> form = new Dictionary<string, string>();

        public static bool editAppointment(Dictionary<string, string> editedForm)
        {
            MySqlConnection con = new MySqlConnection(Data.conString);
            con.Open();

            //Update Customer Table
            string editRecord = $"UPDATE appointment" +
                                $" SET customerId = '{editedForm["customerId"]}', start = '{editedForm["start"]}', end = '{editedForm["end"]}'," +
                                $" type = '{editedForm["type"]}', lastUpdate = '{Data.createTimestamp()}', lastUpdateBy = '{Data.getUserName()}'" +
                                $" WHERE appointmentId = '{form["appointmentId"]}'";

            MySqlCommand cmd = new MySqlCommand(editRecord, con);
            int editedAppointment = cmd.ExecuteNonQuery();

            if (editedAppointment != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditAppointment_Load(object sender, EventArgs e)
        {

        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void openForm()
        {


            string appointmentId = MainScreen.SetApptId;

            form = Data.getAppointmentDetails(appointmentId);

            NameBox.Text = MainScreen.SetCustName;
            CustomerIdBox.Text = form["customerId"];
            ApptBox.Text = appointmentId;
            TypeBox.Text = form["type"];
            StartPicker.Value = DateTime.Parse(Data.convertToTimezone(form["start"]));
            EndPicker.Value = DateTime.Parse(Data.convertToTimezone(form["end"]));
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> form = new Dictionary<string, string>();

            form.Add("type", TypeBox.Text);
            form.Add("customerId", CustomerIdBox.Text);
            form.Add("start", StartPicker.Value.ToUniversalTime().ToString("u"));
            form.Add("end", EndPicker.Value.ToUniversalTime().ToString("u"));

            if (editAppointment(form))
            {
                mainScreen.calendarUpdate();
                MessageBox.Show("Update Successful");
            }
            else
            {
                MessageBox.Show("Could not update appointment.");
            }

            this.Close();
        }

        private void StartPicker_ValueChanged(object sender, EventArgs e)
        {
            StartPicker.Format = DateTimePickerFormat.Custom;
            StartPicker.CustomFormat = "hh:mm tt MMMM dd, yyyy";
        }

        private void EndPicker_ValueChanged(object sender, EventArgs e)
        {
            EndPicker.Format = DateTimePickerFormat.Custom;
            EndPicker.CustomFormat = "hh:mm tt MMMM dd, yyyy";
        }
    }
}
