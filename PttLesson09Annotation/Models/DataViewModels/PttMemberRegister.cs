using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PttLesson09Annotation.Models.DataViewModels
{
    public class PttMemberRegister
    {
        public int PttMemberId { get; set; }

        [DisplayName("Tên đăng nhập")]
        [Required(ErrorMessage = "Tên đăng nhập không để trống")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Tên đăng nhập có độ dài trong khoảng 2 - 20 ký tự")]
        public string PttUserName { get; set; }

        [DisplayName("Mật khẩu")]
        [Required(ErrorMessage = "Mật khẩu không được để trống")]
        [DataType(DataType.Password)]
        public string PttPassword { get; set; }

        public string PttEmail { get; set; }

        public string PttPhoneNumber { get; set; }

        public string PttFullName { get; set; }

        public DateTime PttBirthday { get; set; }
    }
}