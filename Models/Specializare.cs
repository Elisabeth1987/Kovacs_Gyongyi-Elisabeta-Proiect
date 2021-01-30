using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kovacs_Gyongyi_Elisabeta_Proiect.Models
{
    public class Specializare
    {
        public int ID { get; set; }

        [Display(Name = "Nume Specializare ")]
        public string Nume_Specializare { get; set; }
        public ICollection<Student> Studenti { get; set; }
    }
}
