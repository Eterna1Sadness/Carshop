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

namespace TRPO_carshop
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            string userLogin = loginField.Text;
            string userPass = passField.Text;

            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("select * from users where login = @uL and password = @uP", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = userLogin;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = userPass;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                this.Hide();
                MainForm main = new MainForm();
                main.Show();
            }
            else
                MessageBox.Show("Неправильный логин или пароль!");
        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration registration = new Registration();
            registration.Show();
        }

        private void RegistrationButton_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Registration registration = new Registration();
            registration.Show();
        }
    }
}
