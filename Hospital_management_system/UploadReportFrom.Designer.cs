namespace Hospital_management_system
{
    partial class UploadReportFrom
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
            txtPatientId = new TextBox();
            label1 = new Label();
            btnBrowse = new Button();
            label2 = new Label();
            btnUpload = new Button();
            SuspendLayout();
            // 
            // txtPatientId
            // 
            txtPatientId.BackColor = Color.FromArgb(58, 58, 58);
            txtPatientId.ForeColor = SystemColors.ButtonHighlight;
            txtPatientId.Location = new Point(267, 86);
            txtPatientId.Multiline = true;
            txtPatientId.Name = "txtPatientId";
            txtPatientId.Size = new Size(221, 34);
            txtPatientId.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(123, 89);
            label1.Name = "label1";
            label1.Size = new Size(122, 20);
            label1.TabIndex = 1;
            label1.Text = "Enter Patient Id: ";
            // 
            // btnBrowse
            // 
            btnBrowse.FlatStyle = FlatStyle.Flat;
            btnBrowse.ForeColor = SystemColors.ButtonHighlight;
            btnBrowse.Location = new Point(267, 141);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(221, 37);
            btnBrowse.TabIndex = 2;
            btnBrowse.Text = "Select PDF";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(99, 175);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 3;
            // 
            // btnUpload
            // 
            btnUpload.Location = new Point(332, 209);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(94, 29);
            btnUpload.TabIndex = 4;
            btnUpload.Text = "Upload";
            btnUpload.UseVisualStyleBackColor = true;
            btnUpload.Click += btnUpload_Click_1;
            // 
            // UploadReportFrom
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(38, 38, 38);
            ClientSize = new Size(800, 450);
            Controls.Add(btnUpload);
            Controls.Add(label2);
            Controls.Add(btnBrowse);
            Controls.Add(label1);
            Controls.Add(txtPatientId);
            Name = "UploadReportFrom";
            Text = "UploadReportFrom";
            Load += UploadReportFrom_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPatientId;
        private Label label1;
        private Button btnBrowse;
        private Label label2;
        private Button btnUpload;
    }
}