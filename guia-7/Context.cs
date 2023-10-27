using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guia_7
{

    public class Context : DbContext
    {

        private const string connectionString = "server=localhost;port=3306;database=Program2;user=root;password=00009";
        ServerVersion sv = MariaDbServerVersion.AutoDetect(connectionString);
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(connectionString, sv);
        }

        public DbSet<EstudianteUNAB> Estudiante { get; set; }
    }
}