using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Partie_7_Ado.net
{
    public partial class Page1 : System.Web.UI.Page
    {
        static string conString = @"data source=localhost\SQLEXPRESS;database=DBStagiaire;Integrated Security=true;";
        SqlConnection connection;
        protected void Page_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(conString);
            SqlCommand command = new SqlCommand("select * from Stagiaire",connection);
            connection.Open();
            GridView1.DataSource = command.ExecuteReader();
            GridView1.DataBind();
            connection.Close();
            
        }
    }
}