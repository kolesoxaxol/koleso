using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AirModel.Models
{
    public class Flight : IGenericModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual AirPlane AirPlane { get; set; }
        public virtual City Source { get; set; }
        public virtual City Destination { get; set; }

    }
}