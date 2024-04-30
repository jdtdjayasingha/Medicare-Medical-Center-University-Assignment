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
    public partial class ShowPatientDetails : Form
    {
        SqlConnection con;
        SqlCommand cm;
        SqlDataAdapter da;
        DataTable dt;
        string connectionString = "Data Source=Master;Initial Catalog=Medicare-Medical-Center-DB;Integrated Security=True;TrustServerCertificate=True";

        public ShowPatientDetails()
        {
            InitializeComponent();
            con = new SqlConnection(connectionString);
        }

        private void RefreshDataGridView()
        {
            try
            {
                con.Open();
                string query = "SELECT * FROM patient";
                da = new SqlDataAdapter(query, con);
                dt = new DataTable();
                da.Fill(dt);
                patientGW.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        private void ShowPatientDetails_Load(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }

        private void Enter_Patient_ID_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

