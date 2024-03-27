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
    public partial class Student_Result : Form
    {
        string ConnectionString = "Data Source=TAYYAB-PROGRAMM;Initial Catalog=StuManage;Integrated Security=True;";
		public Student_Result()
        {
            InitializeComponent();
            List<string> regNo = new List<string>();
            List<string> Names = new List<string>();
            List<string> Details = new List<string>();
            using(SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select RegistrationNumber from Student", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    regNo.Add(dr["registrationNumber"].ToString());
                }
                dr.Close();
                cmd = new SqlCommand("Select Name from AssessmentComponent", conn);
                SqlDataReader sqlDataReader = cmd.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    Names.Add(sqlDataReader["Name"].ToString());
                }
                sqlDataReader.Close();
                cmd = new SqlCommand("Select Details from RubricLevel", conn);
                SqlDataReader sqlDataReader1 = cmd.ExecuteReader();
                while(sqlDataReader1.Read())
                {
                    Details.Add(sqlDataReader1["Details"].ToString());
                }
                sqlDataReader1.Close();
            }
            comboBox1.DataSource = regNo;
            comboBox2.DataSource = Names;
            comboBox3.DataSource = Details;
            dataGridView1.CellClick += dataGridView1_CellContentClick;
            ShowTable();
        }
        private void ShowTable()
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("Select * From StudentResult", conn);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using(SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                string Query = "Insert into StudentResult Values((Select Id From Student Where RegistrationNumber = @Reg),(Select Id From ASsessmentComponent where Name = @Name),(Select Id From RubricLevel where Details = @Details),GetDate())";
                SqlCommand cmd = new SqlCommand(Query, conn);
                cmd.Parameters.AddWithValue("@Reg", comboBox1.Text);
                cmd.Parameters.AddWithValue("@Name",comboBox2.Text);
                cmd.Parameters.AddWithValue("@Details",comboBox3.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Result Added Successfully","Add",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            ShowTable();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("delete StudentResult where StudentId = (Select Id from Student where RegistrationNumber = @RegNo)", conn);
                cmd.Parameters.AddWithValue("@RegNo", comboBox1.Text);
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                    MessageBox.Show("Student Deleted Successfully", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                else
                    MessageBox.Show("No Student Found", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ShowTable();
        }

        private string GetRegNo(int id)
        {
            string details = "";
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                string Query = "SELECT RegistrationNumber FROM Student WHERE Id = @Id";
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
        private string GetName(int id)
        {
            string details = "";
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                string Query = "SELECT Name FROM AssessmentComponent WHERE Id = @Id";
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
        private string GetDetails(int id)
        {
            string details = "";
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                string Query = "Select Details from RubricLevel WHERE Id = @Id";
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
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count - 1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                int id = Convert.ToInt32(row.Cells["StudentId"].Value);
                comboBox1.Text = GetRegNo(id);
                comboBox2.Text = GetName(Convert.ToInt32(row.Cells["AssessmentComponentId"].Value));
                comboBox3.Text = GetDetails(Convert.ToInt32(row.Cells["RubricMeasurementId"].Value));
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            Home home = new Home();
            home.ShowDialog();
        }
    }
}
