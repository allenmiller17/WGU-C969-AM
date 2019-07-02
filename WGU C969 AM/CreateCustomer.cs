using System;
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
    public partial class CreateCustomer : Form
    {
        public CreateCustomer()
        {
            InitializeComponent();
        }

        private void CreateCustomer_Load(object sender, EventArgs e)
        {
            CountryBox.Items.Add("Canada");
            CountryBox.Items.Add("Mexico");
            CountryBox.Items.Add("United States of America");
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            string timeStamp = Data.createTimestamp();
            string username = Data.getCurrentUserName();

            if (string.IsNullOrEmpty(NameBox.Text) ||
                string.IsNullOrEmpty(PhoneBox.Text) ||
                string.IsNullOrEmpty(AddressBox.Text) ||
                string.IsNullOrEmpty(CityBox.Text) ||
                string.IsNullOrEmpty(ZipBox.Text) ||
                string.IsNullOrEmpty(CountryBox.Text) ||
                (ActiveYesRadio.Checked == false &&
                ActiveNoRadio.Checked == false))
            {
                MessageBox.Show("All fields must be completed before creating a new record.");
            }

            else
            {
                int countryId = Data.createRecord(timeStamp, username, "country", $"'{CountryBox.Text}'");
                int cityId = Data.createRecord(timeStamp, username, "city", $"'{CityBox.Text}', '{countryId}'");
                int addressId = Data.createRecord(timeStamp, username, "address", $"'{AddressBox.Text}', '', '{cityId}', '{ZipBox.Text}', '{PhoneBox.Text}'");
                Data.createRecord(timeStamp, username, "customer", $"'{NameBox.Text}', '{addressId}', '{(ActiveYesRadio.Checked ? 1 : 0)}'");

                Close();
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CountryBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
