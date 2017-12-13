using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.Abstract
{
    public interface IImageRepository
    {
        IQueryable<Image> Images { get; }

        void Save(Image image);

        Image GetImageById(long id);

        bool Remove(int id);
    }
}
