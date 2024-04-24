namespace Medicare_Medical_Center
{
    partial class ShowTreatmentDetails
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
            treatmentGW = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)treatmentGW).BeginInit();
            SuspendLayout();
            // 
            // treatmentGW
            // 
            treatmentGW.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            treatmentGW.Location = new Point(53, 29);
            treatmentGW.Name = "treatmentGW";
            treatmentGW.Size = new Size(1042, 495);
            treatmentGW.TabIndex = 0;
            // 
            // ShowTreatmentDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1223, 590);
            Controls.Add(treatmentGW);
            Name = "ShowTreatmentDetails";
            Text = "ShowTreatmentDetails";
            Load += ShowTreatmentDetails_Load;
            ((System.ComponentModel.ISupportInitialize)treatmentGW).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView treatmentGW;
    }
}