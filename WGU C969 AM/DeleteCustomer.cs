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
    public partial class DeleteCustomer : Form
    {
        public DeleteCustomer()
        {
            InitializeComponent();
        }

        private void DeleteCustomer_Load(object sender, EventArgs e)
        {

        }

        public static Dictionary<string, string> custInfo = new Dictionary<string, string>();

        public bool deleteCustomer()
        {
            MySqlConnection c = new MySqlConnection(Data.conString);
            c.Open();

            #region Delete Customer
            //Delete Cust
            string recordUpdate =   $"DELETE FROM customer" +
                                    $" WHERE customerName = '{custInfo["customerName"]}'";
            MySqlCommand cmd = new MySqlCommand(recordUpdate, c);
            int cust = cmd.ExecuteNonQuery();
            #endregion

            #region Delete Address
            //Delete Address
            recordUpdate = $"DELETE FROM address" +
                           $" WHERE address = '{custInfo["address"]}'";
            cmd = new MySqlCommand(recordUpdate, c);
            int address = cmd.ExecuteNonQuery();
            #endregion

            #region Delete City
            //Delete City
            recordUpdate = $"DELETE FROM city" +
                           $" WHERE city = '{custInfo["city"]}'";
            cmd = new MySqlCommand(recordUpdate, c);
            int city = cmd.ExecuteNonQuery();
            #endregion

            #region Delete Country
            //Delete Country
            recordUpdate = $"DELETE FROM country" +
                           $" WHERE country = '{custInfo["country"]}'";
            cmd = new MySqlCommand(recordUpdate, c);
            int country = cmd.ExecuteNonQuery();
            #endregion

            c.Close();

            if (cust != 0 && address != 0 && city != 0 && country != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            int customerId = Data.findCustomer(SearchBox.Text);

            if (customerId != 0)
            {
                custInfo = Data.getCustomerDetails(customerId);
                NameBox.Text = custInfo["customerName"];
                PhoneBox.Text = custInfo["phone"];
                AddressBox.Text = custInfo["address"];
                CityBox.Text = custInfo["city"];
                ZipBox.Text = custInfo["zip"];
                CountryBox.Text = custInfo["country"];

                if (custInfo["active"] == "True")
                {
                    ActiveBox.Text = "True";
                }
                else
                {
                    ActiveBox.Text = "False"; ;
                }
            }
            else
            {
                MessageBox.Show("Could not locate customer. Please check name and try again.");

            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Deleting customer cannot be undone", "Contine?", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                if (deleteCustomer())
                {
                    MessageBox.Show("Customer was successfully deleted.");
                }
                else
                {
                    MessageBox.Show("Customer could not be deleted.");
                }
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
