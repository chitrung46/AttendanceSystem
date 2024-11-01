using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Image
    {
        private int id;
        private string imageURL;

        public Image(int id, string imageURL)
        {
            this.id = id;
            this.imageURL = imageURL;
        }

        public Image() { }
        public int Id { get => id; set => id = value; }
        public string ImageURL { get => imageURL; set => imageURL = value; }
    }
}
