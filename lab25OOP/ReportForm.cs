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

namespace lab25OOP
{
    public partial class ReportForm : Form
    {
        private SqlConnection connection;
        private SqlDataAdapter adapter;
        private DataTable dataTable;
        public ReportForm()
        {
            InitializeComponent();
        }
        public ReportForm(string connectionString, string query)
        {
            InitializeComponent();

            try
            {
                connection = new SqlConnection(connectionString);
                adapter = new SqlDataAdapter(query, connection);
                dataTable = new DataTable();

                adapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка: " + ex.Message);
            }
        }

        private void ReportForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (connection != null && connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }
        public void AddRow(string column1, string column2, string column3)
        {
            // Код для додавання рядка в DataGridView
            DataGridViewRow row = new DataGridViewRow();
            row.Cells[0].Value = column1;
            row.Cells[1].Value = column2;
            row.Cells[2].Value = column3;
            dataGridView1.Rows.Add(row);
        }


    }
}
