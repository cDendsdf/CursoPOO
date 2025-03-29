using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SysDataAccess.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysDataAccess
{
    public class ApplicationDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var ConnectionSql = new ConfigurationBuilder().SetBasePath(AppDomain.CurrentDomain.BaseDirectory).AddJsonFile("AppSettings.json",false,true);
            var sql = ConnectionSql.Build();
            optionsBuilder.UseSqlServer(sql.GetConnectionString("DefaultConnection"));
        }


        public DbSet<Estudiante> Estudiantes { get; set; }
       
    }
}
