using AirModel.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirModel.SiteLocalization
{
    public class LanguageText
    {
        [Key, Column(Order = 1)]
        public int Id { get; set; } 

        [Key, Column(Order = 2)]
        public int LanguageId { get; set; }

        public string Description { get; set; }

        [ForeignKey("LanguageId")]
        public virtual Language Language { get; set; }

        //[ForeignKey("Id")]
        //public virtual AirPlane AirPlane { get; set; }
    }
}
