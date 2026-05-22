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
    public partial class UploadReportFrom : Form
    {
        string selectedFilePath = ""; 
        string connString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=PROJECT;Integrated Security=True;TrustServerCertificate=True";

        public UploadReportFrom()
        {
            InitializeComponent();
        }

        private void UploadReportFrom_Load(object sender, EventArgs e)
        {

        }



       
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "PDF Files (*.pdf)|*.pdf"; 

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedFilePath = openFileDialog.FileName;
                MessageBox.Show("PDF Selected: " + Path.GetFileName(selectedFilePath), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



     

        private void btnUpload_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPatientId.Text) || string.IsNullOrEmpty(selectedFilePath))
            {
                MessageBox.Show("Please enter Patient ID and select a PDF file!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }





            using (SqlConnection con = new SqlConnection(connString))
            {
                try
                {
                    con.Open();

                    
                    string queryCheck = "SELECT COUNT(*) FROM Patients WHERE PatientId = @pId";
                    SqlCommand cmdCheck = new SqlCommand(queryCheck, con);
                    cmdCheck.Parameters.AddWithValue("@pId", txtPatientId.Text.Trim());
                    int patientExists = (int)cmdCheck.ExecuteScalar();

                    if (patientExists == 0)
                    {
                        MessageBox.Show("This Patient ID does not exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    
                    string folderPath = Path.Combine(Application.StartupPath, "UploadedReports");
                    if (!Directory.Exists(folderPath))
                    {
                        Directory.CreateDirectory(folderPath);
                    }

                    
                    string fileName = txtPatientId.Text.Trim() + "_Report.pdf";
                    string destFilePath = Path.Combine(folderPath, fileName);

                    File.Copy(selectedFilePath, destFilePath, true); 

                    
                    string queryUpdate = "UPDATE TestReports SET Status = 'Completed', ReportPath = @path WHERE PatientId = @pId";
                    SqlCommand cmdUpdate = new SqlCommand(queryUpdate, con);
                    cmdUpdate.Parameters.AddWithValue("@path", fileName);
                    cmdUpdate.Parameters.AddWithValue("@pId", txtPatientId.Text.Trim());

                    cmdUpdate.ExecuteNonQuery();

                    MessageBox.Show("Report Uploaded and Status Marked as DONE!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                   
                    if (Application.OpenForms["AdminDashboard"] is AdminDashboard dashboard)
                    {
                        dashboard.RefreshGrid();
                    }

                    this.Close(); 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

       
    }
}
