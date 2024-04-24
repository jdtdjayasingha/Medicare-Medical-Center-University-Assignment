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
    public partial class ShowTreatmentDetails : Form
    {
        SqlConnection con;
        SqlCommand cm;
        SqlDataAdapter da;
        DataTable dt;
        string connectionString = "Data Source=Master;Initial Catalog=Medicare-Medical-Center-DB;Integrated Security=True;TrustServerCertificate=True";

        public ShowTreatmentDetails()
        {
            InitializeComponent();
            con = new SqlConnection(connectionString);
        }

        private void RefreshDataGridView()
        {
            try
            {
                con.Open();
                string query = "SELECT * FROM Treatment";
                da = new SqlDataAdapter(query, con);
                dt = new DataTable();
                da.Fill(dt);
                treatmentGW.DataSource = dt;
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
        private void ShowTreatmentDetails_Load(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }
    }
}
