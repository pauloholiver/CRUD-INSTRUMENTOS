using Microsoft.EntityFrameworkCore;
using CrudInstrumentos.Entities;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace CrudInstrumentos.Models
{
    public class DatabaseContext : DbContext
    {

        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder()
                                .SetBasePath(Directory.GetCurrentDirectory())
                                .AddJsonFile("appsettings.json");
            var configuration = builder.Build();
            optionsBuilder.UseSqlServer(configuration["ConnectionStrings:DefaultConnection"]);

        }

        public DbSet<Instrumento> Instrumentos { get; set; }

    }
}
