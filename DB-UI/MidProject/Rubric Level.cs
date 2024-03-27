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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MidProject
{
    public partial class Rubric_Level : Form
    {
		string ConnectionString = "Data Source=TAYYAB-PROGRAMM;Initial Catalog=StuManage;Integrated Security=True;";
		public Rubric_Level()
        {
            InitializeComponent();

            ShowTable();
            List<int> dataSource = new List<int>();
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT Id FROM Rubric", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    dataSource.Add((int)reader["Id"]);
                }
            }
            comboBox1.DataSource = dataSource;
            comboBox2.Items.Add("1");
            comboBox2.Items.Add("2");
            comboBox2.Items.Add("3");
            comboBox2.Items.Add("4");
            dataGridView1.CellClick += dataGridView1_CellContentClick;
        }
        private void ShowTable()
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("Select * From RubricLevel", conn);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count - 1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                comboBox1.Text = row.Cells["RubricId"].Value.ToString();
                textBox1.Text = row.Cells["Details"].Value.ToString();
                comboBox2.Text = row.Cells["MeasurementLevel"].Value.ToString();
                textBox2.Text = row.Cells["Id"].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO RubricLevel values (@RubricId, @Details, @MeasurmentLevel)", conn);
                cmd.Parameters.AddWithValue("@RubricId", comboBox1.Text);
                cmd.Parameters.AddWithValue("@Details", textBox1.Text);
                cmd.Parameters.AddWithValue("MeasurmentLevel", comboBox2.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Rubric Added Successfully", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            ShowTable();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("update RubricLevel set RubricId=@RubricId,Details = @Details, MeasurementLevel=@MeasurementLevel where Id = @Id", conn);
                cmd.Parameters.AddWithValue("@RubricId", comboBox1.Text);
                cmd.Parameters.AddWithValue("@Details", textBox1.Text);
                cmd.Parameters.AddWithValue("@MeasurementLevel", comboBox2.Text);
                cmd.Parameters.AddWithValue("@Id", textBox2.Text);
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                    MessageBox.Show("Record Updated Successfully", "Update", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                else
                    MessageBox.Show("No Record Found of this id", "Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ShowTable();
        }

        private void button3_Click(object sender, EventArgs e)
        {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("delete RubricLevel where Id = @Id", conn);
                    cmd.Parameters.AddWithValue("@Id", textBox2.Text);
                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                        MessageBox.Show("Deleted Successfully", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("No Record Found", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                ShowTable();
         }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            Home home = new Home();
            home.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
