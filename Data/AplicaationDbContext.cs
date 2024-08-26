using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Library_System.Models;
using Microsoft.EntityFrameworkCore;

namespace Library_System.Data
{
    public class AplicaationDbContext : DbContext
    {
        public DbSet<DocumentType> DocumentTypes { get; set; }
        public AplicaationDbContext(DbContextOptions<AplicaationDbContext> options) : base(options)
        {
        }
    }
}