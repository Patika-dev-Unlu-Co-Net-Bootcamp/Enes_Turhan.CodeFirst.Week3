using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Enes_Turhan.CodeFirst.Week3.Models
{
    public class Courses
    {
        public int Id { get; set; }
        public string CourseName { get; set; }
        public string CourseDescription { get; set; }
        public DateTime CourseStartDate { get; set; }
        public DateTime CourseEndDate { get; set; }
        public int Stock { get; set; }
        public int CourseWeekDuration { get; set; }
        public int CourseHourDuration { get; set; }
        public ICollection<Students> Students { get; set; }
        public ICollection<Participants> Participants { get; set; }
        public ICollection<Assistants> Assistants { get; set; }
        public ICollection<Teachers> Teachers { get; set; }

    }
}
