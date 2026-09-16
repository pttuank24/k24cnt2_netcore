
using System.ComponentModel;

namespace PttLesson08Models.Models
{
    public class PttMember
    {
        public string PttMemberId { get; set; }
        public string PttUserName { get; set; }
        public string PttPassword { get; set; }

        [DisplayName("Họ và tên")]
        public string PttFullName { get; set; }
        public string PttEmail { get; set; }
    }
}

