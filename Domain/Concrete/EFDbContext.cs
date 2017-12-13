using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.Concrete
{
    public class EFDbContext : DbContext
    {
        public EFDbContext() : base("ImageGallery") { }

        public DbSet<Image> Images { get; set; }
    }
}
