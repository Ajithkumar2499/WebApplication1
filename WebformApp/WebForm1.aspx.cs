using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace WebformApp
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Setting ViewState values
                ViewState["Name"] = "John";
                ViewState["Age"] = 30;
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            
            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["connect"].ConnectionString);
            sqlConnection.Open();
            string Name = txtName.Text;
            string Age = txtAge.Text;
            string Dept = ddl.SelectedValue;
            try
            {
                string query = "insert into igoEmp values ('" + Name + "', " + Age + ",'" + Dept + "') ";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.ExecuteNonQuery();
                txtName.Text = "";
                txtAge.Text = "";
                ddl.SelectedValue = "0";
            }
            catch (Exception ex)
            {
                Console.WriteLine("asfdf" + ex.StackTrace);
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtAge.Text = "";
            ddl.SelectedValue = "0";
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("https://localhost:44326/Gridview.aspx");
        }

        protected void btnGetViewState_Click(object sender, EventArgs e)
        {
            // Getting ViewState values
            string name = ViewState["Name"] as string;
            int age = (int)ViewState["Age"];

            // Displaying values
            lblName.Text = "Name: " + name;
            lblAge.Text = "Age: " + age.ToString();
        }
    }
}