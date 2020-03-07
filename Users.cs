using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryAPI
{
    public class Users
    {
        [Key]
        public Guid UserID { get; set; }

        public string Name { get; set; }

        public DateTime DOB { get; set; }

        public ICollection<Books> books { get; set; }
    }
}
