using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace WebAppInAzureWithDatabase.Models
{
    public class MemeContextClass : DbContext
    {
        public MemeContextClass(DbContextOptions<MemeContextClass> options) : base(options) { }
        public DbSet<MemeDialouges> dialogues { get; set; }
    }
}
