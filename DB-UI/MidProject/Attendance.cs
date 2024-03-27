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
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MidProject
{
    public partial class Attendance : Form
    {
		string constr = "Data Source=TAYYAB-PROGRAMM;Initial Catalog=StuManage;Integrated Security=True;";
		public Attendance()
        {
            InitializeComponent();
            List<string> dataSource = new List<string>();
            using (SqlConnection conn = new SqlConnection(constr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT RegistrationNumber FROM Student", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    dataSource.Add(reader["RegistrationNumber"].ToString());
                }
            }
            comboBox1.DataSource = dataSource;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            Home form1 = new Home();
            form1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(constr))
            {
                conn.Open();
                SqlCommand cmd1 = new SqlCommand("INSERT INTO ClassAttendance (AttendanceDate) VALUES (@Date)", conn);
                cmd1.Parameters.AddWithValue("@Date", dateTimePicker1.Value);
                cmd1.ExecuteNonQuery();

                int status = GetStatus(comboBox2.Text);
                SqlCommand cmd = new SqlCommand("INSERT INTO StudentAttendance (AttendanceId, StudentId, AttendanceStatus) VALUES ((SELECT Id FROM ClassAttendance WHERE AttendanceDate = @Date), (SELECT Id FROM Student WHERE RegistrationNumber = @RegistrationNumber), @Status)", conn);
                cmd.Parameters.AddWithValue("@Date", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@RegistrationNumber", comboBox1.Text);
                cmd.Parameters.AddWithValue("@Status", status);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Attendance saved successfully", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private int GetStatus(string text)
        {
            int status = -1;
            using (SqlConnection conn = new SqlConnection(constr))
            {
                conn.Open();
                string Query = "SELECT LookupId FROM Lookup WHERE Name = @Text";
                SqlCommand cmd = new SqlCommand(Query, conn);
                cmd.Parameters.AddWithValue("@Text", text);
                object result = cmd.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    status = Convert.ToInt32(result);
                }
            }
            return status;
        }

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}
