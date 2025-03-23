using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Models
{
    public class Enroll
    {
        public int Id { get; set; }
        public int? StudentId { get; set; }
        [NotMapped]
        public Student? Student { get; set; }
        [NotMapped]
        public Session? Session { get; set; }
        public int? GradeId { get; set; }
        public Grade? Grade { get; set; }

    }
}
