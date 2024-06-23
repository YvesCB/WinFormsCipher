using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsCipher
{
    public class CipherEntry
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public DateTime Timestamp { get; set; }
        public string PlainText { get; set; }
        public string CipherText { get; set; }
        public string Key {  get; set; }
    }

    public class CipherContext : DbContext
    {
        public DbSet<CipherEntry> CipherEntries { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Change Serer name as needed!!!
            optionsBuilder.UseSqlServer("Server=DESKTOP-KPQVB74\\SQLEXPRESS;Database=Cipher;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CipherEntry>()
                .HasKey(c => c.Id);  // Specify Id as the primary key
        }
    }
}