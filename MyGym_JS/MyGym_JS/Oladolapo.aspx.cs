using System;using System.Data;using System.Data.SqlClient;using System.Configuration;using System.Web.UI.WebControls;

namespace MyGym_JS{    public partial class Oladolapo : System.Web.UI.Page    {        string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;        protected void Page_Load(object sender, EventArgs e)        {
           
        }        protected void Button1_Click(object sender, EventArgs e)        {

            using (SqlConnection con = new SqlConnection(connectionString))            {                con.Open();                string query = "INSERT INTO detailsOO (FirstName, LastName, Age, Weight, ActivityType) VALUES (@FirstName, @LastName, @Age, @Weight, @ActivityType)";                using (SqlCommand cmd = new SqlCommand(query, con))                {                    cmd.Parameters.AddWithValue("@FirstName", FirstName.Text);                    cmd.Parameters.AddWithValue("@LastName", LastName.Text);                    cmd.Parameters.AddWithValue("@Age", Int16.Parse(Age.Text));                    cmd.Parameters.AddWithValue("@Weight", float.Parse(Weight.Text));                    cmd.Parameters.AddWithValue("@ActivityType", ActivityType.Text);                    cmd.ExecuteNonQuery();                }                Label1.Text = "Data has been added successfully";                GridView1.DataBind();                FirstName.Text = "";                LastName.Text = "";                Age.Text = "";                Weight.Text = "";                ActivityType.Text = "";

               
            }        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }}