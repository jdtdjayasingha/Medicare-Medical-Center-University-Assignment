namespace Medicare_Medical_Center
{
    partial class ShowPatientDetails
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
            patientGW = new DataGridView();
            label1 = new Label();
            Enter_Patient_ID = new Label();
            textBox1 = new TextBox();
            Update = new Button();
            button1 = new Button();
            button2 = new Button();
            textBox2 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)patientGW).BeginInit();
            SuspendLayout();
            // 
            // patientGW
            // 
            patientGW.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            patientGW.Location = new Point(503, 165);
            patientGW.Name = "patientGW";
            patientGW.RowHeadersWidth = 51;
            patientGW.Size = new Size(571, 306);
            patientGW.TabIndex = 0;
            patientGW.CellContentClick += patientGW_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(440, 22);
            label1.Name = "label1";
            label1.Size = new Size(194, 38);
            label1.TabIndex = 1;
            label1.Text = "Patient Details";
            // 
            // Enter_Patient_ID
            // 
            Enter_Patient_ID.AutoSize = true;
            Enter_Patient_ID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Enter_Patient_ID.Location = new Point(12, 84);
            Enter_Patient_ID.Name = "Enter_Patient_ID";
            Enter_Patient_ID.Size = new Size(152, 28);
            Enter_Patient_ID.TabIndex = 2;
            Enter_Patient_ID.Text = "Enter_Patient_ID";
            Enter_Patient_ID.Click += Enter_Patient_ID_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.AliceBlue;
            textBox1.Location = new Point(178, 84);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(178, 29);
            textBox1.TabIndex = 3;
            // 
            // Update
            // 
            Update.BackColor = Color.FromArgb(0, 192, 0);
            Update.Location = new Point(278, 442);
            Update.Name = "Update";
            Update.Size = new Size(94, 29);
            Update.TabIndex = 4;
            Update.Text = "Update";
            Update.UseVisualStyleBackColor = false;
            Update.Click += Update_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Tomato;
            button1.Location = new Point(378, 442);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 5;
            button1.Text = "Delect";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.CornflowerBlue;
            button2.Location = new Point(178, 442);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 6;
            button2.Text = "Insert";
            button2.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.AliceBlue;
            textBox2.Location = new Point(643, 85);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(184, 29);
            textBox2.TabIndex = 9;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 136);
            label4.Name = "label4";
            label4.Size = new Size(106, 28);
            label4.TabIndex = 10;
            label4.Text = "First Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 184);
            label5.Name = "label5";
            label5.Size = new Size(134, 28);
            label5.TabIndex = 11;
            label5.Text = "Second Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 233);
            label6.Name = "label6";
            label6.Size = new Size(144, 28);
            label6.TabIndex = 12;
            label6.Text = "Patient address";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(12, 287);
            label7.Name = "label7";
            label7.Size = new Size(47, 28);
            label7.TabIndex = 13;
            label7.Text = "Age";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(12, 331);
            label8.Name = "label8";
            label8.Size = new Size(76, 28);
            label8.TabIndex = 14;
            label8.Text = "Gender";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(12, 378);
            label9.Name = "label9";
            label9.Size = new Size(65, 28);
            label9.TabIndex = 15;
            label9.Text = "Status";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(178, 129);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(178, 29);
            textBox3.TabIndex = 16;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(178, 181);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(178, 29);
            textBox4.TabIndex = 17;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(178, 233);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(178, 29);
            textBox5.TabIndex = 18;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(178, 287);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(178, 29);
            textBox6.TabIndex = 19;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(178, 331);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(178, 29);
            textBox7.TabIndex = 20;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(178, 378);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(178, 29);
            textBox8.TabIndex = 21;
            // 
            // button3
            // 
            button3.BackColor = Color.LimeGreen;
            button3.Location = new Point(525, 84);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 22;
            button3.Text = "Search";
            button3.UseVisualStyleBackColor = false;
            // 
            // ShowPatientDetails
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(1086, 497);
            Controls.Add(button3);
            Controls.Add(textBox8);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(Update);
            Controls.Add(textBox1);
            Controls.Add(Enter_Patient_ID);
            Controls.Add(label1);
            Controls.Add(patientGW);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "ShowPatientDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += ShowPatientDetails_Load;
            ((System.ComponentModel.ISupportInitialize)patientGW).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView patientGW;
        private Label label1;
        private Label Enter_Patient_ID;
        private TextBox textBox1;
        private Button Update;
        private Button button1;
        private Button button2;
        private TextBox textBox2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private Button button3;
    }
}