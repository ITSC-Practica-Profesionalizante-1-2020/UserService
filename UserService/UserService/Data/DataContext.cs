using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SharedModels.UserService;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace UserService.Data
{
    public class DataContext : IdentityDbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<Persona> Persona { get; set; }
    }
}
