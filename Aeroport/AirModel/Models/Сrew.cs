using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AirModel.Models
{
    public class Crew
    {
        public int Id { get; set; }
        public string Name {get;set;}
        public string Surname { get; set;}
        public string LastName { get; set; }

        public virtual Flight Flight { get; set; }
        public virtual List<Position> Positions { get; set; }
    }
}