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
using System.Globalization;

namespace WGU_C969_AM
{
    public partial class Login : Form
    {
        public string ErrorMessage = "Username and password do not match";

        public Login()
        {
            InitializeComponent();

            LanguageCheck();
        }

        static public int LookUpUser(string userName, string password)
        {
            MySqlConnection u = new MySqlConnection(Data.conString);
            u.Open();
            MySqlCommand c = new MySqlCommand($"SELECT * FROM user WHERE userName = '{userName}' AND password = '{password}'", u);
            MySqlDataReader d = c.ExecuteReader();

            if (d.HasRows)
            {
                d.Read();
                Data.setUserId(Convert.ToInt32(d[0]));
                Data.setCurrentUserName(userName);
                d.Close();
                u.Close();
                return Data.getUserId();
            }
            return 0;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        //Checks to see if the devices language is set to American English. If not translates to Spanish.
        public void LanguageCheck()
        {


            CultureInfo culture = CultureInfo.CurrentCulture;
            CultureInfo main = new CultureInfo("en-US");
            CultureInfo sp = new CultureInfo("es-ES");

            if (culture.EnglishName != main.EnglishName)
            {
                LoginLabel.Text = "Por favor Iniciar sesión";
                UsernameLabel.Text = "Nombre de usuario";
                PasswordLabel.Text = "Contraseña";
                LoginButton.Text = "Iniciar sesión";
                ExitButton.Text = "Salida";
                ErrorMessage = "El nombre de usuario y la contraseña no coinciden";
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (LookUpUser(UsernameBox.Text, PasswordBox.Text) !=0)
            {
                this.Hide();
                MainScreen mainScreen = new MainScreen();
                //mainScreen.loginForm = this;
                Log.userLoginLog(Data.getUserId());
                mainScreen.Show();
            }
            else
            {
                MessageBox.Show(ErrorMessage);
                PasswordBox.Text = "";
            }
        }
    }
}
