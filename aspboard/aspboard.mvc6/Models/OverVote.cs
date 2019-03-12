using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace aspboard.mvc6.Models
{
    public class OverVote
    {
        [Key]
        public int OverNo { get; set; }

        [Required] // not null
        public int UserNo { get; set; }
        [ForeignKey("UserNo")]
        public virtual User User { get; set; }

        [Required] // not null
        public int SnackNo { get; set; }
        [ForeignKey("SnackNo")]
        public virtual Snack Snack { get; set; }
    }
}
