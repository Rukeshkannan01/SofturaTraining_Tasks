using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ProductEntityFw.Models
{
    public class CustDBContext : DbContext
    {
        public CustDBContext()
        {

        }
        public CustDBContext(DbContextOptions<CustDBContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-5BF33K3;Database=Trial;Integrated Security=True");
        }
        public virtual DbSet<Customer> Customers { get; set; }
    }
}
