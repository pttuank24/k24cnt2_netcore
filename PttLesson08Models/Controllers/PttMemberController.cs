using Microsoft.AspNetCore.Mvc;
using PttLesson08Models.Models;

namespace PttLesson08Models.Controllers
{
    public class PttMemberController : Controller
    {
        private static List<PttMember> _members = new List<PttMember>()
        {
            new PttMember
            {
                PttMemberId = Guid.NewGuid().ToString(), 
                PttUserName = "Tuandz", 
                PttPassword = "Password123!", 
                PttFullName = "Phạm Tiến Tuân", 
                PttEmail = "phamtientuan2006@gmail.com"
            },
            new PttMember
            {
                PttMemberId = Guid.NewGuid().ToString(),
                PttUserName = "tranthib",
                PttPassword = "SecurePass456#",
                PttFullName = "Trần Thị Bình",
                PttEmail = "tranthib@outlook.com"
            },
            new PttMember
            {
                PttMemberId = Guid.NewGuid().ToString(),
                PttUserName = "levanc",
                PttPassword = "MyPassword789$",
                PttFullName = "Lê Văn Cường",
                PttEmail = "levanc@company.com"
            }
        };

        public IActionResult Index()
        {
            return View(_members);
        }

        [HttpGet]
        public IActionResult PttCreate()
        {
            var member = new PttMember();
            return View(member);
        }

        [HttpPost]
        public IActionResult PttCreate(PttMember pttMember)
        {
            pttMember.PttMemberId = Guid.NewGuid().ToString();
            _members.Add(pttMember);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult PttEdit(string id)
        {
            var member = _members
                .Where(x => x.PttMemberId.Equals(id))
                .FirstOrDefault();

            return View(member);
        }

        [HttpPost]
        public IActionResult PttEdit(string id, PttMember pttMember)
        {
            for (int i = 0; i < _members.Count; i++)
            {
                if (_members[i].PttMemberId == id)
                {
                    _members[i].PttUserName = pttMember.PttUserName;
                    _members[i].PttPassword = pttMember.PttPassword;
                    _members[i].PttFullName = pttMember.PttFullName;
                    _members[i].PttEmail = pttMember.PttEmail;

                    return RedirectToAction("Index");
                }
            }

            return View();
        }

        [HttpGet]
        public IActionResult PttDetails(string id)
        {
            var member = _members
                .Where(x => x.PttMemberId.Equals(id))
                .FirstOrDefault();

            return View(member);
        }

        [HttpGet]
        public IActionResult PttDelete(string id)
        {
            var member = _members
                .Where(x => x.PttMemberId.Equals(id))
                .FirstOrDefault();

            return View(member);
        }

        [HttpPost]
        public IActionResult PttDeleted(string id)
        {
            foreach (var item in _members)
            {
                if (item.PttMemberId.Equals(id))
                {
                    _members.Remove(item);
                    return RedirectToAction("Index");
                }
            }

            return View("PttDelete");
        }
    }
}