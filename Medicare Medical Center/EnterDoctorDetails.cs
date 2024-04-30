using System.Data.SqlClient;

namespace Medicare_Medical_Center
{
    public partial class EnterDoctorDetails : Form
    {
        SqlConnection con;
        SqlCommand cm;
        string connectionString = "Data Source=Master;Initial Catalog=Medicare-Medical-Center-DB;Integrated Security=True;TrustServerCertificate=True";
        public EnterDoctorDetails()
        {
            InitializeComponent();
            con = new SqlConnection(connectionString);
        }
        public void Clear()
        {
            firstNameTB.Clear();
            secondNameTB.Clear();
            genderTB.Clear();
            emailTB.Clear();
            phoneNoTB.Clear();
            hospitalNameTB.Clear();
            specializationTB.Clear();
            descriptionTB.Clear();
        }
        private void saveDataBtn_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "INSERT INTO Doctor (First_Name, Second_Name, Gender, Email, Phone_No, Hospital_Name, Specialization, Description) VALUES (@First_Name, @Second_Name, @Gender, @Email, @Phone_No, @Hospital_Name, @Specialization, @Description)";
                cm = new SqlCommand(query, con);
                cm.Parameters.AddWithValue("@First_Name", firstNameTB.Text);
                cm.Parameters.AddWithValue("@Second_Name", secondNameTB.Text);
                cm.Parameters.AddWithValue("@Gender", genderTB.Text);
                cm.Parameters.AddWithValue("@Email", emailTB.Text);
                cm.Parameters.AddWithValue("@Phone_No", phoneNoTB.Text);
                cm.Parameters.AddWithValue("@Hospital_Name", hospitalNameTB.Text);
                cm.Parameters.AddWithValue("@Specialization", specializationTB.Text);
                cm.Parameters.AddWithValue("@Description", descriptionTB.Text);
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

        private void firstNameTB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
