using Microsoft.AspNetCore.Mvc;
using PttLesson07Models.Models.DataModels;

namespace PttLesson07Models.Controllers
{
    public class PttMemberController : Controller
    {
        // Mock Data
        protected static List<PttMember> _members = new List<PttMember>
        {
            new PttMember
            {
                PttMemberId = Guid.NewGuid().ToString(),
                PttUserName = "tuandz",
                PttPassword = "123456",
                PttFullName = "Phạm Tiến Tuân",
                PttEmail = "phamtientuan@example.com"
            },
            new PttMember
            {
                PttMemberId = Guid.NewGuid().ToString(),
                PttUserName = "tranthibinh",
                PttPassword = "123456",
                PttFullName = "Trần Thị Bình",
                PttEmail = "tranthibinh@example.com"
            },
            new PttMember
            {
                PttMemberId = Guid.NewGuid().ToString(),
                PttUserName = "levancuong",
                PttPassword = "123456",
                PttFullName = "Lê Văn Cường",
                PttEmail = "levancuong@example.com"
            },
            new PttMember
            {
                PttMemberId = Guid.NewGuid().ToString(),
                PttUserName = "phamthiduyen",
                PttPassword = "123456",
                PttFullName = "Phạm Thị Duyên",
                PttEmail = "phamthiduyen@example.com"
            },
            new PttMember
            {
                PttMemberId = Guid.NewGuid().ToString(),
                PttUserName = "hoangminhduc",
                PttPassword = "123456",
                PttFullName = "Hoàng Minh Đức",
                PttEmail = "hoangminhduc@example.com"
            }
        };

        public IActionResult Index()
        {
            return View(_members);
        }

        public IActionResult GetMember()
        {
            var member = new PttMember
            {
                PttMemberId = Guid.NewGuid().ToString(),
                PttUserName = "tuandz",
                PttPassword = "password123",
                PttFullName = "Phạm Tiến Tuân",
                PttEmail = "phamtientuan@gmail.com"
            };

            //ViewBag.Member = member;
            return View(member);
        }

        // Đưa dữ liệu dạng List ra View
        public IActionResult GetMembers()
        {
            // Lấy từ mock data
            ViewBag.Members = _members;
            return View();
        }

        // GET: Create member
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Create member
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(PttMember member)
        {
            if (ModelState.IsValid)
            {
                member.PttMemberId = Guid.NewGuid().ToString();
                _members.Add(member);
                return RedirectToAction(nameof(Index));
            }

            return View(member);
        }
    }
}