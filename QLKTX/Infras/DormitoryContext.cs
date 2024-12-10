using QLKTX.Domains.Entities;
using System.Data.Entity;

namespace QLKTX.Infras
{
    public class DormitoryContext : DbContext
    {

        public DormitoryContext() : base("name=DormitoryConnection")
        {

        }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<InvoiceDetail> InvoiceDetails { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Room> Rooms { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Invoice>()
                .HasKey(i => i.Id)
                .ToTable("Invoices");

            modelBuilder.Entity<Invoice>()
                .HasMany(i => i.InvoiceDetails)
                .WithRequired()
                .HasForeignKey(d => d.InvoiceId)
                .WillCascadeOnDelete(true);

            modelBuilder.Entity<InvoiceDetail>()
                .HasKey(d => d.Id)
                .ToTable("InvoiceDetails");

            modelBuilder.Entity<InvoiceDetail>()
                .Property(d => d.Quantity)
                .IsRequired();

            modelBuilder.Entity<InvoiceDetail>()
                .Property(d => d.UnitPrice)
                .IsRequired()
                .HasPrecision(18, 2);

            modelBuilder.Entity<Service>()
                .HasKey(s => s.Id)
                .ToTable("Services");

            modelBuilder.Entity<Student>()
                .HasKey(s => s.Id)
                .ToTable("Students");

            modelBuilder.Entity<Room>()
                .HasKey(r => r.Id)
                .ToTable("Rooms");

            modelBuilder.Entity<Student>()
                .HasRequired(s => s.Room)
                .WithMany(r => r.Students)
                .HasForeignKey(s => s.RoomId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
