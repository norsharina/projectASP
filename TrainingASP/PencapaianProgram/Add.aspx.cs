using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using Dapper;

namespace TrainingASP.PencapaianProgram
{
    public partial class Add : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            //Insert Kod Pencapaian Program
            const string sql = @"INSERT INTO PencapianProgram (KodProgram, TarikhProgram,BilanganHari,Lulus)
            VALUES (@KodProgram, @TarikhProgram,@BilanganHari,@Lulus) ";

            //get connection string from web.config
            var connection = ConfigurationManager.ConnectionStrings["Database"].ToString();

            //buka connection
            using (var c = new SqlConnection(connection))
            {
                var pencapaianProgram = new Entities.PencapianProgram
                {
                    KodProgram = txtKodProgam.Text,
                    TarikhProgram = DateTime.Parse (txtTkhProgram.Text),
                    BilanganHari =  int.Parse(txtBilHari.Text),
                    Lulus = chckLulus.Checked
                };

                c.Execute(sql, pencapaianProgram);

            }

            Response.Redirect("List.aspx");
        }
    }
}