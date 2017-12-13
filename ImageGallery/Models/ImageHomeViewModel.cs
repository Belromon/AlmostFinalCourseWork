using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Domain.Entities;

namespace ImageGallery.Models
{
    public class ImageHomeViewModel
    {
        public IEnumerable<Image> Images { get; set; }

        public ImagePageInfo PagingInfo { get; set; }
    }
}