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
    public partial class signin : System.Web.UI.Page
    {
        SqlCommand cmd = new SqlCommand();
        SqlConnection con = new SqlConnection();
        SqlDataAdapter ada = new SqlDataAdapter();
        DataSet ds = new DataSet();
        protected void Page_Load(object sender, EventArgs e)
        {
            con.ConnectionString = ("Data Source=DESKTOP-9NQ1TKD;Initial Catalog=user;User ID=sa;Password=12345");
            con.Open();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter ada = new SqlDataAdapter();
            DataSet ds = new DataSet();

            string enteredUsername = txtUserName.Text;
            string enteredPassword = txtPassword.Text;

            cmd.CommandText = "SELECT * FROM user5 WHERE name=@name AND password=@password";
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@name", enteredUsername);
            cmd.Parameters.AddWithValue("@password", enteredPassword);

            ada.SelectCommand = cmd;
            ada.Fill(ds, "user");
            if(enteredUsername=="admin" && enteredPassword =="2829")
            {
                Label1.Text = "admin Successful";
                Response.Redirect("./admin.aspx");
            }
            else if (ds.Tables[0].Rows.Count > 0)
            {
                Label1.Text = "Login Successful";
                Response.Redirect("./index1.html");
            }
            else
            {
                Label2.Text = "Login Failed";
            }
        }
    }
}
    

        

    
