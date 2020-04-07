using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace task.Models
{
    public class User
    {
        [Required]
        public String Username { set; get; }

        public int Id { get; set; }

        public string City { get; set; }
        public string Address { get; set; }

        public string SpeakingLanguage { get; set; }
        [DataType(DataType.Date)]
        public DateTime GradeYear { get; set; }
        //public string Access { get; set; }
        [DataType(DataType.Text)]
        public string Comment { get; set; }
    }
}
