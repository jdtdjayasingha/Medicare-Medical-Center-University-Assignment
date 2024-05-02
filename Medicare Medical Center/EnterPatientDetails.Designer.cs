namespace Medicare_Medical_Center
{
    partial class EnterPatientDetails
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
            addressTB = new TextBox();
            genderTB = new TextBox();
            label8 = new Label();
            label9 = new Label();
            saveDataBtn = new Button();
            statusTB = new TextBox();
            phoneNoTB = new TextBox();
            ageTB = new TextBox();
            secondNameTB = new TextBox();
            firstNameTB = new TextBox();
            label6 = new Label();
            label5 = new Label();
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
            // addressTB
            // 
            addressTB.BackColor = Color.AliceBlue;
            addressTB.Location = new Point(691, 97);
            addressTB.Multiline = true;
            addressTB.Name = "addressTB";
            addressTB.Size = new Size(216, 160);
            addressTB.TabIndex = 36;
            // 
            // genderTB
            // 
            genderTB.BackColor = Color.AliceBlue;
            genderTB.Location = new Point(264, 226);
            genderTB.Name = "genderTB";
            genderTB.Size = new Size(216, 34);
            genderTB.TabIndex = 35;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(572, 100);
            label8.Name = "label8";
            label8.Size = new Size(82, 28);
            label8.TabIndex = 34;
            label8.Text = "Address";
            label8.Click += label8_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(123, 229);
            label9.Name = "label9";
            label9.Size = new Size(76, 28);
            label9.TabIndex = 33;
            label9.Text = "Gender";
            // 
            // saveDataBtn
            // 
            saveDataBtn.BackColor = SystemColors.Control;
            saveDataBtn.BackgroundImageLayout = ImageLayout.Center;
            saveDataBtn.Location = new Point(523, 485);
            saveDataBtn.Name = "saveDataBtn";
            saveDataBtn.Size = new Size(114, 36);
            saveDataBtn.TabIndex = 31;
            saveDataBtn.Text = "Save Data";
            saveDataBtn.UseVisualStyleBackColor = false;
            saveDataBtn.Click += saveDataBtn_Click;
            // 
            // statusTB
            // 
            statusTB.BackColor = Color.AliceBlue;
            statusTB.Location = new Point(264, 335);
            statusTB.Name = "statusTB";
            statusTB.Size = new Size(216, 34);
            statusTB.TabIndex = 30;
            // 
            // phoneNoTB
            // 
            phoneNoTB.BackColor = Color.AliceBlue;
            phoneNoTB.Location = new Point(264, 387);
            phoneNoTB.Name = "phoneNoTB";
            phoneNoTB.Size = new Size(216, 34);
            phoneNoTB.TabIndex = 29;
            // 
            // ageTB
            // 
            ageTB.BackColor = Color.AliceBlue;
            ageTB.Location = new Point(264, 275);
            ageTB.Name = "ageTB";
            ageTB.Size = new Size(216, 34);
            ageTB.TabIndex = 28;
            // 
            // secondNameTB
            // 
            secondNameTB.BackColor = Color.AliceBlue;
            secondNameTB.Location = new Point(264, 169);
            secondNameTB.Name = "secondNameTB";
            secondNameTB.Size = new Size(216, 34);
            secondNameTB.TabIndex = 27;
            // 
            // firstNameTB
            // 
            firstNameTB.BackColor = Color.AliceBlue;
            firstNameTB.Location = new Point(264, 100);
            firstNameTB.Name = "firstNameTB";
            firstNameTB.Size = new Size(216, 34);
            firstNameTB.TabIndex = 26;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(123, 341);
            label6.Name = "label6";
            label6.Size = new Size(65, 28);
            label6.TabIndex = 24;
            label6.Text = "Status";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(123, 393);
            label5.Name = "label5";
            label5.Size = new Size(102, 28);
            label5.TabIndex = 23;
            label5.Text = "Phone_No";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(123, 281);
            label4.Name = "label4";
            label4.Size = new Size(47, 28);
            label4.TabIndex = 22;
            label4.Text = "Age";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(123, 172);
            label3.Name = "label3";
            label3.Size = new Size(133, 28);
            label3.TabIndex = 21;
            label3.Text = "Second_name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(123, 103);
            label2.Name = "label2";
            label2.Size = new Size(105, 28);
            label2.TabIndex = 20;
            label2.Text = "First_name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 0, 64);
            label1.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            label1.Location = new Point(466, 23);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(102, 38);
            label1.TabIndex = 19;
            label1.Text = "Patient";
            // 
            // EnterPatientDetails
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(984, 551);
            Controls.Add(addressTB);
            Controls.Add(genderTB);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(saveDataBtn);
            Controls.Add(statusTB);
            Controls.Add(phoneNoTB);
            Controls.Add(ageTB);
            Controls.Add(secondNameTB);
            Controls.Add(firstNameTB);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "EnterPatientDetails";
            Text = "Patient";
            Load += EnterPatientDetails_Load;
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FileSystemWatcher fileSystemWatcher1;
        private TextBox addressTB;
        private TextBox genderTB;
        private Label label8;
        private Label label9;
        private Button saveDataBtn;
        private TextBox statusTB;
        private TextBox phoneNoTB;
        private TextBox ageTB;
        private TextBox secondNameTB;
        private TextBox firstNameTB;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}