using ncInfo.Web.Controller;
using PS_Esig.Dominio;
using PS_Esig.Dominio.BDEstrutura;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PS_Esig.Controller.PS_EsigController
{
    public class PS_Pessoa : BaseController<Pessoa>
    {
        public PS_Pessoa(MConexaoDBcs context)
          : base(context)
        { }

        public override DbSet<Pessoa> DbSet
        {
            get
            {
                return this.Context.Pessoas;
            }
        }

        public int BuscarUltPos()
        {
            int rel = this.Context.Database.SqlQuery<int>(" select MAX(ID) from Pessoa", new object[] {  }).FirstOrDefault();
            return rel;
        }
        
        public List<Pessoa> BuscarPessoa(int Pessoa_ID)
        {
            List<Pessoa> rel = this.Context.Database.SqlQuery<Pessoa>("select * from Pessoa where ID = {0}", new object[] { Pessoa_ID }).ToList();
            return rel;
        }

        public bool AtualizarPessoa(Pessoa Pessoas)
        {
            this.Context.Database.ExecuteSqlCommand("update ES_CadPessoas..Pessoa " +
                "set Nome ={0} , " +
                "Cidade ={1} , " +
                "Email = {2}, " +
                "CEP = {3}, " +
                "Enderco = {4}," +
                "Pais = {5} ," +
                "Telefone = {6} , " +
                "Data_Nascimento = {7} ," +
                "Cargo_ID = {8} ," +
                "Usuario= {9} " +
                "where ID = {10}", new object[] { Pessoas.Nome, Pessoas.Cidade, Pessoas.Email, Pessoas.CEP, Pessoas.Enderco, Pessoas.Pais, Pessoas.Telefone, Pessoas.Data_Nascimento, Pessoas.Cargo_ID, Pessoas.Usuario, Pessoas.ID });
            return true;
        }
        public bool AtualizarCargo(string Cargo,int PessoaID)
        {
            this.Context.Database.ExecuteSqlCommand("update ES_CadPessoas..Pessoa " +
                "set Cargo_ID = {0} " +               
                "where ID = {1}", new object[] { Cargo, PessoaID });
            return true;
        }

        public bool DeletePessoa(int Pessoas)
        {
            this.Context.Database.ExecuteSqlCommand("DELETE FROM ES_CadPessoas..Salarios WHERE Pessoa_ID = {0}", new object[] { Pessoas });
            return true;
        }
        public bool InserirPessoa(Pessoa Pessoas)
        {
            this.Context.Database.ExecuteSqlCommand("insert into ES_CadPessoas..Pessoa" +
                "(Nome, Cidade, Email, CEP, Enderco, Pais, Usuario, Telefone, Data_Nascimento, Cargo_ID,ID)" +
                "values({0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10})"
                , new object[] { Pessoas.Nome, Pessoas.Cidade, Pessoas.Email, Pessoas.CEP, Pessoas.Enderco, Pessoas.Pais, Pessoas.Usuario, Pessoas.Telefone, Pessoas.Data_Nascimento, Pessoas.Cargo_ID ,Pessoas.ID});

            return true;
        }
    }
}