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
    public partial class Gridview : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           bindgrid();
            grdview.AllowPaging = true;
        }

        protected void grdview_RowEditing(object sender, GridViewEditEventArgs e)
        {
            grdview.EditIndex = e.NewEditIndex;
            grdview.DataBind();
        }
        public DataSet bindgrid()
        {
            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["connect"].ConnectionString);
            sqlConnection.Open();
            string query = "select * from igoEmp";
            DataSet dataSet = new DataSet();
            try
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);               
                sqlDataAdapter.Fill(dataSet);
                grdview.DataSource = dataSet;
                grdview.DataBind();
            }
            catch(Exception ex)
            {

            }
            finally
            {
                sqlConnection.Close();
            }
            
            return dataSet;
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            Response.Redirect("https://localhost:44326/WebForm1.aspx");
        }

        protected void grdview_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdview.PageIndex = e.NewPageIndex;
            bindgrid();
        }

        protected void grdview_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {

            GridViewRow row = (GridViewRow)grdview.Rows[e.RowIndex];
            int id = Int32.Parse(grdview.DataKeys[e.RowIndex].Value.ToString());
            string tname = ((TextBox)row.Cells[0].Controls[0]).Text;
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connect"].ConnectionString);
            SqlCommand cmd = new SqlCommand("update igoEmp set Name=@name where id = @id", con);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@name", SqlDbType.VarChar, 30).Value = tname;            
            con.Open();
            cmd.ExecuteNonQuery();
            grdview.EditIndex = -1;
            bindgrid();
        }

        protected void grdview_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            SqlConnection A = new SqlConnection(ConfigurationManager.ConnectionStrings["connect"].ToString());
            A.Open();
            SqlCommand B = new SqlCommand("delete FROM igoEmp where id='" + Convert.ToInt32(grdview.DataKeys[e.RowIndex].Value) + "'", A); // Need DataKeyNames in aspx file.
            B.ExecuteNonQuery();
            A.Close();
            bindgrid();
        }

        protected void grdview_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            grdview.EditIndex = -1;
            bindgrid();
        }
    }
}