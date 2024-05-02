namespace Medicare_Medical_Center
{
    partial class ShowDoctorDetails
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
            doctorGW = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)doctorGW).BeginInit();
            SuspendLayout();
            // 
            // doctorGW
            // 
            doctorGW.AllowUserToAddRows = false;
            doctorGW.AllowUserToDeleteRows = false;
            doctorGW.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            doctorGW.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            doctorGW.GridColor = Color.Gray;
            doctorGW.Location = new Point(11, 10);
            doctorGW.Margin = new Padding(2);
            doctorGW.Name = "doctorGW";
            doctorGW.ReadOnly = true;
            doctorGW.RowHeadersVisible = false;
            doctorGW.RowHeadersWidth = 51;
            doctorGW.Size = new Size(962, 540);
            doctorGW.TabIndex = 0;
            // 
            // ShowDoctorDetails
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 561);
            Controls.Add(doctorGW);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "ShowDoctorDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ShowDoctorDetails";
            Load += ShowDoctorDetails_Load;
            ((System.ComponentModel.ISupportInitialize)doctorGW).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView doctorGW;
    }
}