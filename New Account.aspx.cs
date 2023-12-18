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
    public partial class New_Account : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cs"].ToString());
            con.Open();
            string q = "Proc_OpenAcct";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@a", TextBox1.Text);
            cmd.Parameters.AddWithValue("@b", TextBox2.Text);
            cmd.Parameters.AddWithValue("@c", TextBox7.Text);
            cmd.Parameters.AddWithValue("@d", TextBox5.Text);
            cmd.Parameters.AddWithValue("@e", TextBox6.Text);
            try
            {
                int p = cmd.ExecuteNonQuery();

                if (p != 0)
                {
                    Response.Write("Account is created");
                }
            }
            catch
            {
                Response.Write("Account is not created");
            }
            con.Close();
            getactid();
            
        }
        void getactid()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cs"].ToString());
            string q = "Proc_ActNo";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@a", TextBox1.Text);
            SqlDataAdapter ds = new SqlDataAdapter(cmd);
            DataSet dr = new DataSet();
            ds.Fill(dr, "emps");
            GridView1.DataSource = dr;
            GridView1.DataBind();
        }
        void getclear()
        {
            TextBox1.Text = TextBox2.Text = TextBox3.Text = TextBox5.Text = TextBox6.Text = TextBox7.Text = "";
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            getclear();
        }
    }
}