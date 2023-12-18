using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace Bank
{
    public partial class Close : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            login();
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cs"].ToString());
            con.Open();
            string q = "Proc_AcctDel";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@a", TextBox1.Text);
            cmd.Parameters.AddWithValue("@b", TextBox2.Text);
            cmd.Parameters.AddWithValue("@c", TextBox3.Text);
            int p = cmd.ExecuteNonQuery();
            if(p!=0)
            {
                Label1.Text = "Your account is closed";
            }
            con.Close();

        }
        void login()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cs"].ToString());
            con.Open();
            string q = "Proc_ActLo";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@a", TextBox1.Text);
            cmd.Parameters.AddWithValue("@b", TextBox2.Text);
            cmd.Parameters.AddWithValue("@c", TextBox3.Text);
            object p = cmd.ExecuteScalar();
            if ((int)p != 0)
            {
                Response.Write("Welcome " + TextBox2.Text);
            }
            else
            {
                Response.Write("Invalid User");
            }
            con.Close();
        }
        void clear()
        {
            TextBox1.Text = TextBox2.Text = TextBox3.Text = "";
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}