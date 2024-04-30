﻿namespace Medicare_Medical_Center
{
    partial class EnterDoctorDetails
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            firstNameTB = new TextBox();
            secondNameTB = new TextBox();
            emailTB = new TextBox();
            phoneNoTB = new TextBox();
            hospitalNameTB = new TextBox();
            saveDataBtn = new Button();
            specializationTB = new TextBox();
            descriptionTB = new TextBox();
            genderTB = new TextBox();
            label8 = new Label();
            label9 = new Label();
            fileSystemWatcher1 = new FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 0, 192);
            label1.Location = new Point(454, 27);
            label1.Name = "label1";
            label1.Size = new Size(101, 38);
            label1.TabIndex = 0;
            label1.Text = "Doctor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(98, 102);
            label2.Name = "label2";
            label2.Size = new Size(105, 28);
            label2.TabIndex = 1;
            label2.Text = "First_name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(98, 165);
            label3.Name = "label3";
            label3.Size = new Size(133, 28);
            label3.TabIndex = 2;
            label3.Text = "Second_name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(98, 272);
            label4.Name = "label4";
            label4.Size = new Size(59, 28);
            label4.TabIndex = 3;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(98, 337);
            label5.Name = "label5";
            label5.Size = new Size(102, 28);
            label5.TabIndex = 4;
            label5.Text = "Phone_No";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(98, 394);
            label6.Name = "label6";
            label6.Size = new Size(142, 28);
            label6.TabIndex = 5;
            label6.Text = "Hospital Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(536, 102);
            label7.Name = "label7";
            label7.Size = new Size(133, 28);
            label7.TabIndex = 6;
            label7.Text = "Specialization";
            // 
            // firstNameTB
            // 
            firstNameTB.BackColor = Color.AliceBlue;
            firstNameTB.Location = new Point(274, 102);
            firstNameTB.Name = "firstNameTB";
            firstNameTB.Size = new Size(216, 34);
            firstNameTB.TabIndex = 7;
            firstNameTB.TextChanged += firstNameTB_TextChanged;
            // 
            // secondNameTB
            // 
            secondNameTB.BackColor = Color.AliceBlue;
            secondNameTB.Location = new Point(274, 165);
            secondNameTB.Name = "secondNameTB";
            secondNameTB.Size = new Size(216, 34);
            secondNameTB.TabIndex = 8;
            // 
            // emailTB
            // 
            emailTB.BackColor = Color.AliceBlue;
            emailTB.Location = new Point(274, 272);
            emailTB.Name = "emailTB";
            emailTB.Size = new Size(216, 34);
            emailTB.TabIndex = 9;
            // 
            // phoneNoTB
            // 
            phoneNoTB.BackColor = Color.AliceBlue;
            phoneNoTB.Location = new Point(274, 334);
            phoneNoTB.Name = "phoneNoTB";
            phoneNoTB.Size = new Size(216, 34);
            phoneNoTB.TabIndex = 10;
            // 
            // hospitalNameTB
            // 
            hospitalNameTB.BackColor = Color.AliceBlue;
            hospitalNameTB.Location = new Point(274, 394);
            hospitalNameTB.Name = "hospitalNameTB";
            hospitalNameTB.Size = new Size(216, 34);
            hospitalNameTB.TabIndex = 11;
            // 
            // saveDataBtn
            // 
            saveDataBtn.Location = new Point(503, 487);
            saveDataBtn.Name = "saveDataBtn";
            saveDataBtn.Size = new Size(114, 36);
            saveDataBtn.TabIndex = 13;
            saveDataBtn.Text = "Save Data";
            saveDataBtn.UseVisualStyleBackColor = true;
            saveDataBtn.Click += saveDataBtn_Click;
            // 
            // specializationTB
            // 
            specializationTB.BackColor = Color.AliceBlue;
            specializationTB.Location = new Point(700, 102);
            specializationTB.Name = "specializationTB";
            specializationTB.Size = new Size(216, 34);
            specializationTB.TabIndex = 14;
            // 
            // descriptionTB
            // 
            descriptionTB.BackColor = Color.AliceBlue;
            descriptionTB.Location = new Point(700, 165);
            descriptionTB.Multiline = true;
            descriptionTB.Name = "descriptionTB";
            descriptionTB.Size = new Size(216, 160);
            descriptionTB.TabIndex = 18;
            // 
            // genderTB
            // 
            genderTB.BackColor = Color.AliceBlue;
            genderTB.Location = new Point(274, 219);
            genderTB.Name = "genderTB";
            genderTB.Size = new Size(216, 34);
            genderTB.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(536, 165);
            label8.Name = "label8";
            label8.Size = new Size(112, 28);
            label8.TabIndex = 16;
            label8.Text = "Description";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(98, 219);
            label9.Name = "label9";
            label9.Size = new Size(76, 28);
            label9.TabIndex = 15;
            label9.Text = "Gender";
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // EnterDoctorDetails
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(984, 561);
            Controls.Add(descriptionTB);
            Controls.Add(genderTB);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(specializationTB);
            Controls.Add(saveDataBtn);
            Controls.Add(hospitalNameTB);
            Controls.Add(phoneNoTB);
            Controls.Add(emailTB);
            Controls.Add(secondNameTB);
            Controls.Add(firstNameTB);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "EnterDoctorDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox firstNameTB;
        private TextBox secondNameTB;
        private TextBox emailTB;
        private TextBox phoneNoTB;
        private TextBox hospitalNameTB;
        private Button saveDataBtn;
        private TextBox specializationTB;
        private TextBox descriptionTB;
        private TextBox genderTB;
        private Label label8;
        private Label label9;
        private FileSystemWatcher fileSystemWatcher1;
    }
}
