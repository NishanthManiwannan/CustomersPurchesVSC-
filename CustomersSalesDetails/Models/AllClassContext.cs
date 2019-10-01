using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomersSalesDetails.Models
{
    public class AllClassContext : DbContext
    {
        public AllClassContext(DbContextOptions<AllClassContext> options) : base (options) {}

        public DbSet<CustomerDetails> customerDetails { get; set; }
        public DbSet<ItemsDetails> itemsDetails { get; set; }
        public DbSet<Invoice> invoices { get; set; }
        public DbSet<InvoicTwo> invoicTwos { get; set; }
    }
}
