using System.ComponentModel.DataAnnotations;

namespace aspboard.mvc6.Models
{
    public class User
    {
        /// <summary>
        /// 사용자 번호
        /// </summary>
        [Key] // pk 기본키
        public int UserNo { get; set; }

        /// <summary>
        /// 사용자 이름
        /// </summary>
        [Required(ErrorMessage ="please input ID")] // not null
        public string UserName { get; set; }

        /// <summary>
        /// 사용자 아이디
        /// </summary>
        [Required(ErrorMessage ="please input PW")] // not null
        public string UserId { get; set; }

        /// <summary>
        /// 사용자 패스워드
        /// </summary>
        [Required(ErrorMessage ="please input NAME")] // not null
        public string UserPw { get; set; }
    }
}
