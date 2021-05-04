using MySql.Data.MySqlClient;
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
    public partial class MainForm : Form
    {
        string connectString = "Data Source=.\\SQLEXPRESS;Initial Catalog=TRPO_carshop;Integrated Security=true;";
        SqlConnection myConnection;
        SqlDataAdapter adapter;
        DataTable table;
        List<string[]> data = new List<string[]>();
        public MainForm()
        {
            InitializeComponent();

            LoadData();
        }

        void LoadData()
        {
            
            myConnection = new SqlConnection(connectString);

            myConnection.Open();

            string query = "SELECT cars.carName, cars.price, model.modelName, fuel.fuelName FROM cars join model on cars.modelID = model.ID join fuel on cars.fuelID = fuel.ID";

            //SqlCommand command = new SqlCommand(query, myConnection);
            SqlDataAdapter command = new SqlDataAdapter(query, myConnection);

            table = new DataTable();

            command.Fill(table);

            dataMenu2.DataSource = table;
            dataMenu2.ReadOnly = true;

            //SqlDataReader reader = command.ExecuteReader();

            //while (reader.Read())
            //{
            //    data.Add(new string[4]);

            //    data[data.Count - 1][0] = reader[0].ToString();
            //    data[data.Count - 1][1] = reader[1].ToString();
            //    data[data.Count - 1][2] = reader[2].ToString();
            //    data[data.Count - 1][3] = reader[3].ToString();
            //}

            //reader.Close();

            myConnection.Close();

            //foreach (string[] s in data)
            //    dataMenu.Rows.Add(s);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SearchField.Text = "Поиск автомобиля";
            SearchField.ForeColor = Color.Gray;
        }

        private void SearchField_Enter(object sender, EventArgs e)
        {
            if (SearchField.Text == "Поиск автомобиля")
            {
                SearchField.Text = "";
                SearchField.ForeColor = Color.Black;
            }
        }

        private void SearchField_Leave(object sender, EventArgs e)
        {
            if (SearchField.Text == "")
            {
                SearchField.Text = "Поиск автомобиля";
                SearchField.ForeColor = Color.Gray;
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            myConnection = new SqlConnection(connectString);
            myConnection.Open();
            adapter = new SqlDataAdapter("SELECT cars.carName, cars.price, model.modelName, fuel.fuelName FROM cars join model on cars.modelID = model.ID join fuel on cars.fuelID = fuel.ID where carName like '" + SearchField.Text + "%'", myConnection);
            table = new DataTable();
            adapter.Fill(table);
            dataMenu2.DataSource = table;
            dataMenu2.ReadOnly = true;
            myConnection.Close();

            //myConnection = new SqlConnection(connectString);
            //myConnection.Open();
            //SqlCommand adapter = new SqlCommand("SELECT cars.carName, cars.price, model.modelName, fuel.fuelName FROM cars join model on cars.modelID = model.ID join fuel on cars.fuelID = fuel.ID where carName like '" + SearchField.Text + "%'", myConnection);
            //SqlDataReader reader = adapter.ExecuteReader();

            //while (reader.Read())
            //{

            //    data.Add(new string[4]);
            //    data.Clear();
            //    data[data.Count - 1][0] = reader[0].ToString();
            //    data[data.Count - 1][1] = reader[1].ToString();
            //    data[data.Count - 1][2] = reader[2].ToString();
            //    data[data.Count - 1][3] = reader[3].ToString();
            //}

            //reader.Close();

            //myConnection.Close();

            //foreach (string[] s in data)
            //    dataMenu.Rows.Add(s);
        }

        private void ProSearchButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdvancedSearch aSearch = new AdvancedSearch();
            aSearch.Show();

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

        private void dataMenu2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
