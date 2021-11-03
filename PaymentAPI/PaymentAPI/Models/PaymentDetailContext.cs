using Microsoft.EntityFrameworkCore; // Using para o DbContext
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentAPI.Models
{
    // Heranca de DbContext
    public class PaymentDetailContext : DbContext
    {
        // Construtor para o DbContext
        public PaymentDetailContext(DbContextOptions<PaymentDetailContext> options):base(options)
        {
        }

        // Propriedade criada
        public DbSet<PaymentDetail> PaymentDetails { get; set; }
    }
}
