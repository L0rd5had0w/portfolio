using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Portfolio.Models
{
    public class Education
    {
        public int Id { get; set; }
        public string Institution { get; set; }
        public string Degree { get; set; } // Ejemplo: "Ingeniería en Sistemas"
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; } // null = en curso

        //Relación con entidad StudentProfile
        public int StudentProfileId { get; set; }
        public StudentProfile StudentProfile { get; set; }
    }
}