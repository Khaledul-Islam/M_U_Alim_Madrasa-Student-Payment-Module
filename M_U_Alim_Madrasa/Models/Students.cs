using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace M_U_Alim_Madrasa.Models
{
    public class Students
    {
        public int ID { get; set; }
        [Required]
        public string Roll { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string BloodGroup { get; set; }
        [Required]
        public string Class { get; set; }
        [Required]
        public string Section { get; set; }
        [Required]
        public double JSCResult { get; set; }
        [Required]
        public double SSCResult { get; set; }
        [Required]
        public string BirthDate { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Mobile { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string FatherName { get; set; }
        [Required]
        public string MotherName { get; set; }
        [Required]
        public string GardianMobile { get; set; }



    }
}
