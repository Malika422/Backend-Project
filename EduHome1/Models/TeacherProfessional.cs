using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome1.Models
{
    public class TeacherProfessional
    {
        public int Id { get; set; }
        public int TeacherId { get; set; }
        public int ProfessionalId { get; set; }
        public Professional Professional { get; set; }
        public Teacher Teacher { get; set; }
        public bool IsDeleted { get; set; }

    }
}
