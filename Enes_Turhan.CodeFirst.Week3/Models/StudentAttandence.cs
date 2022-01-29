using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Enes_Turhan.CodeFirst.Week3.Models
{
    public class StudentAttandence
    {
        public int Id { get; set; }
        public int ParticipantId { get; set; }
        public Participants Participants { get; set; }
        public int CourseId { get; set; }
        public Courses Courses { get; set; }
        public int WeekId { get; set; }
        public Weeks Weeks { get; set; }
        public bool AttendanceState { get; set; }
    }
}
