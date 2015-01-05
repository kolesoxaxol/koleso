using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.ViewModel
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Name required")]
        public string Name { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Password")]
        public string Password { get; set; }

        public bool IsPersistent { get; set; }
    }
}
