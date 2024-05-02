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
    public partial class EnterPatientDetails : Form
    {
        SqlConnection con;
        SqlCommand cm;
        string connectionString = "Data Source=Master;Initial Catalog=Medicare-Medical-Center-DB;Integrated Security=True;TrustServerCertificate=True";
        public EnterPatientDetails()
        {
            InitializeComponent();
            con = new SqlConnection(connectionString);
        }
        public void Clear()
        {
            firstNameTB.Clear();
            secondNameTB.Clear();
            genderTB.Clear();
            ageTB.Clear();
            statusTB.Clear();
            phoneNoTB.Clear();
            addressTB.Clear();
        }

        private void saveDataBtn_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "INSERT INTO Patient (First_Name, Second_Name, Gender, Age, Status, Phone_No,  Address) VALUES (@First_Name, @Second_Name, @Gender, @Age, @Status, @Phone_No, @Address)";
                cm = new SqlCommand(query, con);
                cm.Parameters.AddWithValue("@First_Name", firstNameTB.Text);
                cm.Parameters.AddWithValue("@Second_Name", secondNameTB.Text);
                cm.Parameters.AddWithValue("@Gender", genderTB.Text);
                cm.Parameters.AddWithValue("@Age", ageTB.Text);
                cm.Parameters.AddWithValue("@Phone_No", phoneNoTB.Text);
                cm.Parameters.AddWithValue("@Status", statusTB.Text);
                cm.Parameters.AddWithValue("@Address", addressTB.Text);
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

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void EnterPatientDetails_Load(object sender, EventArgs e)
        {

        }
    }
}


