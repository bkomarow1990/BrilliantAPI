using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using Core.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class BrilliantDbContext : IdentityDbContext
    {
        public BrilliantDbContext()
        {
        }

        public BrilliantDbContext(DbContextOptions options) : base(options)
        {
            
        }
        public virtual DbSet<Product> Products { get;set; }
        public virtual DbSet<Category> Categories { get;set; }
    }
}
