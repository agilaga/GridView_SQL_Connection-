using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace View_SQL_connection_product_category
{
    public partial class View_SQL : System.Web.UI.Page
    {
        bool PrmtrsChange = false;

        private SqlConnection SQLConn = new SqlConnection("Server=DESKTOP-3LUSQFK\\SQLEXPRESS01;Initial Catalog=NorthWind;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btn1_click(object sender, EventArgs e)
        {
            if (PrmtrsChange) Session["data"] = null;
            PrmtrsChange = false;
            BindMethod();
        }
        protected void BindMethod()
        {
            if (Session["data"] == null)
            {
                SQLConn.Open();
                SqlCommand cmd = new SqlCommand("Select * from Viewbolonizm where CategoryName='" + txbox1.Text + "'", SQLConn);
                cmd.ExecuteNonQuery();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable tb = new DataTable();
                adapter.Fill(tb);

                if (tb.Rows.Count > 0)
                {
                    Session["data"] = tb;
                }
                else
                {
                    lbl2.Text = "Not Found";
                    Session["data"] = null;
                    GridView1.DataSource = null;
                    GridView1.DataBind();
                    SQLConn.Close();
                    return;
                }
                SQLConn.Close();
            }
            GridView1.DataSource = Session["data"];
            GridView1.DataBind();
            lbl2.Text = "";
        }

        protected void txtbox1_TextChanged(object sender, EventArgs e)
        {
            PrmtrsChange= true;
        }

        protected void datagrid_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            btn1_click(sender, e);
        }
    }
}