using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PC04.Models;

namespace PC04.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<PC04.Models.Usuario> Usuario {get; set;}
        public DbSet<PC04.Models.Imagenes> Imagenes {get; set;}
       
    }
}
