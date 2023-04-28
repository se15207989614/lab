using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace LabAss5
{
    public partial class LoginWebFrom : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnSumbit(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["SimpleDatabseConnectionString"].ConnectionString);
            conn.Open();
            string querySring = "Select UserName,Password from Logon where UserName='" + txtUsername.Text + "'";

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = new SqlCommand(querySring, conn);

            DataSet ds1 = new DataSet();
            adapter.Fill(ds1, "Logon");
            if (ds1.Tables["Logon"].Rows.Count == 0) 
            {
                lblCaption.Text = "Invalid Username";
            }
            else
            {
                if (ds1.Tables["Logon"].Rows[0][1].ToString().Trim() == txtPassword.Text.Trim())
                {
                    lblCaption.Text = "Welcome," + txtUsername.Text;

                    Session["Uname"] = txtUsername.Text;
                    Server.Transfer("Welcome.aspx");
                }
                else
                {
                    lblCaption.Text = "Invalid Password";
                }
                conn.Close();
            }


        }
    }
}