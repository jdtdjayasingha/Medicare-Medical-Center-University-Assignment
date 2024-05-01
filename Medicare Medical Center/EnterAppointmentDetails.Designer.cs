namespace Medicare_Medical_Center
{
    partial class EnterAppointmentDetails
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
            timeTB = new TextBox();
            dateTB = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
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
            patient_IDTB.BackColor = Color.AliceBlue;
            patient_IDTB.Location = new Point(151, 250);
            patient_IDTB.Margin = new Padding(3, 4, 3, 4);
            patient_IDTB.Name = "patient_IDTB";
            patient_IDTB.Size = new Size(229, 27);
            patient_IDTB.TabIndex = 35;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.FromArgb(192, 192, 255);
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(27, 246);
            label9.Name = "label9";
            label9.Size = new Size(96, 28);
            label9.TabIndex = 33;
            label9.Text = "Patient ID";
            // 
            // saveDataBtn
            // 
            saveDataBtn.BackColor = Color.CornflowerBlue;
            saveDataBtn.Location = new Point(151, 378);
            saveDataBtn.Margin = new Padding(3, 4, 3, 4);
            saveDataBtn.Name = "saveDataBtn";
            saveDataBtn.Size = new Size(110, 33);
            saveDataBtn.TabIndex = 31;
            saveDataBtn.Text = "Insert";
            saveDataBtn.UseVisualStyleBackColor = false;
            saveDataBtn.Click += saveDataBtn_Click_1;
            // 
            // doctor_IDTB
            // 
            doctor_IDTB.BackColor = Color.AliceBlue;
            doctor_IDTB.Location = new Point(151, 315);
            doctor_IDTB.Margin = new Padding(3, 4, 3, 4);
            doctor_IDTB.Name = "doctor_IDTB";
            doctor_IDTB.Size = new Size(229, 27);
            doctor_IDTB.TabIndex = 28;
            // 
            // timeTB
            // 
            timeTB.BackColor = Color.AliceBlue;
            timeTB.Location = new Point(151, 184);
            timeTB.Margin = new Padding(3, 4, 3, 4);
            timeTB.Name = "timeTB";
            timeTB.Size = new Size(229, 27);
            timeTB.TabIndex = 27;
            // 
            // dateTB
            // 
            dateTB.BackColor = Color.AliceBlue;
            dateTB.Location = new Point(151, 114);
            dateTB.Margin = new Padding(3, 4, 3, 4);
            dateTB.Name = "dateTB";
            dateTB.Size = new Size(229, 27);
            dateTB.TabIndex = 26;
            dateTB.TextChanged += dateTB_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(192, 192, 255);
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(27, 315);
            label4.Name = "label4";
            label4.Size = new Size(97, 28);
            label4.TabIndex = 22;
            label4.Text = "Doctor ID";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(192, 192, 255);
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(27, 180);
            label3.Name = "label3";
            label3.Size = new Size(54, 28);
            label3.TabIndex = 21;
            label3.Text = "Time";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(192, 192, 255);
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(27, 110);
            label2.Name = "label2";
            label2.Size = new Size(105, 27);
            label2.TabIndex = 20;
            label2.Tag = "1";
            label2.Text = "Date";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(192, 192, 255);
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(379, 26);
            label1.Name = "label1";
            label1.Size = new Size(179, 38);
            label1.TabIndex = 19;
            label1.Text = "Appointment";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 192, 0);
            button1.Location = new Point(267, 381);
            button1.Name = "button1";
            button1.Size = new Size(106, 31);
            button1.TabIndex = 36;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Tomato;
            button2.Location = new Point(379, 378);
            button2.Name = "button2";
            button2.Size = new Size(96, 34);
            button2.TabIndex = 37;
            button2.Text = "Delect";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.LimeGreen;
            button3.Location = new Point(535, 108);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 38;
            button3.Text = "Search";
            button3.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(650, 110);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(263, 27);
            textBox1.TabIndex = 39;
            // 
            // patientGW
            // 
            patientGW.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            patientGW.Location = new Point(500, 160);
            patientGW.Name = "patientGW";
            patientGW.RowHeadersWidth = 51;
            patientGW.Size = new Size(541, 252);
            patientGW.TabIndex = 40;
            // 
            // EnterAppointmentDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(1053, 428);
            Controls.Add(patientGW);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(patient_IDTB);
            Controls.Add(label9);
            Controls.Add(saveDataBtn);
            Controls.Add(doctor_IDTB);
            Controls.Add(timeTB);
            Controls.Add(dateTB);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "EnterAppointmentDetails";
            Text = "EnterAppointmentDetails";
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
        private TextBox timeTB;
        private TextBox dateTB;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button2;
        private Button button1;
        private Button button3;
        private TextBox textBox1;
        private DataGridView patientGW;
    }
}