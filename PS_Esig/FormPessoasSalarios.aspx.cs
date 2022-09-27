using PS_Esig.Controller.PS_EsigController;
using PS_Esig.Dominio.BDEstrutura;

using PS_EsigController;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PS_Esig
{
    public partial class FormPessoasSalarios : System.Web.UI.Page
    {   

        private static int Pessoa_ID;
        List<Pessoa> GetPessoa = new List<Pessoa>();
        Pessoa inserirPessoas;

        protected void Page_Load(object sender, EventArgs e)
        {
            PS_Pessoa controllerPessoa = new PS_Pessoa(SDBC.Instance);
            if (!IsPostBack)
            {
                string name = Request.QueryString["Variavel1"];

                if (!string.IsNullOrEmpty(name))
                {
                    BtnCadastrar.Text = "EDITAR";
                    BtnCalcular.Text = "RECALCULAR";
                    Pessoa_ID = int.Parse(name);

                    GetPessoa = controllerPessoa.BuscarPessoa(Pessoa_ID);

                    PreencherFormCadastro(GetPessoa);

                }
               
            }
           
        }

        public void PreencherFormCadastro(List<Pessoa> pessoas) 
        {
            TextNome.Text = pessoas[0].Nome;
            TextEmail.Text = pessoas[0].Email;
            TextFone.Text = pessoas[0].Telefone;
            TextDataNasci.Text = pessoas[0].Data_Nascimento;
            TextEndereco.Text = pessoas[0].Enderco;
            TextCep.Text = pessoas[0].CEP;
            TextPais.Text = pessoas[0].Pais;
            TextCidade.Text = pessoas[0].Cidade;
            TextUsuario.Text = pessoas[0].Usuario;
            DListCargo.SelectedValue = pessoas[0].Cargo_ID;

            TextUsuario.Enabled = false;

        }

        private static bool falha;
        public bool tudoPreenchido()
        {
            FormPessoasSalarios.falha = true;


            if (string.IsNullOrEmpty(inserirPessoas.CEP))
            {
                FormPessoasSalarios.falha  = false;
            }
            else if (string.IsNullOrEmpty(inserirPessoas.Cidade))
            {
                FormPessoasSalarios.falha = false;
            }
            else if (string.IsNullOrEmpty(inserirPessoas.Data_Nascimento))
            {
                FormPessoasSalarios.falha = false;
            }
            else if (string.IsNullOrEmpty(inserirPessoas.Email))
            {
                FormPessoasSalarios.falha = false;
            }
            else if (string.IsNullOrEmpty(inserirPessoas.Enderco))
            {
                FormPessoasSalarios.falha = false;
            }
            else if (string.IsNullOrEmpty(inserirPessoas.Nome))
            {
                FormPessoasSalarios.falha = false;
            }
            else if (string.IsNullOrEmpty(inserirPessoas.Pais))
            {
                FormPessoasSalarios.falha = false;
            }
            else if (string.IsNullOrEmpty(inserirPessoas.Telefone))
            {
                FormPessoasSalarios.falha = false;
            }
            else if(string.IsNullOrEmpty(inserirPessoas.Usuario))
            {
                FormPessoasSalarios.falha = false;
            }

            return FormPessoasSalarios.falha;
        }
        public Pessoa InserirPessoa(int IDPessoa)
        {
             inserirPessoas = new Pessoa()
            {
                ID = IDPessoa,
                Cargo_ID = DListCargo.SelectedValue,
                CEP = TextCep.Text,
                Cidade = TextCidade.Text,
                Data_Nascimento = TextDataNasci.Text,
                Email = TextEmail.Text,
                Enderco = TextEndereco.Text,
                Nome = TextNome.Text,
                Pais = TextPais.Text,
                Telefone = TextFone.Text,
                Usuario = TextUsuario.Text
            };
            return inserirPessoas;
        }

        protected void BtnCadastrar_Click(object sender, EventArgs e)
        {
            PS_Pessoa controller = new PS_Pessoa(SDBC.Instance);
            Pessoa pessoa = new Pessoa();
            

            int Pessoa_IDCads = controller.BuscarUltPos() + 1;

            
            if (BtnCadastrar.Text == "EDITAR")
            {
                
                pessoa = InserirPessoa(Pessoa_ID);
                if (!tudoPreenchido())
                {
                    Response.Write("<script>alert('Preencha os dados que estão vazios, para prosseguir com o cadastro.');</script>");
                    return;
                }

                bool atualizado = controller.AtualizarPessoa(pessoa);
                if (atualizado)
                {
                    BtnCadastrar.Text = "CADASTRAR";
                    Response.Write("<script>alert('Seus dados foram alterados com sucesso');</script>");
                
                }
            }
            else
            {
                pessoa = InserirPessoa(Pessoa_IDCads);
                if (!tudoPreenchido())
                {
                    Response.Write("<script>alert('Preencha os dados que estão vazios, para prosseguir com o cadastro.');</script>");
                    return;
                }
                Pessoa itemVerifica = controller.Encontrar(x => x.ID == Pessoa_IDCads);

                if (itemVerifica == null)
                {
                    bool inserido = controller.InserirPessoa(pessoa);
                    Response.Write("<script>alert('Dados cadastrados com sucesso');</script>");
                }
                else
                {
                    Response.Write("<script>alert('Dados já existentes');</script>");
                }

            }
               

        }

        protected void BtnVoltar_Click(object sender, ImageClickEventArgs e)
        {
            BtnCalcular.Text = "CALCULAR";
            string url = String.Format("CadastroPessoas.aspx");
            Response.Redirect(url);
        }

        public void Calcular_Recalcular(int PessoasID)
        {

            List<Salarios> salarios = new List<Salarios>();

            PS_ListarPesSal pS_ListarPesSal = new PS_ListarPesSal(SDBC.Instance);
            
                bool ResCal = pS_ListarPesSal.SalarioCalcul(PessoasID);

                salarios = pS_ListarPesSal.BuscarSalarioCalcul(PessoasID);
                grvCalculo.DataSource = salarios;
                grvCalculo.DataBind();
           
        }
        protected void BtnCalcular_Click(object sender, EventArgs e)
        {
            PS_Pessoa controller = new PS_Pessoa(SDBC.Instance);
            if (BtnCalcular.Text == "CALCULAR")
            {
                
                int Pessoa_IDCads = controller.BuscarUltPos();
                Calcular_Recalcular(Pessoa_IDCads);
            }
            else
            {
                controller.AtualizarCargo(DListCargo.SelectedValue, Pessoa_ID);
                Calcular_Recalcular(Pessoa_ID);
                
            }   

        }
    }
}