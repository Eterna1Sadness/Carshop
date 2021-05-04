using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRPO_carshop
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            userNameField.Text = "Введите имя";
            userNameField.ForeColor = Color.Gray;

            userSurnameField.Text = "Введите фамилию";
            userSurnameField.ForeColor = Color.Gray;

            userLoginField.Text = "Придумайте логин";
            userLoginField.ForeColor = Color.Gray;

            userLoginField.Text = "Придумайте логин";
            userLoginField.ForeColor = Color.Gray;

            userPassField.UseSystemPasswordChar = false;
            userPassField.Text = "Придумайте пароль";
            userPassField.ForeColor = Color.Gray;

            userConfPassField.UseSystemPasswordChar = false;
            userConfPassField.Text = "Повторите пароль";    
            userConfPassField.ForeColor = Color.Gray;
        }

        private void userNameField_Enter(object sender, EventArgs e)
        {
            if (userNameField.Text == "Введите имя")
            {
                userNameField.Text = "";
                userNameField.ForeColor = Color.Black;
            }
        }

        private void userNameField_Leave(object sender, EventArgs e)
        {
            if (userNameField.Text == "")
            {
                userNameField.Text = "Введите имя";
                userNameField.ForeColor = Color.Gray;
            }
        }
        private void userSurnameField_Enter(object sender, EventArgs e)
        {
            if (userSurnameField.Text == "Введите фамилию")
            {
                userSurnameField.Text = "";
                userSurnameField.ForeColor = Color.Black;
            }
        }

        private void userSurnameField_Leave(object sender, EventArgs e)
        {
            if (userSurnameField.Text == "")
            {
                userSurnameField.Text = "Введите фамилию";
                userSurnameField.ForeColor = Color.Gray;
            }
        }

        private void userLoginField_Enter(object sender, EventArgs e)
        {
            if (userLoginField.Text == "Придумайте логин")
            {
                userLoginField.Text = "";
                userLoginField.ForeColor = Color.Black;
            }
        }

        private void userLoginField_Leave(object sender, EventArgs e)
        {
            if (userLoginField.Text == "")
            {
                userLoginField.Text = "Придумайте логин";
                userLoginField.ForeColor = Color.Gray;
            }
        }

        private void userPassField_Enter(object sender, EventArgs e)
        {
            if (userPassField.Text == "Придумайте пароль")
            {
                userPassField.UseSystemPasswordChar = true;
                userPassField.Text = "";
                userPassField.ForeColor = Color.Black;
            }
        }

        private void userPassField_Leave(object sender, EventArgs e)
        {
            if (userPassField.Text == "")
            {
                userPassField.UseSystemPasswordChar = false;
                userPassField.Text = "Придумайте пароль";
                userPassField.ForeColor = Color.Gray;
            }
        }

        private void userConfPassField_Enter(object sender, EventArgs e)
        {
            if (userConfPassField.Text == "Повторите пароль")
            {
                userConfPassField.UseSystemPasswordChar = true;
                userConfPassField.Text = "";
                userConfPassField.ForeColor = Color.Black;
            }
        }

        private void userConfPassField_Leave(object sender, EventArgs e)
        {
            if (userConfPassField.Text == "")
            {
                userConfPassField.UseSystemPasswordChar = false;
                userConfPassField.Text = "Повторите пароль";
                userConfPassField.ForeColor = Color.Gray;
            }
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            if(userNameField.Text == "Введите имя" || userNameField.Text == "")
            {
                MessageBox.Show("Введите имя");
                return;
            }

            if (userSurnameField.Text == "Введите фамилию" || userSurnameField.Text == "")
            {
                MessageBox.Show("Введите фамилию");
                return;
            }

            if (userLoginField.Text == "Придумайте логин" || userLoginField.Text == "")
            {
                MessageBox.Show("Придумайте логин");
                return;
            }

            if (userPassField.Text == "Придумайте пароль" || userPassField.Text == "")
            {
                MessageBox.Show("Введите пароль");
                return;
            }

            if (userConfPassField.Text == "Подтвердите пароль" || userConfPassField.Text == "")
            {
                MessageBox.Show("Подтвердите пароль");
                return;
            }

            if (isUserExists())
                return;

            DB db = new DB();
            MySqlCommand command = new MySqlCommand("insert into users(name, surname, login, password, confirmPass) values(@name, @surname, @login, @password, @confirmPass)", db.getConnection());

            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = userNameField.Text;
            command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = userSurnameField.Text;
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = userLoginField.Text;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = userPassField.Text;
            command.Parameters.Add("@confirmPass", MySqlDbType.VarChar).Value = userConfPassField.Text;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Аккаунт был создан");
            else
                MessageBox.Show("Что-то пошло не так");

            db.closeConnection();
        }

        public Boolean isUserExists() 
        {
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("select * from users where login = @uL", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = userLoginField.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Пользователь с таким логином уже существует!");
                return true;
            }
            else
                return false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }
    }
}
