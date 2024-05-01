namespace Medicare_Medical_Center
{
    partial class ShowAppointmentDetails
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
            appointmentGW = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            textBox6 = new TextBox();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)appointmentGW).BeginInit();
            SuspendLayout();
            // 
            // appointmentGW
            // 
            appointmentGW.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            appointmentGW.Location = new Point(563, 219);
            appointmentGW.Margin = new Padding(3, 4, 3, 4);
            appointmentGW.Name = "appointmentGW";
            appointmentGW.RowHeadersWidth = 51;
            appointmentGW.Size = new Size(484, 443);
            appointmentGW.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(385, 28);
            label1.Name = "label1";
            label1.Size = new Size(271, 38);
            label1.TabIndex = 1;
            label1.Text = "Appointment Details";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(11, 157);
            label2.Name = "label2";
            label2.Size = new Size(193, 28);
            label2.TabIndex = 2;
            label2.Text = "Enter appoinment ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(11, 211);
            label3.Name = "label3";
            label3.Size = new Size(242, 28);
            label3.TabIndex = 3;
            label3.Text = "Enter appoinment number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 272);
            label4.Name = "label4";
            label4.Size = new Size(213, 28);
            label4.TabIndex = 4;
            label4.Text = "Enter appoinment time";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(11, 321);
            label5.Name = "label5";
            label5.Size = new Size(96, 28);
            label5.TabIndex = 5;
            label5.Text = "Patient ID";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 381);
            label6.Name = "label6";
            label6.Size = new Size(97, 28);
            label6.TabIndex = 6;
            label6.Text = "Doctor ID";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(259, 162);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(195, 27);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(259, 215);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(195, 27);
            textBox2.TabIndex = 8;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(259, 272);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(195, 27);
            textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(259, 321);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(195, 27);
            textBox4.TabIndex = 10;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(259, 385);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(195, 27);
            textBox5.TabIndex = 11;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 192, 0);
            button1.Location = new Point(227, 484);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 12;
            button1.Text = "Insert";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.CornflowerBlue;
            button2.Location = new Point(328, 484);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 13;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Tomato;
            button3.Location = new Point(428, 484);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 14;
            button3.Text = "Delect";
            button3.UseVisualStyleBackColor = false;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(563, 157);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(237, 27);
            textBox6.TabIndex = 15;
            // 
            // button4
            // 
            button4.BackColor = Color.LimeGreen;
            button4.Location = new Point(826, 157);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 16;
            button4.Text = "Search";
            button4.UseVisualStyleBackColor = false;
            // 
            // ShowAppointmentDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(1059, 675);
            Controls.Add(button4);
            Controls.Add(textBox6);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(appointmentGW);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ShowAppointmentDetails";
            Text = "ShowAppointmentDetails";
            Load += ShowAppointmentDetails_Load;
            ((System.ComponentModel.ISupportInitialize)appointmentGW).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView appointmentGW;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox textBox6;
        private Button button4;
    }
}