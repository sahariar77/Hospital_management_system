namespace Hospital_management_system
{
    partial class AdminDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel2 = new Panel();
            label5 = new Label();
            label4 = new Label();
            panel3 = new Panel();
            lblTotalPatients = new Label();
            label6 = new Label();
            panel4 = new Panel();
            lblActiveTests = new Label();
            label8 = new Label();
            label7 = new Label();
            panel5 = new Panel();
            lblTotalDue = new Label();
            label9 = new Label();
            btnNewPatient = new Panel();
            button1 = new Button();
            label10 = new Label();
            panel7 = new Panel();
            label11 = new Label();
            button5 = new Button();
            panel8 = new Panel();
            dataGridView1 = new DataGridView();
            label12 = new Label();
            btnSearch = new Button();
            txtSearchBox = new TextBox();
            btnLogout = new Button();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            btnNewPatient.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.WindowFrame;
            panel2.Controls.Add(btnLogout);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(-1, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1419, 72);
            panel2.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlLight;
            label5.Location = new Point(7, 39);
            label5.Name = "label5";
            label5.Size = new Size(206, 17);
            label5.TabIndex = 1;
            label5.Text = "Manage patient, tests, and billing ";
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(3, 8);
            label4.Name = "label4";
            label4.Size = new Size(309, 25);
            label4.TabIndex = 0;
            label4.Text = "System Overview and Quick Action";
            // 
            // panel3
            // 
            panel3.BackColor = Color.AliceBlue;
            panel3.BackgroundImageLayout = ImageLayout.None;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(lblTotalPatients);
            panel3.Controls.Add(label6);
            panel3.Location = new Point(33, 78);
            panel3.Name = "panel3";
            panel3.Size = new Size(193, 87);
            panel3.TabIndex = 2;
            // 
            // lblTotalPatients
            // 
            lblTotalPatients.AutoSize = true;
            lblTotalPatients.BackColor = Color.AliceBlue;
            lblTotalPatients.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalPatients.ForeColor = SystemColors.ActiveCaptionText;
            lblTotalPatients.Location = new Point(68, 38);
            lblTotalPatients.Name = "lblTotalPatients";
            lblTotalPatients.Size = new Size(27, 31);
            lblTotalPatients.TabIndex = 1;
            lblTotalPatients.Text = "0";
            lblTotalPatients.Click += lblTotalPatients_Click;
            // 
            // label6
            // 
            label6.AccessibleRole = AccessibleRole.None;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(14, 8);
            label6.Name = "label6";
            label6.Size = new Size(111, 23);
            label6.TabIndex = 0;
            label6.Text = "Total Patients";
            // 
            // panel4
            // 
            panel4.BackColor = Color.AliceBlue;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(lblActiveTests);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(label7);
            panel4.Location = new Point(33, 175);
            panel4.Name = "panel4";
            panel4.Size = new Size(193, 87);
            panel4.TabIndex = 3;
            // 
            // lblActiveTests
            // 
            lblActiveTests.AutoSize = true;
            lblActiveTests.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblActiveTests.ForeColor = SystemColors.ActiveCaptionText;
            lblActiveTests.Location = new Point(74, 38);
            lblActiveTests.Name = "lblActiveTests";
            lblActiveTests.Size = new Size(27, 31);
            lblActiveTests.TabIndex = 2;
            lblActiveTests.Text = "0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ActiveCaptionText;
            label8.Location = new Point(3, 68);
            label8.Name = "label8";
            label8.Size = new Size(98, 17);
            label8.TabIndex = 1;
            label8.Text = "pending results";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(12, 8);
            label7.Name = "label7";
            label7.Size = new Size(97, 23);
            label7.TabIndex = 0;
            label7.Text = "Active Tests";
            // 
            // panel5
            // 
            panel5.BackColor = Color.AliceBlue;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(lblTotalDue);
            panel5.Controls.Add(label9);
            panel5.Location = new Point(266, 130);
            panel5.Name = "panel5";
            panel5.Size = new Size(235, 87);
            panel5.TabIndex = 4;
            // 
            // lblTotalDue
            // 
            lblTotalDue.AutoSize = true;
            lblTotalDue.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalDue.ForeColor = SystemColors.ActiveCaptionText;
            lblTotalDue.Location = new Point(54, 38);
            lblTotalDue.Name = "lblTotalDue";
            lblTotalDue.Size = new Size(27, 31);
            lblTotalDue.TabIndex = 1;
            lblTotalDue.Text = "0";
            lblTotalDue.TextAlign = ContentAlignment.TopCenter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ActiveCaptionText;
            label9.Location = new Point(15, 9);
            label9.Name = "label9";
            label9.Size = new Size(115, 23);
            label9.TabIndex = 0;
            label9.Text = "Total Balance ";
            // 
            // btnNewPatient
            // 
            btnNewPatient.BackColor = Color.SteelBlue;
            btnNewPatient.Controls.Add(button1);
            btnNewPatient.Controls.Add(label10);
            btnNewPatient.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNewPatient.Location = new Point(939, 103);
            btnNewPatient.Name = "btnNewPatient";
            btnNewPatient.Size = new Size(358, 71);
            btnNewPatient.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(14, 13);
            button1.Name = "button1";
            button1.Size = new Size(46, 42);
            button1.TabIndex = 2;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label10
            // 
            label10.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ButtonHighlight;
            label10.Location = new Point(60, 23);
            label10.Name = "label10";
            label10.Size = new Size(222, 32);
            label10.TabIndex = 1;
            label10.Text = "New patient registration ";
            // 
            // panel7
            // 
            panel7.BackColor = Color.SteelBlue;
            panel7.Controls.Add(label11);
            panel7.Controls.Add(button5);
            panel7.Location = new Point(939, 214);
            panel7.Name = "panel7";
            panel7.Size = new Size(358, 71);
            panel7.TabIndex = 6;
            // 
            // label11
            // 
            label11.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.ButtonHighlight;
            label11.Location = new Point(66, 23);
            label11.Name = "label11";
            label11.Size = new Size(248, 44);
            label11.TabIndex = 1;
            label11.Text = "Upload / Update Test Report";
            // 
            // button5
            // 
            button5.Location = new Point(14, 13);
            button5.Name = "button5";
            button5.Size = new Size(46, 44);
            button5.TabIndex = 0;
            button5.Text = "📝";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // panel8
            // 
            panel8.BackColor = Color.DimGray;
            panel8.Controls.Add(dataGridView1);
            panel8.Controls.Add(label12);
            panel8.ForeColor = Color.SteelBlue;
            panel8.Location = new Point(7, 299);
            panel8.Name = "panel8";
            panel8.Size = new Size(1397, 427);
            panel8.TabIndex = 7;
            panel8.Paint += panel8_Paint;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.FromArgb(38, 38, 38);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.FromArgb(45, 45, 45);
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1391, 424);
            dataGridView1.TabIndex = 4;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = SystemColors.ButtonHighlight;
            label12.Location = new Point(9, 15);
            label12.Name = "label12";
            label12.Size = new Size(0, 20);
            label12.TabIndex = 0;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = SystemColors.MenuHighlight;
            btnSearch.Location = new Point(665, 184);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(119, 37);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearchBox
            // 
            txtSearchBox.BackColor = Color.WhiteSmoke;
            txtSearchBox.ForeColor = SystemColors.WindowFrame;
            txtSearchBox.Location = new Point(634, 139);
            txtSearchBox.Multiline = true;
            txtSearchBox.Name = "txtSearchBox";
            txtSearchBox.PlaceholderText = "Search Patient Id";
            txtSearchBox.Size = new Size(183, 35);
            txtSearchBox.TabIndex = 2;
            txtSearchBox.TextChanged += textBox1_TextChanged;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(1138, 31);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(94, 29);
            btnLogout.TabIndex = 2;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSlateGray;
            ClientSize = new Size(1416, 738);
            Controls.Add(panel8);
            Controls.Add(btnSearch);
            Controls.Add(panel7);
            Controls.Add(txtSearchBox);
            Controls.Add(btnNewPatient);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "AdminDashboard";
            Text = "AdminDashboard";
            Load += AdminDashboard_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            btnNewPatient.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel2;
        private Label label4;
        private Label label5;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Label label6;
        private Label label8;
        private Label label7;
        private Label label9;
        private Panel btnNewPatient;
        private Panel panel7;
        private Label label10;
        private Button button3_Click;
        private Label label11;
        private Button button5;
        private Panel panel8;
        private Label label12;
        private TextBox txtSearchBox;
        private Button btnSearch;
        private DataGridView dataGridView1;
        private Label lblTotalPatients;
        private Label lblActiveTests;
        private Label lblTotalDue;
        private Button button1;
        private Button btnLogout;
    }
}