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
            addressTB.Location = new Point(645, 169);
            addressTB.Multiline = true;
            addressTB.Name = "addressTB";
            addressTB.Size = new Size(216, 160);
            addressTB.TabIndex = 36;
            // 
            // genderTB
            // 
            genderTB.Location = new Point(253, 226);
            genderTB.Name = "genderTB";
            genderTB.Size = new Size(216, 29);
            genderTB.TabIndex = 35;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(515, 172);
            label8.Name = "label8";
            label8.Size = new Size(66, 21);
            label8.TabIndex = 34;
            label8.Text = "Address";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(123, 226);
            label9.Name = "label9";
            label9.Size = new Size(61, 21);
            label9.TabIndex = 33;
            label9.Text = "Gender";
            // 
            // saveDataBtn
            // 
            saveDataBtn.Location = new Point(253, 490);
            saveDataBtn.Name = "saveDataBtn";
            saveDataBtn.Size = new Size(114, 36);
            saveDataBtn.TabIndex = 31;
            saveDataBtn.Text = "Save Data";
            saveDataBtn.UseVisualStyleBackColor = true;
            saveDataBtn.Click += saveDataBtn_Click;
            // 
            // statusTB
            // 
            statusTB.Location = new Point(253, 335);
            statusTB.Name = "statusTB";
            statusTB.Size = new Size(216, 29);
            statusTB.TabIndex = 30;
            // 
            // phoneNoTB
            // 
            phoneNoTB.Location = new Point(244, 385);
            phoneNoTB.Name = "phoneNoTB";
            phoneNoTB.Size = new Size(216, 29);
            phoneNoTB.TabIndex = 29;
            // 
            // ageTB
            // 
            ageTB.Location = new Point(253, 273);
            ageTB.Name = "ageTB";
            ageTB.Size = new Size(216, 29);
            ageTB.TabIndex = 28;
            // 
            // secondNameTB
            // 
            secondNameTB.Location = new Point(253, 172);
            secondNameTB.Name = "secondNameTB";
            secondNameTB.Size = new Size(216, 29);
            secondNameTB.TabIndex = 27;
            // 
            // firstNameTB
            // 
            firstNameTB.Location = new Point(253, 101);
            firstNameTB.Name = "firstNameTB";
            firstNameTB.Size = new Size(216, 29);
            firstNameTB.TabIndex = 26;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(123, 335);
            label6.Name = "label6";
            label6.Size = new Size(52, 21);
            label6.TabIndex = 24;
            label6.Text = "Status";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(114, 393);
            label5.Name = "label5";
            label5.Size = new Size(82, 21);
            label5.TabIndex = 23;
            label5.Text = "Phone_No";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(123, 281);
            label4.Name = "label4";
            label4.Size = new Size(37, 21);
            label4.TabIndex = 22;
            label4.Text = "Age";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(123, 175);
            label3.Name = "label3";
            label3.Size = new Size(107, 21);
            label3.TabIndex = 21;
            label3.Text = "Second_name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(123, 109);
            label2.Name = "label2";
            label2.Size = new Size(86, 21);
            label2.TabIndex = 20;
            label2.Text = "First_name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(429, 35);
            label1.Name = "label1";
            label1.Size = new Size(57, 21);
            label1.TabIndex = 19;
            label1.Text = "Patient";
            // 
            // EnterPatientDetails
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 561);
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