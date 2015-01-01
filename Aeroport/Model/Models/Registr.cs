using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Model.Models
{
    public class Registr
    {
        public int Id { get; set; }
        public string Topic { get; set; }
        public string Text { get; set; }

        public virtual DispatcherRequest Request { get; set; }
        public virtual Registr Registrs { get; set; }
    }
}