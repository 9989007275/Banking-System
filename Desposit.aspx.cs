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
    public partial class Desposit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button3_Click(object sender, EventArgs e)
        {

            login();
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cs"].ToString());
            string q = "Proc_DespAct";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@a", TextBox1.Text);
            cmd.Parameters.AddWithValue("@b", TextBox2.Text);
            cmd.Parameters.AddWithValue("@c", TextBox3.Text);
            cmd.Parameters.AddWithValue("@d", TextBox4.Text);
            SqlDataAdapter ds = new SqlDataAdapter(cmd);
            DataSet dr = new DataSet();
            ds.Fill(dr, "bank");
            GridView1.DataSource = dr;
            GridView1.DataBind();
            Label1.Text = "Your Deposited '" + TextBox4.Text + "'";
            Label1.Visible = true;
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
            TextBox1.Text = TextBox2.Text = TextBox3.Text =TextBox4.Text= "";
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}