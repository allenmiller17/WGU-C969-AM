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
    public partial class EditCustomer : Form
    {
        public EditCustomer()
        {
            InitializeComponent();
        }
        private void EditCustomer_Load(object sender, EventArgs e)
        {
            CountryBox.Items.Add("Canada");
            CountryBox.Items.Add("Mexico");
            CountryBox.Items.Add("United States of America");
        }

        public static Dictionary<string, string> custForm = new Dictionary<string, string>();

        public bool editCustomer(Dictionary<string,string>editedForm)
        {
            MySqlConnection con = new MySqlConnection(Data.conString);
            con.Open();

            #region Edit Customer
            //Edits Customer Table
            string newEdit =    $"UPDATE customer" +
                                $" SET customerName = '{editedForm["customerName"]}', active = '{editedForm["active"]}', lastUpdate = '{Data.createTimestamp()}'," +
                                $"lastUpdateBy = '{Data.getCurrentUserName()}'" +
                                $" WHERE customerName = '{custForm["customerName"]}'";
            MySqlCommand cmd = new MySqlCommand(newEdit, con);
            int customerEdited = cmd.ExecuteNonQuery();
            #endregion

            #region Edit Address
            //Edits Address Table
            newEdit =           $"UPDATE address" +
                                $" SET address = '{editedForm["address"]}', postalCode = '{editedForm["zip"]}', phone = '{editedForm["phone"]}'," +
                                $" lastUpdate = '{Data.createTimestamp()}', lastUpdateBy = '{Data.getCurrentUserName()}'" +
                                $" WHERE address = '{custForm["address"]}'";
            cmd = new MySqlCommand(newEdit, con);
            int addressEdited = cmd.ExecuteNonQuery();
            #endregion

            #region Edit City
            newEdit = $"UPDATE city" +
                    $" SET city = '{editedForm["city"]}'" +
                    $" lastUpdate = '{Data.createTimestamp()}', lastUpdateBy = '{Data.getCurrentUserName()}'" +
                    $" WHERE city = '{custForm["city"]}'"; ;
            cmd = new MySqlCommand(newEdit, con);
            int cityEdited = cmd.ExecuteNonQuery();
            #endregion

            #region Edit Country
            newEdit = $"UPDATE country" +
                    $" SET country = '{editedForm["country"]}'" +
                    $" lastUpdate = '{Data.createTimestamp()}', lastUpdateBy = '{Data.getCurrentUserName()}'" +
                    $" WHERE country = '{custForm["country"]}'";
            cmd = new MySqlCommand(newEdit, con);
            int countryEdited = cmd.ExecuteNonQuery();
            #endregion

            con.Close();

            if (customerEdited != 0 && addressEdited != 0 && cityEdited != 0 && countryEdited != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void SearchButton_Click(object sender, EventArgs e)
        {
            int customerId = Data.findCustomer(SearchBox.Text);

            if (customerId != 0)
            {
                custForm = Data.getCustomerDetails(customerId);
                Namebox.Text = custForm["customerName"];
                PhoneBox.Text = custForm["phone"];
                AddressBox.Text = custForm["address"];
                CityBox.Text = custForm["city"];
                ZipBox.Text = custForm["zip"];
                CountryBox.Text = custForm["country"];

                if (custForm["active"] == "True")
                {
                    YesRadio.Checked = true;
                }
                else
                {
                    YesRadio.Checked = false;
                }
            }
            else
            {
                MessageBox.Show("Could not locate customer. Please check name and try again.");

            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> editedForm = new Dictionary<string, string>();
            editedForm.Add("customerName", Namebox.Text);
            editedForm.Add("phone", PhoneBox.Text);
            editedForm.Add("address", AddressBox.Text);
            editedForm.Add("city", CityBox.Text);
            editedForm.Add("zip", ZipBox.Text);
            editedForm.Add("country", CountryBox.Text);
            editedForm.Add("active", YesRadio.Checked ? "1" : "0");

            if (editCustomer(editedForm))
            {
                MessageBox.Show("Success!");
            }
            else
            {
                MessageBox.Show("Could not complete edit. Please try again.");
            }
        }
    }
}
