using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Model.Models
{
    public class Position
    {
        public int Id { get; set; }
        public string Name { get; set;}

        public virtual List<Crew> Crews { get; set; }
    }
}
