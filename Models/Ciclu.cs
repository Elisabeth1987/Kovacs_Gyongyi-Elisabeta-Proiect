using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kovacs_Gyongyi_Elisabeta_Proiect.Models
{
    public class Ciclu
    {
        public int ID { get; set; }
        public string Nume_Ciclu { get; set; }
        public ICollection<Student> Studenti { get; set; }
    }
}
