using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creed.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Funcionario> Funcionarios { get; set; }
    }
}
