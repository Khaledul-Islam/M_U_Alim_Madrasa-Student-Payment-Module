using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace M_U_Alim_Madrasa.Models
{
    public class Payment
    {
        public int ID { get; set; }
        [Required]
        public string Roll { get; set; }
        [Required]
        public double TuitionFees { get; set; }
        public double AdmissionFees { get; set; }
        public double HealthFees { get; set; }
        public double SportsFees { get; set; }
        public double ExamFees { get; set; }
        public double Others { get; set; }
        public double Total { get; set; }
        public double Due { get; set; }
        public double Paid { get; set; }
        public string Date { get; set; }



    }
}
