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
            label2 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)patientGW).BeginInit();
            SuspendLayout();
            // 
            // patientGW
            // 
            patientGW.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            patientGW.Location = new Point(26, 307);
            patientGW.Name = "patientGW";
            patientGW.RowHeadersWidth = 51;
            patientGW.Size = new Size(946, 242);
            patientGW.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(435, 30);
            label1.Name = "label1";
            label1.Size = new Size(161, 31);
            label1.TabIndex = 1;
            label1.Text = "Patient Details";
            // 
            // Enter_Patient_ID
            // 
            Enter_Patient_ID.AutoSize = true;
            Enter_Patient_ID.Location = new Point(63, 84);
            Enter_Patient_ID.Name = "Enter_Patient_ID";
            Enter_Patient_ID.Size = new Size(134, 23);
            Enter_Patient_ID.TabIndex = 2;
            Enter_Patient_ID.Text = "Enter_Patient_ID";
            Enter_Patient_ID.Click += Enter_Patient_ID_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.AliceBlue;
            textBox1.Location = new Point(240, 84);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(175, 29);
            textBox1.TabIndex = 3;
            // 
            // Update
            // 
            Update.BackColor = Color.FromArgb(0, 192, 0);
            Update.Location = new Point(240, 136);
            Update.Name = "Update";
            Update.Size = new Size(94, 29);
            Update.TabIndex = 4;
            Update.Text = "Update";
            Update.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Tomato;
            button1.Location = new Point(351, 136);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 5;
            button1.Text = "Delect";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.CornflowerBlue;
            button2.Location = new Point(467, 136);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 6;
            button2.Text = "Insert";
            button2.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Blue;
            label2.Location = new Point(440, 213);
            label2.Name = "label2";
            label2.Size = new Size(121, 28);
            label2.TabIndex = 7;
            label2.Text = "View_Patient";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(63, 261);
            label3.Name = "label3";
            label3.Size = new Size(121, 23);
            label3.TabIndex = 8;
            label3.Text = "Search_Patient";
            label3.Click += label3_Click;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.AliceBlue;
            textBox2.Location = new Point(240, 258);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(175, 29);
            textBox2.TabIndex = 9;
            // 
            // ShowPatientDetails
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(990, 566);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(label2);
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
        private Label label2;
        private Label label3;
        private TextBox textBox2;
    }
}