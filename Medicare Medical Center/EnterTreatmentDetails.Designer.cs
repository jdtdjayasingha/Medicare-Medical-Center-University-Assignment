namespace Medicare_Medical_Center
{
    partial class EnterTreatmentDetails
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
            fileSystemWatcher1 = new FileSystemWatcher();
            patient_IDTB = new TextBox();
            label9 = new Label();
            saveDataBtn = new Button();
            doctor_IDTB = new TextBox();
            dateTB = new TextBox();
            descriptionTB = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            Treatment = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            textBox1 = new TextBox();
            patientGW = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)patientGW).BeginInit();
            SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // patient_IDTB
            // 
            patient_IDTB.Location = new Point(178, 237);
            patient_IDTB.Margin = new Padding(3, 4, 3, 4);
            patient_IDTB.Name = "patient_IDTB";
            patient_IDTB.Size = new Size(246, 27);
            patient_IDTB.TabIndex = 45;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(27, 237);
            label9.Name = "label9";
            label9.Size = new Size(96, 28);
            label9.TabIndex = 44;
            label9.Text = "Patient ID";
            // 
            // saveDataBtn
            // 
            saveDataBtn.BackColor = Color.CornflowerBlue;
            saveDataBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            saveDataBtn.Location = new Point(178, 355);
            saveDataBtn.Margin = new Padding(3, 4, 3, 4);
            saveDataBtn.Name = "saveDataBtn";
            saveDataBtn.Size = new Size(93, 34);
            saveDataBtn.TabIndex = 43;
            saveDataBtn.Text = "Insert";
            saveDataBtn.UseVisualStyleBackColor = false;
            saveDataBtn.Click += saveDataBtn_Click;
            // 
            // doctor_IDTB
            // 
            doctor_IDTB.Location = new Point(178, 300);
            doctor_IDTB.Margin = new Padding(3, 4, 3, 4);
            doctor_IDTB.Name = "doctor_IDTB";
            doctor_IDTB.Size = new Size(246, 27);
            doctor_IDTB.TabIndex = 42;
            // 
            // dateTB
            // 
            dateTB.Location = new Point(178, 179);
            dateTB.Margin = new Padding(3, 4, 3, 4);
            dateTB.Name = "dateTB";
            dateTB.Size = new Size(246, 27);
            dateTB.TabIndex = 41;
            // 
            // descriptionTB
            // 
            descriptionTB.Location = new Point(178, 119);
            descriptionTB.Margin = new Padding(3, 4, 3, 4);
            descriptionTB.Name = "descriptionTB";
            descriptionTB.Size = new Size(246, 27);
            descriptionTB.TabIndex = 40;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(27, 300);
            label4.Name = "label4";
            label4.Size = new Size(97, 28);
            label4.TabIndex = 39;
            label4.Text = "Doctor ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(27, 175);
            label3.Name = "label3";
            label3.Size = new Size(53, 28);
            label3.TabIndex = 38;
            label3.Text = "Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(27, 115);
            label2.Name = "label2";
            label2.Size = new Size(112, 28);
            label2.TabIndex = 37;
            label2.Text = "Description";
            label2.Click += label2_Click;
            // 
            // Treatment
            // 
            Treatment.AutoSize = true;
            Treatment.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Treatment.ForeColor = Color.Navy;
            Treatment.Location = new Point(417, 28);
            Treatment.Name = "Treatment";
            Treatment.Size = new Size(142, 38);
            Treatment.TabIndex = 36;
            Treatment.Text = "Treatment";
            Treatment.Click += Treatment_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 192, 0);
            button1.Location = new Point(277, 355);
            button1.Name = "button1";
            button1.Size = new Size(94, 34);
            button1.TabIndex = 46;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Tomato;
            button2.Location = new Point(377, 355);
            button2.Name = "button2";
            button2.Size = new Size(94, 34);
            button2.TabIndex = 47;
            button2.Text = "Delect";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.LimeGreen;
            button3.Location = new Point(523, 116);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 48;
            button3.Text = "Search";
            button3.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(636, 119);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(187, 27);
            textBox1.TabIndex = 49;
            // 
            // patientGW
            // 
            patientGW.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            patientGW.Location = new Point(492, 163);
            patientGW.Name = "patientGW";
            patientGW.RowHeadersWidth = 51;
            patientGW.Size = new Size(501, 242);
            patientGW.TabIndex = 50;
            // 
            // EnterTreatmentDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(1002, 418);
            Controls.Add(patientGW);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(patient_IDTB);
            Controls.Add(label9);
            Controls.Add(saveDataBtn);
            Controls.Add(doctor_IDTB);
            Controls.Add(dateTB);
            Controls.Add(descriptionTB);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Treatment);
            Margin = new Padding(3, 4, 3, 4);
            Name = "EnterTreatmentDetails";
            Text = "EnterTreatmentDetails";
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ((System.ComponentModel.ISupportInitialize)patientGW).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FileSystemWatcher fileSystemWatcher1;
        private TextBox patient_IDTB;
        private Label label9;
        private Button saveDataBtn;
        private TextBox doctor_IDTB;
        private TextBox dateTB;
        private TextBox descriptionTB;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label Treatment;
        private Button button2;
        private Button button1;
        private TextBox textBox1;
        private Button button3;
        private DataGridView patientGW;
    }
}