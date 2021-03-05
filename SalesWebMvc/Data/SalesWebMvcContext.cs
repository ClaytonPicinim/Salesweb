using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SalesWebMvc.Models
{
    public class SalesWebMvcContext : DbContext
    {
        public SalesWebMvcContext(DbContextOptions<SalesWebMvcContext> options)
            : base(options)
        {
        }
        //LInha original, abaixo o SalesWebMVC.Models foi apagado por conta do namespace ja ser ser esse nome,
        //tornando desnecessário a declaração
        //public DbSet<SalesWebMvc.Models.Department> Department { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }



    }
}
