using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class StudentDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int STT { get; set; }
        public int GroupId { get; set; }

        public StudentDTO(int id, string firstName, string lastName, int stt, int groupId)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            STT = stt;
            GroupId = groupId;
        }

        public StudentDTO() { }
    }
}
