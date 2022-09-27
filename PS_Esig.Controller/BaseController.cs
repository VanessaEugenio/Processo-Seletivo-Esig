using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Data;

using System.ComponentModel;
using PS_Esig.Dominio;

namespace  ncInfo.Web.Controller
{
    public enum AcaoController
    {
        Adicionar,
        Alterar
    }

    public abstract class BaseController<ModelClass> : Object where ModelClass : class
    {
        public BaseController(MConexaoDBcs context)
        {
            this.Context = context;
        }

        public abstract DbSet<ModelClass> DbSet
        {
            get;
        }

        public MConexaoDBcs Context { get; set; }

        public virtual ModelClass Encontrar(Func<ModelClass, bool> w)
        {
            return this.ListarGenerico().FirstOrDefault(w);
        }

        protected virtual IQueryable<ModelClass> ListarGenerico()
        {
            return this.DbSet;
        }

        public virtual IQueryable<ModelClass> Listar(int? inicio, int? quantidade)
        {
            var result = this.ListarGenerico();
            if (inicio.HasValue)
                result = result.Skip(inicio.Value);
            if (quantidade.HasValue)
                result = result.Take(quantidade.Value);
            return result;
        }

        public virtual IEnumerable<ModelClass> Listar(Func<ModelClass, bool> w, int? inicio = null, int? quantidade = null)
        {
            if (inicio.HasValue)
                return this.DbSet.Skip(inicio.Value).Where(w);
            if (quantidade.HasValue)
                return this.DbSet.Take(quantidade.Value).Where(w);
            else
                return this.DbSet.Where(w);
        }

        public virtual int Adicionar(ModelClass model)
        {
            this.AntesAdicionar(model);
            this.AntesSalvar(AcaoController.Adicionar, model);
            this.DbSet.Add(model);
            return this.Context.SaveChanges();
        }

        public virtual int Alterar(ModelClass model)
        {
            this.AntesAlterar(model);
            this.AntesSalvar(AcaoController.Alterar, model);
            this.Context.Entry<ModelClass>(model).State = System.Data.Entity.EntityState.Modified;
            return this.Context.SaveChanges();
        }

        public virtual int Remover(ModelClass model)
        {
            this.DbSet.Remove(model);
            return this.Context.SaveChanges();
        }

        public virtual void AntesAdicionar(ModelClass model)
        { }

        public virtual void AntesAlterar(ModelClass model)
        { }

        public virtual void AntesSalvar(AcaoController acao, ModelClass model)
        { }
    }
}
