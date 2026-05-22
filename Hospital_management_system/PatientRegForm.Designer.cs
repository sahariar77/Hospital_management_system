namespace Hospital_management_system
{
    partial class PatientRegForm
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
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtPatientId = new TextBox();
            label6 = new Label();
            txtRegDate = new TextBox();
            label7 = new Label();
            label8 = new Label();
            txtFullName = new TextBox();
            txtPhone = new TextBox();
            label9 = new Label();
            cmbGender = new ComboBox();
            cmbBloodGroup = new ComboBox();
            label11 = new Label();
            label13 = new Label();
            label14 = new Label();
            txtEmergencyNumber = new TextBox();
            label15 = new Label();
            label16 = new Label();
            chkCBC = new CheckBox();
            chkXRay = new CheckBox();
            chkECG = new CheckBox();
            chkUltrasound = new CheckBox();
            chkBloodSugar = new CheckBox();
            chkLipid = new CheckBox();
            chkUrine = new CheckBox();
            chkThyroid = new CheckBox();
            label17 = new Label();
            panel2 = new Panel();
            txtTotalPaid = new Label();
            label18 = new Label();
            REGDONE = new Button();
            txtDOB = new DateTimePicker();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkBlue;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(824, 51);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(12, 31);
            label2.Name = "label2";
            label2.Size = new Size(150, 17);
            label2.TabIndex = 1;
            label2.Text = "Fill in all required details";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(12, 8);
            label1.Name = "label1";
            label1.Size = new Size(201, 23);
            label1.TabIndex = 0;
            label1.Text = "New Patient Registration";
            // 
            // label3
            // 
            label3.BackColor = Color.Silver;
            label3.Location = new Point(12, 81);
            label3.Name = "label3";
            label3.Size = new Size(775, 2);
            label3.TabIndex = 1;
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(12, 61);
            label4.Name = "label4";
            label4.Size = new Size(166, 20);
            label4.TabIndex = 2;
            label4.Text = "PATIENT INFORMATION";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(22, 93);
            label5.Name = "label5";
            label5.Size = new Size(85, 20);
            label5.TabIndex = 3;
            label5.Text = "PATIENT ID";
            // 
            // txtPatientId
            // 
            txtPatientId.BackColor = Color.FromArgb(55, 55, 55);
            txtPatientId.ForeColor = SystemColors.ButtonHighlight;
            txtPatientId.Location = new Point(22, 116);
            txtPatientId.Multiline = true;
            txtPatientId.Name = "txtPatientId";
            txtPatientId.ReadOnly = true;
            txtPatientId.Size = new Size(348, 32);
            txtPatientId.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(429, 93);
            label6.Name = "label6";
            label6.Size = new Size(149, 20);
            label6.TabIndex = 5;
            label6.Text = "REGISTRATION DATE";
            // 
            // txtRegDate
            // 
            txtRegDate.BackColor = Color.FromArgb(55, 55, 55);
            txtRegDate.ForeColor = SystemColors.ButtonHighlight;
            txtRegDate.Location = new Point(429, 116);
            txtRegDate.Multiline = true;
            txtRegDate.Name = "txtRegDate";
            txtRegDate.PlaceholderText = "mm/dd/yyyy";
            txtRegDate.ReadOnly = true;
            txtRegDate.Size = new Size(348, 32);
            txtRegDate.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(22, 172);
            label7.Name = "label7";
            label7.Size = new Size(94, 20);
            label7.TabIndex = 7;
            label7.Text = "FULL NAME ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(429, 172);
            label8.Name = "label8";
            label8.Size = new Size(113, 20);
            label8.TabIndex = 8;
            label8.Text = "DATE OF BIRTH";
            // 
            // txtFullName
            // 
            txtFullName.BackColor = Color.FromArgb(55, 55, 55);
            txtFullName.ForeColor = SystemColors.ButtonHighlight;
            txtFullName.Location = new Point(22, 195);
            txtFullName.Multiline = true;
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(348, 34);
            txtFullName.TabIndex = 9;
            // 
            // txtPhone
            // 
            txtPhone.BackColor = Color.FromArgb(55, 55, 55);
            txtPhone.ForeColor = SystemColors.ButtonHighlight;
            txtPhone.Location = new Point(22, 373);
            txtPhone.Multiline = true;
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(348, 34);
            txtPhone.TabIndex = 11;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(22, 259);
            label9.Name = "label9";
            label9.Size = new Size(67, 20);
            label9.TabIndex = 12;
            label9.Text = "GENDER";
            // 
            // cmbGender
            // 
            cmbGender.BackColor = Color.FromArgb(55, 55, 55);
            cmbGender.Font = new Font("Segoe UI", 11.5F);
            cmbGender.ForeColor = SystemColors.ButtonHighlight;
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Male", "Female" });
            cmbGender.Location = new Point(22, 282);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(348, 33);
            cmbGender.TabIndex = 13;
            // 
            // cmbBloodGroup
            // 
            cmbBloodGroup.BackColor = Color.FromArgb(55, 55, 55);
            cmbBloodGroup.Font = new Font("Segoe UI", 11.5F);
            cmbBloodGroup.ForeColor = SystemColors.ButtonHighlight;
            cmbBloodGroup.FormattingEnabled = true;
            cmbBloodGroup.Items.AddRange(new object[] { "A+", "A-", "B+", "B-", "O+", "O-", "AB+", "AB-" });
            cmbBloodGroup.Location = new Point(430, 281);
            cmbBloodGroup.Name = "cmbBloodGroup";
            cmbBloodGroup.Size = new Size(347, 33);
            cmbBloodGroup.TabIndex = 15;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.ButtonHighlight;
            label11.Location = new Point(430, 258);
            label11.Name = "label11";
            label11.Size = new Size(112, 20);
            label11.TabIndex = 16;
            label11.Text = "BLOOD GROUP";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = SystemColors.ButtonHighlight;
            label13.Location = new Point(22, 350);
            label13.Name = "label13";
            label13.Size = new Size(127, 20);
            label13.TabIndex = 18;
            label13.Text = "PHONE NUMBER";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = SystemColors.ButtonHighlight;
            label14.Location = new Point(430, 350);
            label14.Name = "label14";
            label14.Size = new Size(167, 20);
            label14.TabIndex = 19;
            label14.Text = "EMERGENCY NUMBER ";
            // 
            // txtEmergencyNumber
            // 
            txtEmergencyNumber.BackColor = Color.FromArgb(55, 55, 55);
            txtEmergencyNumber.ForeColor = SystemColors.ButtonHighlight;
            txtEmergencyNumber.Location = new Point(429, 373);
            txtEmergencyNumber.Multiline = true;
            txtEmergencyNumber.Name = "txtEmergencyNumber";
            txtEmergencyNumber.Size = new Size(348, 34);
            txtEmergencyNumber.TabIndex = 20;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = SystemColors.ButtonHighlight;
            label15.Location = new Point(19, 432);
            label15.Name = "label15";
            label15.Size = new Size(119, 23);
            label15.TabIndex = 21;
            label15.Text = "ASSIGN TESTS";
            // 
            // label16
            // 
            label16.BorderStyle = BorderStyle.Fixed3D;
            label16.ForeColor = SystemColors.AppWorkspace;
            label16.Location = new Point(12, 455);
            label16.Name = "label16";
            label16.Size = new Size(775, 2);
            label16.TabIndex = 22;
            // 
            // chkCBC
            // 
            chkCBC.AutoSize = true;
            chkCBC.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkCBC.ForeColor = SystemColors.ButtonHighlight;
            chkCBC.Location = new Point(22, 472);
            chkCBC.Name = "chkCBC";
            chkCBC.Size = new Size(62, 24);
            chkCBC.TabIndex = 23;
            chkCBC.Text = "CBC ";
            chkCBC.UseVisualStyleBackColor = true;
            chkCBC.CheckedChanged += chkTest_CheckedChanged;
            // 
            // chkXRay
            // 
            chkXRay.AutoSize = true;
            chkXRay.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkXRay.ForeColor = SystemColors.ButtonHighlight;
            chkXRay.Location = new Point(227, 472);
            chkXRay.Name = "chkXRay";
            chkXRay.Size = new Size(78, 27);
            chkXRay.TabIndex = 24;
            chkXRay.Text = "X-RAY";
            chkXRay.UseVisualStyleBackColor = true;
            chkXRay.CheckedChanged += chkTest_CheckedChanged;
            // 
            // chkECG
            // 
            chkECG.AutoSize = true;
            chkECG.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkECG.ForeColor = SystemColors.ButtonHighlight;
            chkECG.Location = new Point(22, 515);
            chkECG.Name = "chkECG";
            chkECG.Size = new Size(58, 24);
            chkECG.TabIndex = 25;
            chkECG.Text = "ECG";
            chkECG.UseVisualStyleBackColor = true;
            chkECG.CheckedChanged += chkTest_CheckedChanged;
            // 
            // chkUltrasound
            // 
            chkUltrasound.AutoSize = true;
            chkUltrasound.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkUltrasound.ForeColor = SystemColors.ButtonHighlight;
            chkUltrasound.Location = new Point(227, 515);
            chkUltrasound.Name = "chkUltrasound";
            chkUltrasound.Size = new Size(141, 27);
            chkUltrasound.TabIndex = 26;
            chkUltrasound.Text = "ULTRASOUND";
            chkUltrasound.UseVisualStyleBackColor = true;
            chkUltrasound.CheckedChanged += chkTest_CheckedChanged;
            // 
            // chkBloodSugar
            // 
            chkBloodSugar.AutoSize = true;
            chkBloodSugar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkBloodSugar.ForeColor = SystemColors.ButtonHighlight;
            chkBloodSugar.Location = new Point(439, 472);
            chkBloodSugar.Name = "chkBloodSugar";
            chkBloodSugar.Size = new Size(132, 24);
            chkBloodSugar.TabIndex = 27;
            chkBloodSugar.Text = "BLOOD SUGAR";
            chkBloodSugar.UseVisualStyleBackColor = true;
            chkBloodSugar.CheckedChanged += chkTest_CheckedChanged;
            // 
            // chkLipid
            // 
            chkLipid.AutoSize = true;
            chkLipid.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkLipid.ForeColor = SystemColors.ButtonFace;
            chkLipid.Location = new Point(439, 515);
            chkLipid.Name = "chkLipid";
            chkLipid.Size = new Size(130, 24);
            chkLipid.TabIndex = 28;
            chkLipid.Text = "LIPID PROFILE ";
            chkLipid.UseVisualStyleBackColor = true;
            chkLipid.CheckedChanged += chkTest_CheckedChanged;
            // 
            // chkUrine
            // 
            chkUrine.AutoSize = true;
            chkUrine.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkUrine.ForeColor = SystemColors.ButtonHighlight;
            chkUrine.Location = new Point(642, 472);
            chkUrine.Name = "chkUrine";
            chkUrine.Size = new Size(102, 24);
            chkUrine.TabIndex = 29;
            chkUrine.Text = "URINE R/E";
            chkUrine.UseVisualStyleBackColor = true;
            chkUrine.CheckedChanged += chkTest_CheckedChanged;
            // 
            // chkThyroid
            // 
            chkThyroid.AutoSize = true;
            chkThyroid.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkThyroid.ForeColor = SystemColors.ButtonHighlight;
            chkThyroid.Location = new Point(642, 515);
            chkThyroid.Name = "chkThyroid";
            chkThyroid.Size = new Size(94, 24);
            chkThyroid.TabIndex = 30;
            chkThyroid.Text = "THYROID";
            chkThyroid.UseVisualStyleBackColor = true;
            chkThyroid.CheckedChanged += chkTest_CheckedChanged;
            // 
            // label17
            // 
            label17.BackColor = Color.LightGray;
            label17.ForeColor = SystemColors.ControlText;
            label17.Location = new Point(12, 557);
            label17.Name = "label17";
            label17.Size = new Size(775, 2);
            label17.TabIndex = 31;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(38, 38, 38);
            panel2.Controls.Add(txtTotalPaid);
            panel2.Controls.Add(label18);
            panel2.Location = new Point(22, 576);
            panel2.Name = "panel2";
            panel2.Size = new Size(755, 55);
            panel2.TabIndex = 32;
            // 
            // txtTotalPaid
            // 
            txtTotalPaid.AutoSize = true;
            txtTotalPaid.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTotalPaid.ForeColor = SystemColors.ButtonHighlight;
            txtTotalPaid.Location = new Point(671, 19);
            txtTotalPaid.Name = "txtTotalPaid";
            txtTotalPaid.Size = new Size(17, 20);
            txtTotalPaid.TabIndex = 1;
            txtTotalPaid.Text = "0";
            txtTotalPaid.Click += txtAmountPaid_Click;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.ForeColor = SystemColors.ButtonHighlight;
            label18.Location = new Point(10, 19);
            label18.Name = "label18";
            label18.Size = new Size(70, 20);
            label18.TabIndex = 0;
            label18.Text = "Total Fee";
            // 
            // REGDONE
            // 
            REGDONE.ForeColor = SystemColors.ActiveCaptionText;
            REGDONE.Location = new Point(349, 670);
            REGDONE.Name = "REGDONE";
            REGDONE.Size = new Size(107, 29);
            REGDONE.TabIndex = 33;
            REGDONE.Text = "DONE ";
            REGDONE.UseVisualStyleBackColor = true;
            REGDONE.Click += REGDONE_Click;
            // 
            // txtDOB
            // 
            txtDOB.CalendarForeColor = SystemColors.GrayText;
            txtDOB.CalendarMonthBackground = Color.White;
            txtDOB.Format = DateTimePickerFormat.Short;
            txtDOB.Location = new Point(430, 200);
            txtDOB.MaxDate = new DateTime(2026, 5, 22, 0, 0, 0, 0);
            txtDOB.Name = "txtDOB";
            txtDOB.Size = new Size(347, 27);
            txtDOB.TabIndex = 34;
            txtDOB.Value = new DateTime(2026, 5, 22, 0, 0, 0, 0);
            // 
            // PatientRegForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(55, 55, 55);
            ClientSize = new Size(824, 724);
            Controls.Add(txtDOB);
            Controls.Add(REGDONE);
            Controls.Add(panel2);
            Controls.Add(label17);
            Controls.Add(chkThyroid);
            Controls.Add(chkUrine);
            Controls.Add(chkLipid);
            Controls.Add(chkBloodSugar);
            Controls.Add(chkUltrasound);
            Controls.Add(chkECG);
            Controls.Add(chkXRay);
            Controls.Add(chkCBC);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(txtEmergencyNumber);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label11);
            Controls.Add(cmbBloodGroup);
            Controls.Add(cmbGender);
            Controls.Add(label9);
            Controls.Add(txtPhone);
            Controls.Add(txtFullName);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(txtRegDate);
            Controls.Add(label6);
            Controls.Add(txtPatientId);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel1);
            ForeColor = SystemColors.AppWorkspace;
            Name = "PatientRegForm";
            Text = "PatientRegForm";
            Load += PatientRegForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtPatientId;
        private Label label6;
        private TextBox txtRegDate;
        private Label label7;
        private Label label8;
        private TextBox txtFullName;
        private TextBox txtPhone;
        private Label label9;
        private ComboBox cmbGender;
        private ComboBox cmbBloodGroup;
        private Label label11;
        private Label label13;
        private Label label14;
        private TextBox txtEmergencyNumber;
        private Label label15;
        private Label label16;
        private CheckBox chkCBC;
        private CheckBox chkXRay;
        private CheckBox chkECG;
        private CheckBox chkUltrasound;
        private CheckBox chkBloodSugar;
        private CheckBox chkLipid;
        private CheckBox chkUrine;
        private CheckBox chkThyroid;
        private Label label17;
        private Panel panel2;
        private Label label18;
        private Label txtTotalPaid;
        private Button REGDONE;
        private DateTimePicker txtDOB;
    }
}