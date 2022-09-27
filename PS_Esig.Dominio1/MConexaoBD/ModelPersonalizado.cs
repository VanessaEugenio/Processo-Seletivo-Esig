﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PS_Esig.Dominio.MConexaoBD
{
   public class ModelPersonalizado
    {
        public List<string> GetPrimaryKey()
        {
            List<string> result = new List<string>();
            System.Object[] attributes;
            foreach (PropertyInfo pI in this.GetType().GetProperties())
            {
                attributes = pI.GetCustomAttributes(true);
                foreach (object attribute in attributes)
                {
                    if (attribute is KeyAttribute)
                        result.Add(pI.Name);
                }
            }
            return result;
        }

        public Dictionary<string, object> GetPKValues()
        {
            Dictionary<string, object> result = new Dictionary<string, object>();
            System.Object[] attributes;
            foreach (PropertyInfo pI in this.GetType().GetProperties())
            {
                attributes = pI.GetCustomAttributes(true);
                foreach (object attribute in attributes)
                {
                    if (attribute is KeyAttribute)
                        result[pI.Name] = pI.GetValue(this, null);
                }
            }
            return result;
        }

        public virtual void AntesAdicionar()
        { }

        public virtual void AntesAtualizar()
        { }

        public virtual void AntesSalvar()
        { }

        public DbEntityEntry Entry
        {
            get
            {
                return MConexaoDBcs.Instance().Entry(this);
            }
        }

        public object OldValues(string propertyName)
        {
            return this.Entry.OriginalValues[propertyName];
        }

        public T OldValues<T>(string propertyName)
        {
            return (T)this.Entry.OriginalValues[propertyName];
        }

        public Boolean HasChanged(string propertyName)
        {
            return !this.Entry.CurrentValues[propertyName].Equals(this.Entry.OriginalValues[propertyName]);
        }
    }
}
