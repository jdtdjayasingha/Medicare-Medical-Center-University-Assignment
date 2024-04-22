using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Medicare_Medical_Center
{
    public partial class ShowDoctorDetails : Form
    {
        SqlConnection con;
        SqlCommand cm;
        SqlDataAdapter da;
        DataTable dt;
        string connectionString = "Data Source=Master;Initial Catalog=Medicare-Medical-Center-DB;Integrated Security=True;TrustServerCertificate=True";

        public ShowDoctorDetails()
        {
            InitializeComponent();
            con = new SqlConnection(connectionString);
        }
        //private void Clear()
        //{
        //    firstNameTB.Clear();
        //    secondNameTB.Clear();
        //    emailTB.Clear();
        //    phoneNoTB.Clear();
        //    hospitalNameTB.Clear();
        //    specializationTB.Clear();
        //}

        private void RefreshDataGridView()
        {
            try
            {
                con.Open();
                string query = "SELECT * FROM Doctor";
                da = new SqlDataAdapter(query, con);
                dt = new DataTable();
                da.Fill(dt);
                doctorGW.DataSource = dt;
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


        private void ShowDoctorDetails_Load(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }
    }
}
