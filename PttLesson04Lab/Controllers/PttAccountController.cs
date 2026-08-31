using Microsoft.AspNetCore.Mvc;
using PttLesson04Lab.Models;

namespace PttLesson04Lab.Controllers
{
    public class PttAccountController : Controller
    {
        private readonly List<PttAccount> pttAccounts = new()
        {
           
              new PttAccount
                {
                    Id = 1,
                    Name = "Nguyễn Văn An",
                    Email = "nguyenan@gmail.com",
                    Phone = "0901234567",
                    Avatar = "/images/1.jpg",
                    Address = "Hà Nội",
                    Bio = "Sinh viên ngành Công nghệ thông tin",
                    Gender = 1,
                    Birthday = new DateTime(2004, 5, 12)
                },

                new PttAccount
                {
                    Id = 2,
                    Name = "Trần Thị Bình",
                    Email = "tranbinh@gmail.com",
                    Phone = "0912345678",
                    Avatar = "/images/2.jpg",
                    Address = "Hải Phòng",
                    Bio = "Nhân viên văn phòng",
                    Gender = 0,
                    Birthday = new DateTime(2003, 8, 25)
                },

                new PttAccount
                {
                    Id = 3,
                    Name = "Lê Hoàng Nam",
                    Email = "lenam@gmail.com",
                    Phone = "0923456789",
                    Avatar = "/images/3.jpg",
                    Address = "Đà Nẵng",
                    Bio = "Lập trình viên .NET",
                    Gender = 1,
                    Birthday = new DateTime(2001, 3, 18)
                },

                new PttAccount
                {
                    Id = 4,
                    Name = "Phạm Thu Hà",
                    Email = "phamha@gmail.com",
                    Phone = "0934567890",
                    Avatar = "/images/4.jpg",
                    Address = "Hồ Chí Minh",
                    Bio = "Thiết kế đồ họa",
                    Gender = 0,
                    Birthday = new DateTime(2002, 11, 7)
                },

                new PttAccount
                {
                    Id = 5,
                    Name = "Đỗ Minh Quân",
                    Email = "doquan@gmail.com",
                    Phone = "0945678901",
                    Avatar = "/images/5.jpg",
                    Address = "Hà Nội",
                    Bio = "Kỹ sư phần mềm",
                    Gender = 1,
                    Birthday = new DateTime(1999, 7, 21)
                },
        };
        public IActionResult PttIndex()
        {
            ViewBag.PttAccounts = pttAccounts;
            return View();
        }

        [Route("ho-so-cua-toi",Name ="PttProfile")]

        public IActionResult PttProfile(int? id)
        {

            PttAccount pttAccount = new PttAccount()
            {
                Id = 5,
                Name = "Đỗ Minh Quân",
                Email = "doquan@gmail.com",
                Phone = "0945678901",
                Avatar = "/images/5.jpg",
                Address = "Hà Nội",
                Bio = "Kỹ sư phần mềm",
                Gender = 1,
                Birthday = new DateTime(1999, 7, 21)
            };
            if (id  != null)
             pttAccount = pttAccounts.FirstOrDefault(x => x.Id == id) ;
            ViewBag.PttAccount = pttAccount;
            return View();
        }
    }
}
