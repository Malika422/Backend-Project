using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome1.Models
{
    public class TeacherContact
    {
        public int Id { get; set; }
        public string MailMe { get; set; }
        public string MakeACall { get; set; }
        public string Skype { get; set; }
        public bool IsDeleted { get; set; }
    }
}

