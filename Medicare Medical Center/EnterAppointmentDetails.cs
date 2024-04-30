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

namespace Medicare_Medical_Center
{
    public partial class EnterAppointmentDetails : Form
    {
        SqlConnection con;
        SqlCommand cm;
        string connectionString = "Data Source=Master;Initial Catalog=Medicare-Medical-Center-DB;Integrated Security=True;TrustServerCertificate=True";
        public EnterAppointmentDetails()
        {
            InitializeComponent();
            con = new SqlConnection(connectionString);
        }
        public void Clear()
        {
            dateTB.Clear();
            timeTB.Clear();
            patient_IDTB.Clear();
            doctor_IDTB.Clear();
        }

        private void saveDataBtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "INSERT INTO Appointment (Date, Time, Patient_ID, Doctor_ID) VALUES (@Date, @Time, @Patient_ID, @Doctor_ID)";
                cm = new SqlCommand(query, con);
                cm.Parameters.AddWithValue("@Date", dateTB.Text);
                cm.Parameters.AddWithValue("@Time", timeTB.Text);
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

        private void dateTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}

