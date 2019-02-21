using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace aspboard.mvc6.Models
{
    public class Snack
    {
        [Key]
        public int SnackNo { get; set; }

        [Required]
        public string SnackName { get; set; }

        [Required]
        public int SnackPrice { get; set; }

        [Required]
        public int SnackVote { get; set; }
    }
}
