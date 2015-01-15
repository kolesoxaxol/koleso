using AirModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AirModel.SiteLocalization
{

        public class Language : IGenericModel
        {

            public string Code { get; set; }

            public string Name { get; set; }

            [Key]
            public int Id { get; set; }

        }
   
}
