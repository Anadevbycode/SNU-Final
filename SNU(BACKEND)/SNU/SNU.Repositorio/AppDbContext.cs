using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SNU.Dominio;

namespace SNU.Repositorio
{
    public class AppDbContext : DbContext
    {
        public DbSet<Aluno> Alunos { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
    }
}