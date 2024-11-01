using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class ImageBLL
    {
        ImageAccess imageAccess = new ImageAccess();    
        public void InsertImage (string imageURL)
        {
            imageAccess.InsertImage (imageURL);
        }

        public Image GetImageByURL (string imageURL)
        {
            return imageAccess.GetImageByURL (imageURL);
        }
    }
}
