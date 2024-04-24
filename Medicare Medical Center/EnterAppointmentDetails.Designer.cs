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
            patient_IDTB.Location = new Point(300, 257);
            patient_IDTB.Name = "patient_IDTB";
            patient_IDTB.Size = new Size(216, 25);
            patient_IDTB.TabIndex = 35;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(170, 257);
            label9.Name = "label9";
            label9.Size = new Size(63, 17);
            label9.TabIndex = 33;
            label9.Text = "Patient ID";
            // 
            // saveDataBtn
            // 
            saveDataBtn.Location = new Point(300, 364);
            saveDataBtn.Name = "saveDataBtn";
            saveDataBtn.Size = new Size(114, 36);
            saveDataBtn.TabIndex = 31;
            saveDataBtn.Text = "Save Data";
            saveDataBtn.UseVisualStyleBackColor = true;
            saveDataBtn.Click += saveDataBtn_Click_1;
            // 
            // doctor_IDTB
            // 
            doctor_IDTB.Location = new Point(300, 304);
            doctor_IDTB.Name = "doctor_IDTB";
            doctor_IDTB.Size = new Size(216, 25);
            doctor_IDTB.TabIndex = 28;
            // 
            // timeTB
            // 
            timeTB.Location = new Point(300, 203);
            timeTB.Name = "timeTB";
            timeTB.Size = new Size(216, 25);
            timeTB.TabIndex = 27;
            // 
            // dateTB
            // 
            dateTB.Location = new Point(300, 132);
            dateTB.Name = "dateTB";
            dateTB.Size = new Size(216, 25);
            dateTB.TabIndex = 26;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(170, 312);
            label4.Name = "label4";
            label4.Size = new Size(64, 17);
            label4.TabIndex = 22;
            label4.Text = "Doctor ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(170, 206);
            label3.Name = "label3";
            label3.Size = new Size(36, 17);
            label3.TabIndex = 21;
            label3.Text = "Time";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(170, 140);
            label2.Name = "label2";
            label2.Size = new Size(35, 17);
            label2.TabIndex = 20;
            label2.Text = "Date";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(476, 66);
            label1.Name = "label1";
            label1.Size = new Size(83, 17);
            label1.TabIndex = 19;
            label1.Text = "Appointment";
            // 
            // EnterAppointmentDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1079, 623);
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