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
    public partial class admin : System.Web.UI.Page
    {
        public String conString = "Data Source=DESKTOP-9NQ1TKD;Initial Catalog=user;User ID=sa;Password=12345";
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            SqlCommand cmd2 = con.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "Delete from user5 where id='" + TextBox6.Text + "'";
            cmd2.ExecuteNonQuery();
            Label6.Text = "Succesfully deletedd!!!!!";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            SqlCommand cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "update user5 set name='" + TextBox1.Text + "', Email='" + TextBox2.Text + "',password='" + TextBox3.Text + "',addresse='" + TextBox4.Text + "',contact='" + TextBox5.Text + "' WHERE id='" + TextBox6.Text + "'";
            cmd1.ExecuteNonQuery();
            Label6.Text = "updated";
        }
    }
}