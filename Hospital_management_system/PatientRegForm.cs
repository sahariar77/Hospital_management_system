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
    public partial class PatientRegForm : Form
    {
        string connString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=PROJECT;Integrated Security=True;TrustServerCertificate=True";

        AdminDashboard _dashboard;
        public PatientRegForm(AdminDashboard dashboard)
        {
            InitializeComponent();
            _dashboard = dashboard;

        }


        private void PatientRegForm_Load(object sender, EventArgs e)
        {
           
            txtRegDate.Text = DateTime.Now.ToString("MM/dd/yyyy");

            using (SqlConnection con = new SqlConnection(connString))
            {
                try
                {
                    con.Open();
                    string queryCount = "SELECT COUNT(*) FROM Patients";
                    SqlCommand cmd = new SqlCommand(queryCount, con);

                    int count = (int)cmd.ExecuteScalar();
                    int nextIdNumber = count + 1;

                    txtPatientId.Text = (10000 + nextIdNumber).ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error generating ID: " + ex.Message);
                }
            }
        }








        //total fee 
        private void CalculateTotalFee()
        {
            int totalFee = 0;

            if (chkCBC.Checked) totalFee += 400;       // CBC = 400 Tk
            if (chkXRay.Checked) totalFee += 500;      // X-Ray = 500 Tk
            if (chkBloodSugar.Checked) totalFee += 150; // Blood Sugar = 150 Tk
            if (chkUrine.Checked) totalFee += 200;     // Urine = 200 Tk
            if (chkECG.Checked) totalFee += 400;       // ECG = 400 Tk
            if (chkUltrasound.Checked) totalFee += 1200; // Ultrasound = 1200 Tk
            if (chkLipid.Checked) totalFee += 600;     // Lipid Profile = 600 Tk
            if (chkThyroid.Checked) totalFee += 800;   // Thyroid = 800 Tk

            
            txtTotalPaid.Text = totalFee.ToString();
        }



        private void chkTest_CheckedChanged(object sender, EventArgs e)
        {
            CalculateTotalFee();
        }







   
        private void REGDONE_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(txtFullName.Text) || string.IsNullOrEmpty(txtPhone.Text))
            {
                MessageBox.Show("Please enter Patient Name and Phone Number!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection con = new SqlConnection(connString))
            {
                try
                {
                    con.Open();

                
                    string queryPatient = "INSERT INTO Patients (PatientId, FullName, RegDate, DOB, Gender, BloodGroup, Phone, EmergencyContact, PaidAmount) VALUES (@id, @name, @regDate, @dob, @gender, @blood, @phone, @emergency, @PaidAmount)";

                    SqlCommand cmd = new SqlCommand(queryPatient, con);

                    
                    cmd.Parameters.AddWithValue("@id", txtPatientId.Text.Trim());
                    cmd.Parameters.AddWithValue("@name", txtFullName.Text.Trim());
                    cmd.Parameters.AddWithValue("@regDate", txtRegDate.Text.Trim());
                    cmd.Parameters.AddWithValue("@dob", txtDOB.Value.ToString("MM/dd/yyyy")); 
                    cmd.Parameters.AddWithValue("@gender", cmbGender.Text);
                    cmd.Parameters.AddWithValue("@blood", cmbBloodGroup.Text);
                    cmd.Parameters.AddWithValue("@phone", txtPhone.Text.Trim());
                    cmd.Parameters.AddWithValue("@emergency", txtEmergencyNumber.Text.Trim());
                    cmd.Parameters.AddWithValue("@PaidAmount", Convert.ToInt32(txtTotalPaid.Text.Trim()));

                    cmd.ExecuteNonQuery(); 
                    
                    CheckBox[] allTests = { chkCBC, chkXRay, chkBloodSugar, chkUrine, chkECG, chkUltrasound, chkLipid, chkThyroid };
                    Random rand = new Random();

                    foreach (CheckBox chk in allTests) 
                    {
                        if (chk.Checked == true)
                        {
                            // ১. কোন টেস্টের কত দাম, সেটা কোড দিয়ে ডাইনামিকালি বের করা
                            int testCost = 0;
                            if (chk == chkCBC) testCost = 400;
                            else if (chk == chkXRay) testCost = 500;
                            else if (chk == chkBloodSugar) testCost = 150;
                            else if (chk == chkUrine) testCost = 200;
                            else if (chk == chkECG) testCost = 400;
                            else if (chk == chkUltrasound) testCost = 1200;
                            else if (chk == chkLipid) testCost = 600;
                            else if (chk == chkThyroid) testCost = 800;

                            // ২. SQL কুয়েরিতে Cost কলামটা যোগ করা হলো
                            string queryTest = "INSERT INTO TestReports (TestId, PatientId, TestName, Status, Cost) VALUES (@tId, @pId, @tName, 'Pending', @cost)";
                            SqlCommand cmdTest = new SqlCommand(queryTest, con);

                            cmdTest.Parameters.AddWithValue("@tId", rand.Next(10000, 99999));
                            cmdTest.Parameters.AddWithValue("@pId", txtPatientId.Text.Trim());
                            cmdTest.Parameters.AddWithValue("@tName", chk.Text);
                            cmdTest.Parameters.AddWithValue("@cost", testCost); // 🎯 সুনির্দিষ্ট টেস্টের দাম এখানে পাস হলো
                            cmdTest.ExecuteNonQuery();
                        }
                    }


                    string currentPatientId = txtPatientId.Text.Trim(); // অটো জেনারেট হওয়া আইডিটা নিলাম

                    string queryUser = "INSERT INTO Users (UserId, Password) VALUES (@uId, @pass)";
                    SqlCommand cmdUser = new SqlCommand(queryUser, con);

                    cmdUser.Parameters.AddWithValue("@uId", currentPatientId); // পেশেন্টের আইডিটাই লগইন আইডি
                    cmdUser.Parameters.AddWithValue("@pass", "1234");          // ডিফল্ট পাসওয়ার্ড ১২৩৪ সেট করলাম

                    cmdUser.ExecuteNonQuery();

                    MessageBox.Show("Patient Registered and Tests Assigned Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    if (_dashboard != null)
                    {
                        _dashboard.RefreshGrid(); 
                    }
                    this.Close(); 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message);
                }
            } 
        }


       







        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void txtAmountPaid_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void dtpDOB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}