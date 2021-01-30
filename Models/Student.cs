using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kovacs_Gyongyi_Elisabeta_Proiect.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }

        [Display(Name = "Data nasterii")]
        public DateTime Data_nasterii { get; set; }
        public string Oras { get; set; }
        public int SpecializareID { get; set; }
        public Specializare Specializare { get; set; }
    

        [Display(Name = "Forma de invatamant")]
        public string Forma_de_invatamant { get; set; }

        public int CicluID { get; set; }
        public Ciclu Ciclu { get; set; }


    }
}
