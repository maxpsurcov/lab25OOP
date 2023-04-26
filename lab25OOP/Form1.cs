using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Xml.Linq;
using MySql.Data.MySqlClient;

namespace lab25OOP
{
    public partial class Form1 : Form
    {
        private SqlConnection connection;
        public Form1()
        {
            InitializeComponent();
        }
        private void connectButton_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "server=localhost;user id=root;password=RO123r00t;database=ElectricityBilling";
                connection = new SqlConnection(connectionString);
                connection.Open();
                MessageBox.Show("Connection successful.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            if (connection == null || connection.State != System.Data.ConnectionState.Open)
            {
                MessageBox.Show("Please connect to the database first.");
                return;
            }

            string query = "INSERT INTO Consumers (Name, Address, ElectricityUsage) VALUES (@Name, @Address, @ElectricityUsage)";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Name", nameTextBox.Text);
                command.Parameters.AddWithValue("@Address", addressTextBox.Text);
                command.Parameters.AddWithValue("@ElectricityUsage", usageTextBox.Text);

                try
                {
                    int rowsAffected = command.ExecuteNonQuery();
                    MessageBox.Show(rowsAffected + " rows affected.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void report1Button_Click(object sender, EventArgs e)
        {
            if (connection == null || connection.State != System.Data.ConnectionState.Open)
            {
                MessageBox.Show("Please connect to the database first.");
                return;
            }

            string query = "SELECT Name, SUM(ElectricityUsage) AS TotalUsage FROM Consumers GROUP BY Name ORDER BY TotalUsage DESC";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                try
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        ReportForm reportForm = new ReportForm();
                        reportForm.Text = "Report 1";
                        while (reader.Read())
                        {
                            string name = reader.GetString(0);
                            int totalUsage = reader.GetInt32(1);
                            reportForm.AddRow(name, totalUsage.ToString(),"");
                        }
                        reportForm.ShowDialog();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void report2Button_Click(object sender, EventArgs e)
        {
            if (connection == null || connection.State != System.Data.ConnectionState.Open)
            {
                MessageBox.Show("Please connect to the database first.");
                return;
            }

            string query = "SELECT Address, AVG(ElectricityUsage) AS AvgUsage FROM Consumers GROUP BY Address ORDER BY AvgUsage DESC";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                try
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        ReportForm reportForm = new ReportForm();
                        reportForm.Text = "Report 2";
                        while (reader.Read())
                        {
                            string address = reader.GetString(0);
                            double avgUsage = reader.GetDouble(1);
                            reportForm.AddRow(address, avgUsage.ToString(), "");
                        }
                        reportForm.ShowDialog();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void searchButton_Click(object sender, EventArgs e)
        {
            if (connection == null || connection.State != System.Data.ConnectionState.Open)
            {
                MessageBox.Show("Please connect to the database first.");
                return;
            }

            string query = "SELECT Name, Address, ElectricityUsage FROM Consumers WHERE Name LIKE '%' + @Name + '%'";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Name", searchTextBox.Text);

                try
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        SearchForm searchForm = new SearchForm();
                        while (reader.Read())
                        {
                            string name = reader.GetString(0);
                            string address = reader.GetString(1);
                            int usage = reader.GetInt32(2);
                            searchForm.AddRow(name, address, usage.ToString());
                        }
                        searchForm.ShowDialog();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
