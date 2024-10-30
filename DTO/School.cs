using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class School
    {
        private int id;
        private string schoolName;

        public School () { }

        public School(int id, string schoolName)
        {
            this.id = id;
            this.schoolName = schoolName;
        }

        public int Id { get => id; set => id = value; }
        public string SchoolName { get => schoolName; set => schoolName = value; }
    }
}
