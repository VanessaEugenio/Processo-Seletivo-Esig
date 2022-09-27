using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PS_Esig
{
    public partial class CadastroPessoas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
            }
        }
        protected void BtnCadastrar_Click(object sender, EventArgs e)
        {
            string url = String.Format("FormPessoasSalarios.aspx");
            Response.Redirect(url);
        }

        protected void BtnListar_Click(object sender, EventArgs e)
        {

            string url = String.Format("ListarPessoas.aspx");
            Response.Redirect(url);

        }
    }
}