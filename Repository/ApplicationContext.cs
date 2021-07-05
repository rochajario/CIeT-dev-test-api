using Microsoft.EntityFrameworkCore;
using desafio_ciet.Model;
using System;
using Microsoft.Extensions.Configuration;

namespace desafio_ciet.Repository
{
    public class ApplicationContext : DbContext
    {
        private readonly string _connectionString;
        private readonly MySqlServerVersion _dbVersion;

        public DbSet<Tarefa> Tarefas_CIeT { get; set; }

        public ApplicationContext(IConfiguration configuration )
        {
            var major = Convert.ToInt32(configuration["DBMajorVersion"]);
            var minor = Convert.ToInt32(configuration["DBMinorVersion"]);
            _connectionString = configuration["DBConnectionString"];
            _dbVersion = new MySqlServerVersion(new Version(major,minor));
        }        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseMySql(_connectionString, _dbVersion)
                .EnableSensitiveDataLogging()
                .EnableDetailedErrors();
        }
    }
}
