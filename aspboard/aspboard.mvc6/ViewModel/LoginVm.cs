using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace aspboard.mvc6.ViewModel
{
    public class LoginVm
    {
        //로그인 할때만 사용할 view model
        [Required(ErrorMessage = "사용자 id를 입력하세요. ")]
        public string UserId { get; set; }

        [Required(ErrorMessage = "사용자 password를 입력하세요.") ]
        public string UserPw { get; set; }
    }
}
