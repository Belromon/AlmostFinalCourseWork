using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Domain.Abstract;
using Domain.Concrete.Entities;
using Domain.Entities;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;

namespace Domain.Concrete.Repositories
{
    public class EFImageRepository : IImageRepository
    {
        private readonly EFDbContext _context;
       // private readonly AppUserManager UserManager;

       

        public EFImageRepository(EFDbContext context)
        {
            _context = context;
        }

     

        public IQueryable<Image> Images => _context.Images;

        public void Save(Image image)
        {
            if (image.Id == 0)
            {
                _context.Images.Add(image);
            }
            else
            {
                Image dbEntry = _context.Images.Find(image.Id);//

                if (dbEntry != null)
                {
                    dbEntry.Id = image.Id;
                    dbEntry.Data = image.Data;
                    dbEntry.CompressedData = image.CompressedData;
                    dbEntry.MimeType = image.MimeType;
                    dbEntry.Description = image.Description;
                    dbEntry.Price = image.Price;
                    //dbEntry.UserId = image.UserId;
                }
            }

            _context.SaveChanges();
        }

        public Image GetImageById(long id) => (from u in _context.Images
            where u.Id == id
            select u).FirstOrDefault();

        public bool Remove(int id)
        {
            var image = _context.Images.FirstOrDefault(u => u.Id == id);

            if (image == null)
                return false;

            _context.Images.Remove(image);
            _context.SaveChanges();

            return true;
        }
    }
}
