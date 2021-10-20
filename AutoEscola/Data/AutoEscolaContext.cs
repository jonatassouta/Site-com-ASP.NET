using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AutoEscola.Pages.Funcionarios;
using AutoEscola.Pages;

namespace AutoEscola.Data
{
    public class AutoEscolaContext : DbContext
    {
        public AutoEscolaContext (DbContextOptions<AutoEscolaContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source = DESKTOP-9SPM9G4\SQLEXPRESS; Initial Catalog=BDAutoEscola; Integrated Security = true");
        }

        public DbSet<AutoEscola.Pages.Funcionarios.Funcionario> Funcionario { get; set; }

        public DbSet<AutoEscola.Pages.Aluno> Aluno { get; set; }
    }
}
