using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-9NQ1TKD;Initial Catalog=user;User ID=sa;Password=12345";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string name = txtName.Text;
                string email = txtEmail.Text;
                string addresse = Textadd.Text;
                string contact = Textcontact.Text;
                string password = txtPassword.Text;

                string query = "INSERT INTO user5 (name, email, addresse, contact, password) VALUES (@name, @email, @addresse, @contact, @password)";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@addresse", addresse);
                    cmd.Parameters.AddWithValue("@contact", contact);
                    cmd.Parameters.AddWithValue("@password", password);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        Label1.Text = "Record Inserted Successfully";
                        Response.Redirect("./signin.aspx");
                    }
                    else
                    {
                        Label1.Text = "Failed to insert the record";
                    }
                }
            }
        }
    }
}