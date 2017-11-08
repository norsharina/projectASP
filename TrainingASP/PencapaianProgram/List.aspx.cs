using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TrainingASP.PencapaianProgram
{
    public partial class List : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BindProgram();
        }

        protected void BindProgram()
        {
            const string sql = @"SELECT * FROM PencapianProgram";

            var connection = ConfigurationManager.ConnectionStrings["Database"].ToString();

            //buka connection
            using (var c = new SqlConnection(connection))
            {
                var data = c.Query<Entities.PencapianProgram>(sql);
                ProgramRepeater.DataSource = data;
                ProgramRepeater.DataBind();
            }
        }
    }
}