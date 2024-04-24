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
            ((System.ComponentModel.ISupportInitialize)appointmentGW).BeginInit();
            SuspendLayout();
            // 
            // appointmentGW
            // 
            appointmentGW.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            appointmentGW.Location = new Point(37, 29);
            appointmentGW.Name = "appointmentGW";
            appointmentGW.Size = new Size(1113, 546);
            appointmentGW.TabIndex = 0;
            // 
            // ShowAppointmentDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1174, 620);
            Controls.Add(appointmentGW);
            Name = "ShowAppointmentDetails";
            Text = "ShowAppointmentDetails";
            Load += ShowAppointmentDetails_Load;
            ((System.ComponentModel.ISupportInitialize)appointmentGW).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView appointmentGW;
    }
}