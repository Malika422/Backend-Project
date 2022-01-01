using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome1.Models
{
    public class Teacher    
    {
        public int Id { get; set; }

        [Required,MaxLength(50)]
        public string TeacherName { get; set; }
        public string TeacherImage { get; set; }

        [ForeignKey("Teacher")]
        public TeacherDetails TeacherDetails { get; set; }
        public bool IsDeleted { get; set; }
        public ICollection<TeacherProfessional> TeacherProfessional { get; set; }
 
    }
}
