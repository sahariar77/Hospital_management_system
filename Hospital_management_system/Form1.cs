using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;


namespace Hospital_management_system
{
    public partial class Form1 : Form
    {

        SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=PROJECT;Integrated Security=True;TrustServerCertificate=True");


        int loginAttempts = 0;
        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                
                if (string.IsNullOrEmpty(textBox1.Text.Trim()) || string.IsNullOrEmpty(textBox2.Text.Trim()))
                {
                    MessageBox.Show("Please enter both User ID and Password!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // ডাটাবেজে হিট না করেই কোড এখানেই থেমে যাবে
                }

                if (textBox2.Text.Trim().Length < 4)
                {
                    MessageBox.Show("Password must be at least 4 characters long!", "Security Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string query = "SELECT * FROM Users WHERE UserId = @id AND Password = @pass";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", textBox1.Text.Trim());
                cmd.Parameters.AddWithValue("@pass", textBox2.Text.Trim());

              
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt); 

               
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Login Success!");

                    
                    string loggedInUser = dt.Rows[0]["UserId"].ToString();

                    textBox1.Clear();
                    textBox2.Clear();

                    this.Hide(); 

                    
                    if (loggedInUser == "admin")
                    {
                        
                        AdminDashboard adminForm = new AdminDashboard();
                        adminForm.Show();
                    }
                    else
                    {
                        PatientPanel patientForm = new PatientPanel(loggedInUser);
                        patientForm.Show();
                    }
                }
               
                else
                {

                    loginAttempts++; // ভুল হলে ১ করে বাড়বে

                    if (loginAttempts >= 3)
                    {
                        button1.Enabled = false; // ৩ বার ভুল টাইপ করলে বাটন লক!
                        MessageBox.Show("Too many failed attempts! Login button has been disabled for security.", "Security Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show($"Wrong UserID or Password. Remaining attempts: {3 - loginAttempts}", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close(); 
            }
        }








        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
