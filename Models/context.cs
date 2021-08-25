using System;
using System.Linq;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Disney.Models;

namespace Disney.Data
{
    public class context: DbContext
    {
        private string cadenaConexion;
            


        public DbSet<Personaje> Personajes {get; set; }
        public DbSet<PeliculaSerie> PeliculasSeries { get; set; }
        public DbSet<Genero> Generos { get; set;}
        public DbSet<Usuario> usuarios { get; set;}

         public DbSet<PeliculaPersonaje> PeliculasPersonajes {get; set; }
        public context(DbContextOptions options) : base(options)
        {

        }

        public context() : base()
        {
        }

        public IConfigurationRoot GetConfiguration()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            return builder.Build();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Data Source=CONECTAR\SQLEXPRESS;Initial Catalog=Disney;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            foreach (var relationship in builder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }

            base.OnModelCreating(builder);

        }

    }
}
