using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace WebAPIDatabase.Models
{
    public class DbContextClass : DbContext
    {
        public  DbContextClass(DbContextOptions<DbContextClass> options) : base(options){}
        public DbSet<CountryClass> countries { get; set; }
    }
}
