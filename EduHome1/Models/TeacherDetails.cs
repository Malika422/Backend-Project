using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome1.Models
{
    public class TeacherDetails
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Degree { get; set; }
        public string Experience { get; set; }
        public string Hobbies { get; set; }
        public string Faculty { get; set; }
        public bool IsDeleted { get; set; }

        [ForeignKey("Teachers")]
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
        public TeacherSkills TeacherSkills { get; set; }
    }
}
