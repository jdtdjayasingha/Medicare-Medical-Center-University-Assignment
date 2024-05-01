using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Medicare_Medical_Center
{
    public partial class EnterTreatmentDetails : Form
    {
        SqlConnection con;
        SqlCommand cm;
        string connectionString = "Data Source=Master;Initial Catalog=Medicare-Medical-Center-DB;Integrated Security=True;TrustServerCertificate=True";
        public EnterTreatmentDetails()
        {
            InitializeComponent();
            con = new SqlConnection(connectionString);
        }
        public void Clear()
        {
            descriptionTB.Clear();
            dateTB.Clear();
            patient_IDTB.Clear();
            doctor_IDTB.Clear();
        }
        private void saveDataBtn_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "INSERT INTO Treatment (Description, Date, Patient_ID, Doctor_ID) VALUES (@Description, @Date, @Patient_ID, @Doctor_ID)";
                cm = new SqlCommand(query, con);
                cm.Parameters.AddWithValue("@Description", descriptionTB.Text);
                cm.Parameters.AddWithValue("@Date", dateTB.Text);
                cm.Parameters.AddWithValue("@Patient_ID", patient_IDTB.Text);
                cm.Parameters.AddWithValue("@Doctor_ID", doctor_IDTB.Text);
                cm.ExecuteNonQuery();
                MessageBox.Show("Data saved successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
                Clear();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Treatment_Click(object sender, EventArgs e)
        {

        }
    }
}


