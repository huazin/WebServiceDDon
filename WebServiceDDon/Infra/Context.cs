using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using WebServiceDDon.Infra.EntityConfig;
using WebServiceDDon.Models;

namespace WebServiceDDon.Infra
{
    public class Context : DbContext
    {
        public Context()
            : base("BancoDDon")
        {

        }

        public DbSet<LabelsIdiomas> LabelsIdiomas { get; set; }
        public DbSet<Sobre> Sobre { get; set; }
        public DbSet<Monstro> Monstro { get; set; }
        public DbSet<Especie> Especies { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Configurations.Add(new LabelsIdiomaConfig());
            modelBuilder.Configurations.Add(new SobreConfig());
            modelBuilder.Configurations.Add(new MonstroConfig());
            modelBuilder.Configurations.Add(new EspecieConfig());
            modelBuilder.Configurations.Add(new UsuarioConfig());

            base.OnModelCreating(modelBuilder);
        }

        public override int SaveChanges()//Salvar Mudanças

        {
            return base.SaveChanges();
        }

    }
}