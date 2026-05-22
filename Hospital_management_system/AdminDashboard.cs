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

namespace Hospital_management_system
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {

        }







        //main panal
        private void panel8_Paint(object sender, PaintEventArgs e)
        {
            string connString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=PROJECT;Integrated Security=True;TrustServerCertificate=True";
            SqlConnection con = new SqlConnection(connString);

            try
            {
                con.Open();


                string queryTable = "SELECT PatientId, FullName, RegDate, DOB, Gender, BloodGroup, Phone, EmergencyContact, PaidAmount FROM Patients";
                SqlDataAdapter adapter = new SqlDataAdapter(queryTable, con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);


                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = dt;


                string queryTotalPat = "SELECT COUNT(*) FROM Patients";
                SqlCommand cmd1 = new SqlCommand(queryTotalPat, con);
                lblTotalPatients.Text = cmd1.ExecuteScalar().ToString();


                string queryActiveTest = "SELECT COUNT(*) FROM TestReports WHERE Status = 'Pending'";
                SqlCommand cmd2 = new SqlCommand(queryActiveTest, con);
                lblActiveTests.Text = cmd2.ExecuteScalar().ToString();


                string queryBalance = "SELECT SUM(PaidAmount) FROM Patients";
                SqlCommand cmd3 = new SqlCommand(queryBalance, con);
                object sumResult = cmd3.ExecuteScalar();

                if (sumResult != DBNull.Value)
                {
                    lblTotalDue.Text = sumResult.ToString() + " Tk";
                }
                else
                {
                    lblTotalDue.Text = "0 Tk";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Loading Dashboard: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }












        //patient search
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearchBox.Text))
            {
                RefreshGrid();
                return;
            }

            string connString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=PROJECT;Integrated Security=True;TrustServerCertificate=True";
            SqlConnection con = new SqlConnection(connString);

            try
            {
                con.Open();

                string queryBalance = "SELECT Patients.PatientId, FullName, TestName, Status, PaidAmount " +
                                      "FROM Patients, TestReports " +
                                      "WHERE Patients.PatientId = TestReports.PatientId AND Patients.PatientId = @id";

                SqlCommand cmd3 = new SqlCommand(queryBalance, con);
                cmd3.Parameters.AddWithValue("@id", txtSearchBox.Text.Trim());

                SqlDataAdapter adapter = new SqlDataAdapter(cmd3);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt; // table ea sob data eksathe dekhabe 
                }
                else
                {
                    MessageBox.Show("No Patient or Test Report Found with this ID!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }






        public void RefreshGrid()
        {
            string connString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=PROJECT;Integrated Security=True;TrustServerCertificate=True";
            SqlConnection con = new SqlConnection(connString);

            try
            {
                con.Open();
                string queryTable = "SELECT PatientId, FullName, RegDate, DOB, Gender, BloodGroup, Phone, EmergencyContact, PaidAmount FROM Patients";
                SqlDataAdapter adapter = new SqlDataAdapter(queryTable, con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = dt; // tabel ea new data refresh hobe


                string queryTotalPat = "SELECT COUNT(*) FROM Patients";
                SqlCommand cmd1 = new SqlCommand(queryTotalPat, con);
                lblTotalPatients.Text = cmd1.ExecuteScalar().ToString();

                string queryActiveTest = "SELECT COUNT(*) FROM TestReports WHERE Status = 'Pending'";
                SqlCommand cmd2 = new SqlCommand(queryActiveTest, con);
                lblActiveTests.Text = cmd2.ExecuteScalar().ToString();

                string queryBalance = "SELECT SUM(PaidAmount) FROM Patients";
                SqlCommand cmd3 = new SqlCommand(queryBalance, con);
                object sumResult = cmd3.ExecuteScalar();
                if (sumResult != DBNull.Value) lblTotalDue.Text = sumResult.ToString() + " Tk";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Refresh Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }







        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTotalPatients_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)  // new patient reg
        {
            PatientRegForm regForm = new PatientRegForm(this);
            regForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            UploadReportFrom uploadForm = new UploadReportFrom();
            uploadForm.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                // ২. লগইন ফর্মের (Form1) একটি নতুন অবজেক্ট তৈরি করা
                Form1 loginForm = new Form1();
                loginForm.Show(); // লগইন স্ক্রিন আবার ওপেন হবে

                // ৩. কারেন্ট অ্যাডমিন ড্যাশবোর্ডটি পুরোপুরি বন্ধ করে দেওয়া
                this.Close();
            }
        }
    }
}
