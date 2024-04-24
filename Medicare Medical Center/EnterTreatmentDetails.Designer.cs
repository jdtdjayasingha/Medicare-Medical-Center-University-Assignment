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
            patient_IDTB.Location = new Point(295, 299);
            patient_IDTB.Name = "patient_IDTB";
            patient_IDTB.Size = new Size(216, 25);
            patient_IDTB.TabIndex = 45;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(165, 299);
            label9.Name = "label9";
            label9.Size = new Size(63, 17);
            label9.TabIndex = 44;
            label9.Text = "Patient ID";
            // 
            // saveDataBtn
            // 
            saveDataBtn.Location = new Point(295, 406);
            saveDataBtn.Name = "saveDataBtn";
            saveDataBtn.Size = new Size(114, 36);
            saveDataBtn.TabIndex = 43;
            saveDataBtn.Text = "Save Data";
            saveDataBtn.UseVisualStyleBackColor = true;
            saveDataBtn.Click += saveDataBtn_Click;
            // 
            // doctor_IDTB
            // 
            doctor_IDTB.Location = new Point(295, 346);
            doctor_IDTB.Name = "doctor_IDTB";
            doctor_IDTB.Size = new Size(216, 25);
            doctor_IDTB.TabIndex = 42;
            // 
            // dateTB
            // 
            dateTB.Location = new Point(295, 245);
            dateTB.Name = "dateTB";
            dateTB.Size = new Size(216, 25);
            dateTB.TabIndex = 41;
            // 
            // descriptionTB
            // 
            descriptionTB.Location = new Point(295, 174);
            descriptionTB.Name = "descriptionTB";
            descriptionTB.Size = new Size(216, 25);
            descriptionTB.TabIndex = 40;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(165, 354);
            label4.Name = "label4";
            label4.Size = new Size(64, 17);
            label4.TabIndex = 39;
            label4.Text = "Doctor ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(165, 248);
            label3.Name = "label3";
            label3.Size = new Size(35, 17);
            label3.TabIndex = 38;
            label3.Text = "Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(165, 182);
            label2.Name = "label2";
            label2.Size = new Size(74, 17);
            label2.TabIndex = 37;
            label2.Text = "Description";
            // 
            // Treatment
            // 
            Treatment.AutoSize = true;
            Treatment.Location = new Point(471, 108);
            Treatment.Name = "Treatment";
            Treatment.Size = new Size(66, 17);
            Treatment.TabIndex = 36;
            Treatment.Text = "Treatment";
            // 
            // EnterTreatmentDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1073, 614);
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
            Name = "EnterTreatmentDetails";
            Text = "EnterTreatmentDetails";
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
        private TextBox dateTB;
        private TextBox descriptionTB;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label Treatment;
    }
}