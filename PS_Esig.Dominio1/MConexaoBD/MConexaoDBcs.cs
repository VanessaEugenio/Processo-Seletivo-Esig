using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.Entity.ModelConfiguration.Conventions;
using PS_Esig.Dominio.MConexaoBD;
using PS_Esig.Dominio.BDEstrutura;

namespace PS_Esig.Dominio
{
    public class MConexaoDBcs: DbContext
    {
        public MConexaoDBcs(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        public static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["sqlServerConnectionString"].ConnectionString;
        }

        public static MConexaoDBcs Instance()
        {
            MConexaoDBcs db = new MConexaoDBcs(GetConnectionString());

            // Get the ObjectContext related to this DbContext
            var objectContext = (db as IObjectContextAdapter).ObjectContext;

            // Sets the command timeout for all the commands
            objectContext.CommandTimeout = 300;

            db.Database.ExecuteSqlCommand("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED;");
            return db;
        }

        public override int SaveChanges()
        {
            foreach (DbEntityEntry<ModelPersonalizado> entry in ChangeTracker.Entries<ModelPersonalizado>())
            {
                if (entry.State == EntityState.Added)
                    entry.Entity.AntesAdicionar();
                else if (entry.State == EntityState.Modified)
                    entry.Entity.AntesAtualizar();
                entry.Entity.AntesSalvar();
            }
            return base.SaveChanges();
        }

        public DbSet<Cargo> Cargos { get; set; }
        public DbSet<Cargo_Vencimentos> Cargo_Vencimentos { get; set; }
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Vencimentos> Vencimentos { get; set; }
        public DbSet<Salarios> Salarios { get; set; }

    }
}






