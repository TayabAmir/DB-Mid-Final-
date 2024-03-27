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

namespace MidProject
{
    public partial class ManageAssesment : Form
    {
		string ConnectionString = "Data Source=TAYYAB-PROGRAMM;Initial Catalog=StuManage;Integrated Security=True;";
		public ManageAssesment()
        {
            InitializeComponent();
            ShowTable();
            dataGridView1.CellClick += dataGridView1_CellContentClick;
        }

        private void ManageAssesment_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void ShowTable()
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("Select * From Assessment", conn);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("DELETE ASSESSMENT WHERE Id = @Id", conn);
                    cmd.Parameters.AddWithValue("@Id", textBox4.Text);
                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                        MessageBox.Show("Assessment Deleted Successfully", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("No Assessment Found", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                ShowTable();
            }
            catch
            {
                MessageBox.Show("Cannot Delete! The Primary Key 'Assessment Id' in this is used as a Foreign key in another table  ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("update Assessment set Title=@Title,TotalMarks=@TotalMarks, TotalWeightage=@TotalWeightage where Id = @Id", conn);
                cmd.Parameters.AddWithValue("@Title", textBox1.Text);
                cmd.Parameters.AddWithValue("@TotalMarks", textBox2.Text);
                cmd.Parameters.AddWithValue("@TotalWeightage", textBox3.Text);
                cmd.Parameters.AddWithValue("@Id", textBox4.Text);
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                    MessageBox.Show("Assessment Updated Successfully", "Update", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                else
                    MessageBox.Show("No Assessment Found of this id", "Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ShowTable();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO ASSESSMENT VALUES (@title, GETDATE(),@TotalMarks,@TotalWeightage)", conn);
                cmd.Parameters.AddWithValue("@Title", textBox1.Text);
                cmd.Parameters.AddWithValue("@TotalMarks", textBox2.Text);
                cmd.Parameters.AddWithValue("@TotalWeightage", textBox3.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Assessment Added Successfully", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            ShowTable();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            Rubrics rubrics = new Rubrics();
            rubrics.ShowDialog();
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            Home form1 = new Home();
            form1.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count - 1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                textBox1.Text = row.Cells["Title"].Value.ToString();
                textBox2.Text = row.Cells["TotalMarks"].Value.ToString();
                textBox3.Text = row.Cells["TotalWeightage"].Value.ToString();
                textBox4.Text = row.Cells["Id"].Value.ToString();
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            AssessmentComponent assessmentComponent = new AssessmentComponent();
            assessmentComponent.ShowDialog();
        }

		private void label2_Click(object sender, EventArgs e)
		{

		}
	}
}
