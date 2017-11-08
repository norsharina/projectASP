using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TrainingASP.PencapaianProgram
{
    public partial class Edit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindProgram();
            }
        }

        protected void BindProgram()
        {
            var id = Request.QueryString["Id"];

            const string sql = "SELECT * FROM PencapianProgram WHERE Id= @Id";

            using (var c = ConnectionManager.getConnection())
            {
                var data = c.QueryFirstOrDefault<Entities.PencapianProgram>(sql,new { Id=id});

                txtKodProgam.Text = data.KodProgram;
                txtTkhProgram.Text = data.TarikhProgram.ToString();
                txtBilHari.Text = data.BilanganHari.ToString();
                chckLulus.Checked = (bool)data.Lulus;
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            var id = Request.QueryString["Id"];

            const string sql = @"UPDATE PencapianProgram SET 
                                KodProgram = @KodProgram,
                                TarikhProgram = @TarikhProgram,
                                BilanganHari = @BilanganHari,
                                Lulus = @Lulus 
                                WHERE Id=@Id ";
            using (var c = ConnectionManager.getConnection())
            {
                var pencapaian = new Entities.PencapianProgram
                {
                    KodProgram = txtKodProgam.Text,
                    TarikhProgram = DateTime.Parse(txtTkhProgram.Text),
                    BilanganHari = int.Parse(txtBilHari.Text),
                    Lulus = chckLulus.Checked,
                    Id = int.Parse(id)
                };

                c.Execute(sql, pencapaian);
            }
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("List.aspx");
        }
    }
}