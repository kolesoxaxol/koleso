using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AirModel.Models
{
    public class Register : IGenericModel
    {
        public int Id { get; set; }
        public string Topic { get; set; }
        public string Text { get; set; }

        public virtual DispatcherRequest Request { get; set; }
        public virtual Register Registrs { get; set; }
    }
}