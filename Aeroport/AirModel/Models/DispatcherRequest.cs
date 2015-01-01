using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AirModel.Models
{
    public class DispatcherRequest
    {
        public int Id { get; set; }
        public string Topic { get; set; }
        public string Body { get; set; }

        public virtual Registr Registr { get; set; }
        public virtual User User { get; set; }
    }
}