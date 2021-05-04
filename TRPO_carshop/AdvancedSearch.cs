using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRPO_carshop
{
    public partial class AdvancedSearch : Form
    {
        string connectString = "Data Source=.\\SQLEXPRESS;Initial Catalog=TRPO_carshop;Integrated Security=true;";
        SqlConnection myConnection;
        SqlDataAdapter adapter;
        DataTable table;
        public AdvancedSearch()
        {
            InitializeComponent();

            LoadData();
        }

        void LoadData()
        {
            myConnection = new SqlConnection(connectString);

            myConnection.Open();

            string query = "SELECT cars.carName, cars.price, model.modelName, fuel.fuelName FROM cars join model on cars.modelID = model.ID join fuel on cars.fuelID = fuel.ID";

            SqlDataAdapter command = new SqlDataAdapter(query, myConnection);

            table = new DataTable();

            command.Fill(table);

            dataMenu2.DataSource = table;
            dataMenu2.ReadOnly = true;

            myConnection.Close();
        }

        private void AdvancedSearch_Load()
        {
            MarkaBox.Text = "Выберите марку";
            MarkaBox.ForeColor = Color.Gray;

            FuelBox.Text = "Выберите тип топлива";
            FuelBox.ForeColor = Color.Gray;
        }

        private void MarkaBox_Enter(object sender, EventArgs e)
        {
            if (MarkaBox.Text == "Введите имя")
            {
                MarkaBox.Text = "";
                MarkaBox.ForeColor = Color.Black;
            }
        }

        private void MarakBox_Leave(object sender, EventArgs e)
        {
            if (MarkaBox.Text == "")
            {
                MarkaBox.Text = "Введите имя";
                MarkaBox.ForeColor = Color.Gray;
            }
        }

        private void FuelBox_Enter(object sender, EventArgs e)
        {
            if (FuelBox.Text == "Введите имя")
            {
                FuelBox.Text = "";
                FuelBox.ForeColor = Color.Black;
            }
        }

        private void FuelBox_Leave(object sender, EventArgs e)
        {
            if (FuelBox.Text == "")
            {
                FuelBox.Text = "Введите имя";
                FuelBox.ForeColor = Color.Gray;
            }
        }

        private void MarkaBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedState = MarkaBox.SelectedItem.ToString();
        }

        private void FuelBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedState = FuelBox.SelectedItem.ToString();
        }

        private void AdvancedButton_Click(object sender, EventArgs e)
        {
            myConnection = new SqlConnection(connectString);
            myConnection.Open();
            adapter = new SqlDataAdapter("SELECT cars.carName, cars.price, model.modelName, fuel.fuelName FROM cars join model on cars.modelID = model.ID join fuel on cars.fuelID = fuel.ID where modelName like '" + MarkaBox.Text + "%' and fuelName like '"+ FuelBox.Text + "%' and price between '"+ LowPriceBox.Text +"' and '"+ HighPriceBox.Text +"'", myConnection);
            table = new DataTable();
            adapter.Fill(table);
            dataMenu2.DataSource = table;
            dataMenu2.ReadOnly = true;
            myConnection.Close();
        }

        private void MainButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.Show();
        }

        private void ProfileButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Profile profile = new Profile();
            profile.Show();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }
    }
}
