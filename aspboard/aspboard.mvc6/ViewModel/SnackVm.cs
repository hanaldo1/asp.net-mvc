using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace aspboard.mvc6.ViewModel
{
    public class SnackVm
    {
        [Required(ErrorMessage = "간식의 이름을 입력해주세요.")]
        public string SnackName { get; set; }

        [Required(ErrorMessage = "간식의 가격을 입력해주세요.")]
        public int SnackPrice { get; set; }
    }
}
