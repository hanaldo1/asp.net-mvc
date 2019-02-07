using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace aspboard.mvc6.Models
{
    public class Board
    {
        /// <summary>
        /// 게시물 번호
        /// </summary>
        [Key] // 기본키
        public int BoardNo { get; set; }

        /// <summary>
        /// 게시물 제목
        /// </summary>
        [Required] // not null
        public string BoardTitle { get; set; }

        /// <summary>
        /// 게시물 내용
        /// </summary>
        [Required] // not null
        public string BoardContents { get; set; }

        /// <summary>
        /// 작성자 번호
        /// </summary>
        [Required] // not null
        public int UserNo { get; set; }

        [ForeignKey("UserNo")] // User 에서 UserNo가 외래키
                               // 임을 알려줌
        public virtual User User {get; set;}
    }
}
