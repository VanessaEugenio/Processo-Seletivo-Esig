using PS_Esig.Controller.PS_EsigController;
using PS_Esig.Dominio.BDEstrutura;
using PS_EsigController;
using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;
using App_Data;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Threading;

namespace PS_Esig
{
    public partial class ListarPessoas : System.Web.UI.Page
    {
        PS_ListarPesSal controller = new PS_ListarPesSal(SDBC.Instance);
        List<Salarios> GetDados = new List<Salarios>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                PreencherLista();
                BtnRecalcular.Visible = true;
            }
        }

        public void PreencherLista()
        {
            GetDados = controller.BuscarSalario();
            grvLista.DataSource = GetDados;
            grvLista.DataBind();
        }

        protected void grvLista_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grvLista.PageIndex = e.NewPageIndex;
            PreencherLista();
        }

        protected void grvLista_RowCommand(object sender, System.Web.UI.WebControls.GridViewCommandEventArgs e)
        {
            PS_Pessoa controller = new PS_Pessoa(SDBC.Instance);
            string Pessoa_ID = e.CommandArgument.ToString();

            if (e.CommandName == "Alterar" || e.CommandName == "Recalcular")
            {
                string url = String.Format("FormPessoasSalarios.aspx?Variavel1=" + Pessoa_ID);
                Response.Redirect(url);
            }
            else if (e.CommandName == "Excluir")
            {
                bool delete = controller.DeletePessoa(int.Parse(Pessoa_ID));
                if (delete)
                {
                    PreencherLista();
                    Response.Write("<script>alert('Seus dados foram deletados com sucesso');</script>");

                }
            }

            else if (e.CommandName == "C_Cheque")
            {
                var doc = new ReportDocument();

                doc.Load(MapPath("~/Relatorios/RelContraCheque.rpt"));
                doc.SetParameterValue("@Pessoa_ID", int.Parse(Pessoa_ID));
                doc.ExportToHttpResponse(ExportFormatType.PortableDocFormat, Page.Response, true, "@Pessoa_ID");
                doc.Refresh();
            }
        }

        protected void BtnVoltar_Click(object sender, System.Web.UI.ImageClickEventArgs e)
        {
            string url = String.Format("CadastroPessoas.aspx");
            Response.Redirect(url);
        }

        
        protected void BtnRecalcular_Click(object sender, EventArgs e)
        {
            if (controller.SalarioReCalcul())
                Response.Write("<script>alert('Rúbricas calculadas com sucesso!');</script>");

            PreencherLista();

        }

        
    }
}