using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Enes_Turhan.CodeFirst.Week3.Models
{
    public class Students
    {
        public int Id { get; set; }
        public string StudentName { get; set; }
        public string StudentSurname { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public ICollection<Courses> Courses { get; set; }
    }
}
