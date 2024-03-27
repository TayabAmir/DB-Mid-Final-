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
    public partial class Rubrics : Form
    {
		string ConnectionString = "Data Source=TAYYAB-PROGRAMM;Initial Catalog=StuManage;Integrated Security=True;";
		public Rubrics()
        {
            InitializeComponent();
            ShowTable();
            List<int> dataSource = new List<int>();
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT Id FROM Clo", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    dataSource.Add((int)reader["Id"]);
                }
            }
            comboBox1.DataSource = dataSource;
            dataGridView1.CellClick += dataGridView1_CellContentClick;
        }

        private void Rubrics_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Rubric VALUES (@Details, @CloId)", conn);
                cmd.Parameters.AddWithValue("@Details", richTextBox1.Text);
                cmd.Parameters.AddWithValue("@CloId", comboBox1.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Rubric Added Successfully", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            ShowTable();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            Home obj = new Home();
            obj.ShowDialog();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            ManageAssesment obj = new ManageAssesment();
            obj.ShowDialog();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            Rubric_Level obj = new Rubric_Level();
            obj.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("update Rubric set Details=@Details,CloId=@CloId where Id = @RubricId", conn);
                cmd.Parameters.AddWithValue("@RubricId", maskedTextBox1.Text);
                cmd.Parameters.AddWithValue("@CloId", comboBox1.Text);
                cmd.Parameters.AddWithValue("@Details", richTextBox1.Text);
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                    MessageBox.Show("Rubric Updated Successfully", "Update", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                else
                    MessageBox.Show("No Rubric Found of this id", "Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ShowTable();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int cloId = int.Parse(comboBox1.Text);
                string details = richTextBox1.Text;

                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM Rubric WHERE Id = @RubricId", conn);
                    cmd.Parameters.AddWithValue("@RubricId", maskedTextBox1.Text);
                    cmd.Parameters.AddWithValue("@CloId", cloId);
                    cmd.Parameters.AddWithValue("@Details", details);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Rubric Deleted Successfully", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No Rubric found with the specified CLO ID and Details", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                ShowTable();
            }
            catch
            {
                MessageBox.Show("Cannot Delete! The Primary Key 'Rubric Id' in this is used as a Foreign key in another table  ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void ShowTable()
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("Select * From Rubric", conn);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count - 1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                maskedTextBox1.Text = row.Cells["Id"].Value.ToString();
                comboBox1.Text = row.Cells["CloId"].Value.ToString();
                richTextBox1.Text = row.Cells["Details"].Value.ToString();
            }
        }
    }
}
