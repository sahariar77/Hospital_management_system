namespace Hospital_management_system
{
    partial class PatientPanel
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
            label1 = new Label();
            label2 = new Label();
            btnDownloadtast = new Button();
            dataGridView1 = new DataGridView();
            btnPatientLogout = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(799, 59);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(283, 18);
            label1.Name = "label1";
            label1.Size = new Size(223, 26);
            label1.TabIndex = 0;
            label1.Text = "Welcome to Patient Portal";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(7, 121);
            label2.Name = "label2";
            label2.Size = new Size(208, 20);
            label2.TabIndex = 1;
            label2.Text = "Download your tasts report : ";
            // 
            // btnDownloadtast
            // 
            btnDownloadtast.AutoSize = true;
            btnDownloadtast.BackColor = Color.FromArgb(38, 38, 38);
            btnDownloadtast.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDownloadtast.ForeColor = SystemColors.ButtonHighlight;
            btnDownloadtast.Location = new Point(221, 111);
            btnDownloadtast.Name = "btnDownloadtast";
            btnDownloadtast.Size = new Size(49, 48);
            btnDownloadtast.TabIndex = 2;
            btnDownloadtast.Text = "⬇️";
            btnDownloadtast.UseVisualStyleBackColor = false;
            btnDownloadtast.Click += btnDownloadtast_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 201);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(800, 251);
            dataGridView1.TabIndex = 3;
            // 
            // btnPatientLogout
            // 
            btnPatientLogout.Location = new Point(694, 166);
            btnPatientLogout.Name = "btnPatientLogout";
            btnPatientLogout.Size = new Size(94, 29);
            btnPatientLogout.TabIndex = 4;
            btnPatientLogout.Text = "Logout";
            btnPatientLogout.UseVisualStyleBackColor = true;
            btnPatientLogout.Click += btnPatientLogout_Click;
            // 
            // PatientPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(38, 38, 38);
            ClientSize = new Size(800, 450);
            Controls.Add(btnPatientLogout);
            Controls.Add(dataGridView1);
            Controls.Add(btnDownloadtast);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "PatientPanel";
            Text = "PatientPanel";
            Load += PatientPanel_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Button btnDownloadtast;
        private DataGridView dataGridView1;
        private Button btnPatientLogout;
    }
}