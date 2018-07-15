using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using SQLite.CodeFirst;

namespace Provider.Data
{
    public class DataContext:DbContext
    {
        public DataContext(SQLiteConnectionStringBuilder sQLiteConnection) :
        base(new SQLiteConnection()
        {
            ConnectionString = sQLiteConnection.ConnectionString
        }, true)
        {
        }
        public DataContext() :
        base(new SQLiteConnection()
        {

            ConnectionString = new SQLiteConnectionStringBuilder()
            {
                DataSource = ".\\DataContext.db",
                ForeignKeys = true,
                Password="1234"
            }.ConnectionString
        }, true)
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Entity<Stock>()
            .HasOptional(f => f.Product)
            .WithRequired(s => s.Stock);
            base.OnModelCreating(modelBuilder);
        
            
        

        }
        public DbSet<Invoice> Invoices { get; set; }

        public DbSet<Client> Clients { get; set; }

        public DbSet<Vendor> Vendors { get; set; }

        public DbSet<Payment> Payments { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Stock> Stock { get; set; }

        public DbSet<Purchase> Purchases { get; set; }

        public DbSet<CreditNote> CreditNotes { get; set; }

        public DbSet<PurchaseReturn> PurchaseReturns { get; set; }










    }
}
