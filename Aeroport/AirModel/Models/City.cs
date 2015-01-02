using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AirModel.Models
{
    public class City : IGenericModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual List<Flight> Flights { get; set; }
    }
}