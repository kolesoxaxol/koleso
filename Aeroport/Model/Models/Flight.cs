﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Model.Models
{
    public class Flight
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual AirPlane AirPlane { get; set; }
        public virtual City Source { get; set; }
        public virtual City Destination { get; set; }

    }
}