using ncInfo.Web.Controller;
using PS_Esig.Dominio;
using PS_Esig.Dominio.BDEstrutura;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS_EsigController
{
    public class PS_ListarPesSal : BaseController<Salarios>
    {
        public PS_ListarPesSal(MConexaoDBcs context)
           : base(context)
        { }

        public override DbSet<Salarios> DbSet
        {
            get
            {
                return this.Context.Salarios;
            }
        }

        public List<Salarios> BuscarSalario()
        {           
            List<Salarios> rel = this.Context.Database.SqlQuery<Salarios>("exec ES_CPSalario").ToList();
            return rel;
        }

        public List<Salarios> BuscarSalarioCalcul(int Pessoa_IDCads)
        {
            List<Salarios> rel = this.Context.Database.SqlQuery<Salarios>("select * from ES_CadPessoas..Salarios where Pessoa_ID ={0}", new object[] { Pessoa_IDCads }).ToList();
            return rel;
        }

        public bool SalarioCalcul(int Pessoa_IDCads)
        {
            this.Context.Database.ExecuteSqlCommand("exec ES_CCarSalario {0}"
                , new object[] { Pessoa_IDCads });

            return true;
        }

        public bool SalarioReCalcul()
        {
            this.Context.Database.ExecuteSqlCommand("exec ES_RecGeral ");

            return true;
        }
    }
}
