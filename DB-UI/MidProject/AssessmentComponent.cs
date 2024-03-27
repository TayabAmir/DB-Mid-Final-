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
    public partial class AssessmentComponent : Form
    {
        string constr = "Data Source=TAYYAB-PROGRAMM;Initial Catalog=StuManage;Integrated Security=True;";
		public AssessmentComponent()
        {
            InitializeComponent();
            List<string> Assessments = new List<string>();
            List<string> Details = new List<string>();
            using (SqlConnection conn = new SqlConnection(constr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT Title FROM Assessment", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Assessments.Add(reader["Title"].ToString());
                }
                reader.Close();
                cmd = new SqlCommand("SELECT Details from Rubric", conn);
                SqlDataReader readers = cmd.ExecuteReader();
                while (readers.Read())
                {
                    Details.Add(readers["Details"].ToString());
                }
                readers.Close();
            }
            comboBox1.DataSource = Details;
            comboBox2.DataSource = Assessments;
            dataGridView1.CellClick += dataGridView1_CellContentClick;
            ShowTable();
        }

        private void AssessmentComponent_Load(object sender, EventArgs e)
        {

        }
        private void ShowTable()
        {
            using (SqlConnection conn = new SqlConnection(constr))
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("Select * From AssessmentComponent", conn);
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
                textBox1.Text = row.Cells["Name"].Value.ToString();
                textBox2.Text = row.Cells["TotalMarks"].Value.ToString();

                int rubricId = Convert.ToInt32(row.Cells["RubricId"].Value);
                int assessmentId = Convert.ToInt32(row.Cells["AssessmentId"].Value);

                comboBox1.Text = GetDetails(rubricId);
                comboBox2.Text = GetAssessment(assessmentId);
                maskedTextBox1.Text = row.Cells["id"].Value.ToString();
            }
        }

        private string GetDetails(int id)
        {
            string details = "";
            using (SqlConnection conn = new SqlConnection(constr))
            {
                conn.Open();
                string Query = "SELECT Details FROM Rubric WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(Query, conn);
                cmd.Parameters.AddWithValue("@Id", id);
                object result = cmd.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    details = result.ToString(); 
                }
            }
            return details;
        }
        private string GetAssessment(int id)
        {
            string details = "";
            using (SqlConnection conn = new SqlConnection(constr))
            {
                conn.Open();
                string Query = "SELECT Title FROM Assessment WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(Query, conn);
                cmd.Parameters.AddWithValue("@Id", id);
                object result = cmd.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    details = result.ToString(); 
                }
            }
            return details;
        }
        private int GetRubricId(string Text)
        {
            int rubricId = -1;
            using (SqlConnection conn = new SqlConnection(constr))
            {
                conn.Open();
                string Query = "SELECT Id FROM Rubric WHERE Details = @Text";
                SqlCommand cmd = new SqlCommand(Query, conn);
                cmd.Parameters.AddWithValue("@Text", Text);
                object result = cmd.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    rubricId = Convert.ToInt32(result);
                }
            }
            return rubricId;
        }
        private int GetAssessmentId(string Text)
        {
            int rubricId = -1;
            using (SqlConnection conn = new SqlConnection(constr))
            {
                conn.Open();
                string Query = "SELECT Id FROM Assessment WHERE Title = @Text";
                SqlCommand cmd = new SqlCommand(Query, conn);
                cmd.Parameters.AddWithValue("@Text", Text);
                object result = cmd.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    rubricId = Convert.ToInt32(result);
                }
            }
            return rubricId;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine(comboBox1.Text);
            using (SqlConnection conn = new SqlConnection(constr))
            {
                conn.Open();
                string Query = "Insert INTO AssessmentComponent Values (@Name,@RubricId, @TotalMarks, GetDate(), GetDate(), @AssessmentId)";
                SqlCommand cmd = new SqlCommand(Query, conn);
                cmd.Parameters.AddWithValue("@Name", textBox1.Text);
                cmd.Parameters.AddWithValue("@TotalMarks", textBox2.Text);
                cmd.Parameters.AddWithValue("@RubricId", GetRubricId(comboBox1.Text));
                cmd.Parameters.AddWithValue("@AssessmentId", GetAssessmentId(comboBox2.Text));
                cmd.ExecuteNonQuery();
                MessageBox.Show("AssessmentComponent Added Successfully", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            ShowTable();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(constr))
            {
                conn.Open();
                string Query = "Update AssessmentComponent Set Name=@Name, TotalMarks=@TotalMarks, DateUpdated=GETDATE() where Id = @Id";
                SqlCommand cmd = new SqlCommand(Query, conn);
                cmd.Parameters.AddWithValue("@Name", textBox1.Text);
                cmd.Parameters.AddWithValue("@TotalMarks", int.Parse(textBox2.Text));
                cmd.Parameters.AddWithValue("@Id", int.Parse(maskedTextBox1.Text));
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                    MessageBox.Show("Assessment Component Updated Successfully", "Update", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                else
                    MessageBox.Show("No Assessment Component Found of this Registration Number Found", "Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ShowTable();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            try {
                using (SqlConnection conn = new SqlConnection(constr))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("delete AssessmentComponent where Id=@Id", conn);
                    cmd.Parameters.AddWithValue("@Id", int.Parse(maskedTextBox1.Text));
                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                        MessageBox.Show("Assessment Component Deleted Successfully", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("No Record Found", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                ShowTable();
            }
            catch
            {
                MessageBox.Show("Cannot Delete! The Primary Key 'Id' in this is used as a Foreign key in another table  ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            Home home = new Home();
            home.ShowDialog();
        }

		private void label3_Click(object sender, EventArgs e)
		{

		}
	}
}
