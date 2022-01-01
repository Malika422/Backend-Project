using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome1.Models
{
    public class TeacherSkills
    {
        public int Id { get; set; }
        public string Language { get; set; }
        public string Design { get; set; }
        public string TeamLeader { get; set; }
        public string Innovation { get; set; }
        public string Development { get; set; }
        public string Communication { get; set; }
        public bool IsDeleted { get; set; }
        public TeacherDetails TeacherDetails { get; set; }
        public int TeacherDetailsId { get; set; }

    }
}
