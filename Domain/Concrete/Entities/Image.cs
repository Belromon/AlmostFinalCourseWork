using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Concrete.Entities;

namespace Domain.Entities
{
    public class Image
    {
        [Key]
        public int Id { get; set; }

        public byte[] Data { get; set; }

        public byte[] CompressedData { get; set; }

        public string Title { get; set; }

        public string MimeType { get; set; }

        public string Description { get; set; }

        public double Price { get; set; }

        //[ForeignKey("User")]
        //public string UserId { get; set; }
      
        //public AppUser User { get; set; }
    }
}
