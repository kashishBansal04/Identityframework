using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestIdentityFramework.Models;

namespace TestIdentityFramework.Context
{
    public class TestIdentitycontext : IdentityDbContext
    {
        public TestIdentitycontext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
    }
}
