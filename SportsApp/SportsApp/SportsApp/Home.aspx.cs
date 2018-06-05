using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Runtime;
using Newtonsoft.Json;
namespace SportsApp
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string searchstring = TextBox2.Text;
            string srearchby = DropDownList1.SelectedValue;
            string searchQuery;

            string Connectionstring = ConfigurationManager.ConnectionStrings["LocalDB"].ConnectionString;

            using(SqlConnection con = new SqlConnection(Connectionstring))
            {
                if (String.Equals(srearchby, "ProductID"))
                {
                    searchQuery = "Select * from [Products] where [Product_Id] like '" + searchstring + "%'";
                }
                else
                {
                     searchQuery = "Select * from [Products] where [Product_Name] like '%" + searchstring+ "%'";
                }
                SqlCommand command = new SqlCommand(searchQuery, con);
                DataTable SearchTable = new DataTable();
                con.Open();
                SearchTable.Load(command.ExecuteReader());
                if(SearchTable.Rows.Count==0)
                {
                    GridView1.Visible = false;
                    Label1.Visible = true;
                    Label1.Text = "Sorry couldnt find anything for this search [tip search in warehouse]";
                }
                else
                {
                    GridView1.Visible = true;
                    Label1.Visible = false;
                    GridView1.DataSource = SearchTable;
                    GridView1.DataBind();
                }

            }

             

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string searchstring = TextBox2.Text;
            string srearchby = DropDownList1.SelectedValue;

            InventorySearch.SearchServiceClient client = new InventorySearch.SearchServiceClient();
            string JsonTable= client.SearchInventory(searchstring, srearchby);
            DataTable SearchTable = new DataTable();
               SearchTable=  JsonConvert.DeserializeObject <DataTable>(JsonTable);
            if (SearchTable.Rows.Count == 0)
            {
                GridView1.Visible = false;
                Label1.Visible = true;
                Label1.Text = "Sorry couldnt find anything for this search";
            }
            else
            {
                GridView1.Visible = true;
                Label1.Visible = false;
                GridView1.DataSource = SearchTable;
                GridView1.DataBind();
            }
            
        }
    }
}