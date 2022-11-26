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
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn1_Click(object sender, EventArgs e)
        {
            SqlConnection SQLConn = new SqlConnection("Data Source=DESKTOP-3LUSQFK\\SQLEXPRESS01;Initial Catalog=NorthWind;Integrated Security=True");
            SQLConn.Open();
            SqlCommand cmd=new SqlCommand("Select * from Viewbolonizm where CategoryName='"+txbox1.Text+"'",SQLConn);
            cmd.ExecuteNonQuery();
            SqlDataAdapter adapter= new SqlDataAdapter(cmd);
            DataTable tb=new DataTable();
            adapter.Fill(tb);

            if (tb.Rows.Count > 0)
            {

                GridView1.DataSource = tb;
                GridView1.DataBind();
                lbl2.Text = "";
            }
            else
            {
                lbl2.Text = "Not Found";
                GridView1.DataSource = null;
                GridView1.DataBind();
            }
        }
        

        protected void txbox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}