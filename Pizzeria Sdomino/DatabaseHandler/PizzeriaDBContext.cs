using DatabaseHandler.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseHandler
{
    public class PizzeriaDBContext : DbContext
    {
        public PizzeriaDBContext(DbContextOptions<PizzeriaDBContext> options) : base(options)
        {
        }

        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Receipt> Receipts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>(entity =>
            {
                entity.ToTable("Ordini");
                entity.HasOne(o => o.ReceiptId).WithOne(r => r.OrderId).HasForeignKey<Receipt>(r => r.ReceiptId);
                entity.HasKey(o => o.OrderId);
                entity.Property(o => o.BasePizza).HasMaxLength(20).HasColumnName("Base Pizza");
                entity.Property(o => o.Dought).HasMaxLength(20).HasColumnName("Impasto");
                entity.Property(o => o.Toppings).HasMaxLength(50).HasColumnName("Farcitura");
                entity.Property(o => o.OrderId).ValueGeneratedOnAdd().HasColumnName("Id Ordine");
            });
            modelBuilder.Entity<Receipt>(entity =>
            {
                entity.ToTable("Scontrini");
                entity.HasKey(r => r.ReceiptId);
                entity.HasOne(r => r.OrderId).WithOne(o => o.ReceiptId).HasForeignKey<Order>(o => o.OrderId);
                entity.Property(r => r.DateOfOrder).HasDefaultValueSql("(getdate())").HasColumnType("datetime");
                entity.Property(o => o.ReceiptId).ValueGeneratedOnAdd().HasColumnName("Id Scontrino");
            });
        }
    }
}