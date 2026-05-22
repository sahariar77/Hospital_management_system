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
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Hospital_management_system
{
    public partial class PatientPanel : Form
    {
        SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=PROJECT;Integrated Security=True;TrustServerCertificate=True");

        public string loggedInUser;
        public PatientPanel(string id)
        {
            InitializeComponent();
            loggedInUser = id;
        }

        private void PatientPanel_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                string query = "SELECT TestName, Status, Cost FROM TestReports WHERE PatientId = @patientId";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@patientId", loggedInUser);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnDownloadtast_Click(object sender, EventArgs e)
        {
            string sourceFilePath = Path.Combine(Application.StartupPath, "UploadedReports", loggedInUser + "_Report.pdf");


            if (File.Exists(sourceFilePath))
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();


                saveFileDialog.FileName = loggedInUser + "_Report.pdf";
                saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
                saveFileDialog.Title = "Save Your Test Report PDF";


                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {

                        File.Copy(sourceFilePath, saveFileDialog.FileName, true);
                        MessageBox.Show("Report Downloaded Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Download Failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {

                MessageBox.Show("Your report is not ready yet or pending!", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnPatientLogout_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to logout from Patient Portal?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                // ২. লগইন ফর্ম (Form1) আবার স্ক্রিনে নিয়ে আসা
                Form1 loginForm = new Form1();
                loginForm.Show();

                // ৩. কারেন্ট পেশেন্ট প্যানেল ফর্মটি বন্ধ করে দেওয়া
                this.Close();
            }
        }
    }
}
