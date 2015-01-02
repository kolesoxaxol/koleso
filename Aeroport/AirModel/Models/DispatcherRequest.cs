using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AirModel.Models
{
    public class DispatcherRequest : IGenericModel
    {
        public int Id { get; set; }
        public string Topic { get; set; }
        public string Body { get; set; }

        public virtual Register Registr { get; set; }
        public virtual User User { get; set; }
    }
}