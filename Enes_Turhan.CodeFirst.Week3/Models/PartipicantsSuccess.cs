using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Enes_Turhan.CodeFirst.Week3.Models
{
    public class PartipicantsSuccess
    {
        public int Id { get; set; }
        public float PartipicantSuccess { get; set; }
        public int PartipicantsId { get; set; }
        public Participants Participants { get; set; }
      
        

    }
}
