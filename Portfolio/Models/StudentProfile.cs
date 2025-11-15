using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Portfolio.Models
{
    public class StudentProfile
    {
        public int Id { get; set; }

        // Información personal
        public string FullName { get; set; }
        public string Title { get; set; } // Ej: "Estudiante de Ingeniería en Sistemas".
        public string Summary { get; set; } // Breve descripción profesional.

        // Información de contacto
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Location { get; set; }

        // Imagen o avatar
        public string ProfileImageUrl { get; set; }

        public virtual ICollection<Education> Education { get; set; }
        public virtual ICollection<Experience> Experience { get; set; }
        public virtual ICollection<Skills> Skills { get; set; }
        public virtual ICollection<Projects> Projects { get; set; }
        public virtual ICollection<SocialLink> SocialLinks { get; set; }
    }
}