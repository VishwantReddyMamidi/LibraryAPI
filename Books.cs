using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryAPI
{
    public class Books
    {
        [Key]
        public Guid BookID {get;set;}
               
        public string Name { get; set; }

        public string ISBN { get; set; }

        public DateTime PublishedDate { get; set; }

        public Guid UserID { get; set; }
        public Users user { get; set; }

    }
}
