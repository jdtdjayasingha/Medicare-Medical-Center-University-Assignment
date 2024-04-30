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
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
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
            patient_IDTB.Location = new Point(343, 302);
            patient_IDTB.Margin = new Padding(3, 4, 3, 4);
            patient_IDTB.Name = "patient_IDTB";
            patient_IDTB.Size = new Size(229, 27);
            patient_IDTB.TabIndex = 35;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.FromArgb(192, 192, 255);
            label9.Location = new Point(194, 302);
            label9.Name = "label9";
            label9.Size = new Size(73, 20);
            label9.TabIndex = 33;
            label9.Text = "Patient ID";
            // 
            // saveDataBtn
            // 
            saveDataBtn.BackColor = SystemColors.Control;
            saveDataBtn.Location = new Point(379, 416);
            saveDataBtn.Margin = new Padding(3, 4, 3, 4);
            saveDataBtn.Name = "saveDataBtn";
            saveDataBtn.Size = new Size(130, 42);
            saveDataBtn.TabIndex = 31;
            saveDataBtn.Text = "Save Data";
            saveDataBtn.UseVisualStyleBackColor = false;
            saveDataBtn.Click += saveDataBtn_Click_1;
            // 
            // doctor_IDTB
            // 
            doctor_IDTB.BackColor = Color.AliceBlue;
            doctor_IDTB.Location = new Point(343, 358);
            doctor_IDTB.Margin = new Padding(3, 4, 3, 4);
            doctor_IDTB.Name = "doctor_IDTB";
            doctor_IDTB.Size = new Size(229, 27);
            doctor_IDTB.TabIndex = 28;
            // 
            // timeTB
            // 
            timeTB.BackColor = Color.AliceBlue;
            timeTB.Location = new Point(343, 239);
            timeTB.Margin = new Padding(3, 4, 3, 4);
            timeTB.Name = "timeTB";
            timeTB.Size = new Size(229, 27);
            timeTB.TabIndex = 27;
            // 
            // dateTB
            // 
            dateTB.BackColor = Color.AliceBlue;
            dateTB.Location = new Point(343, 165);
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
            label4.Location = new Point(194, 367);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 22;
            label4.Text = "Doctor ID";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(192, 192, 255);
            label3.Location = new Point(194, 242);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 21;
            label3.Text = "Time";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(192, 192, 255);
            label2.Location = new Point(194, 165);
            label2.Name = "label2";
            label2.Size = new Size(105, 27);
            label2.TabIndex = 20;
            label2.Text = "Date";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(192, 192, 255);
            label1.Location = new Point(412, 78);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 19;
            label1.Text = "Appointment";
            // 
            // EnterAppointmentDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(846, 554);
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
    }
}