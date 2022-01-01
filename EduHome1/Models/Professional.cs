using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome1.Models
{
    public class Professional
    {
        public int Id { get; set; }
        public string ProfessionalName { get; set; }
        public bool IsDeleted { get; set; }
        public ICollection<TeacherProfessional> TeacherProfessional { get; set; }
    }
}
