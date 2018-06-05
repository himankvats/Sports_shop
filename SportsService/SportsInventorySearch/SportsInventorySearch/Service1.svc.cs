using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Newtonsoft.Json;

namespace SportsInventorySearch
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : ISearchService
    {
       

        public string SearchInventory(string SearchString, string SearchBy)
        {
            string searchQuery;
            string Connectionstring = ConfigurationManager.ConnectionStrings["InventoryDB"].ConnectionString;
            using (SqlConnection con = new SqlConnection(Connectionstring))
            {
                if (String.Equals(SearchBy, "ProductID"))
                {
                    searchQuery = "Select * from [Products] where [Product_Id] like '" + SearchString + "%'";
                }
                else
                {
                    searchQuery = "Select * from [Products] where [Product_Name] like '%" + SearchString + "%'";
                }
                con.Open();
                SqlCommand command = new SqlCommand(searchQuery, con);
                DataTable SearchTable = new DataTable();
                
                SearchTable.Load(command.ExecuteReader());

                string JsonTable = JsonConvert.SerializeObject(SearchTable);
                return JsonTable;

            }

               
        }
    }
}
