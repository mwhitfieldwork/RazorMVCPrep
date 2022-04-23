using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookListWithRazor.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Author { get; set; }

        //if you have to add a new propeduty in a code first model, you will need 
        // to do a migration after
        public string ISBN { get; set; }


    }
}
