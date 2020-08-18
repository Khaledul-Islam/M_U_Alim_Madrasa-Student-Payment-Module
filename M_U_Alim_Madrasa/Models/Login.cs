using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace M_U_Alim_Madrasa.Models
{
    public class Login
    {
        public int ID { get; set; }

        [Required]
        public string Username { get; set; }
        [Required]
        public string UserType { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
