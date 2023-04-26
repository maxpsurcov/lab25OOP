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
    public partial class SearchForm : Form
    {
        private readonly string connectionString;
        private readonly string tableName;
        public SearchForm()
        {
            InitializeComponent();
            this.connectionString = connectionString;
            this.tableName = tableName;
        }
        private void SearchForm_Load(object sender, EventArgs e)
        {
            // Завантаження даних з бази даних
            LoadData();
        }

        private void LoadData()
        {
            // Підключення до бази даних
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Виконання запиту на отримання даних
                var sql = $"SELECT * FROM {tableName}";
                using (var command = new SqlCommand(sql, connection))
                {
                    using (var adapter = new SqlDataAdapter(command))
                    {
                        var dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Встановлення даних в DataGridView
                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Пошук даних
            var searchText = txtSearch.Text;
            var filteredTable = ((DataTable)dataGridView1.DataSource).Select($"ColumnName = '{searchText}'");

            // Встановлення відфільтрованих даних в DataGridView
            dataGridView1.DataSource = filteredTable.Length > 0 ? filteredTable.CopyToDataTable() : null;
        }
        public void AddRow(string column1, string column2, string column3)
        {
            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(dataGridView1);
            row.Cells[0].Value = column1;
            row.Cells[1].Value = column2;
            row.Cells[2].Value = column3;
            dataGridView1.Rows.Add(row);
        }

    }
}
