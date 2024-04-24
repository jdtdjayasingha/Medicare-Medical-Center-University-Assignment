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
            ((System.ComponentModel.ISupportInitialize)patientGW).BeginInit();
            SuspendLayout();
            // 
            // patientGW
            // 
            patientGW.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            patientGW.Location = new Point(12, 12);
            patientGW.Name = "patientGW";
            patientGW.Size = new Size(960, 265);
            patientGW.TabIndex = 0;
            // 
            // ShowPatientDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 561);
            Controls.Add(patientGW);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "ShowPatientDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += ShowPatientDetails_Load;
            ((System.ComponentModel.ISupportInitialize)patientGW).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView patientGW;
    }
}