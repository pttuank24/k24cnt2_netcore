using Microsoft.AspNetCore.Mvc;
using PttLesson09Annotation.Models.DataModels;
using PttLesson09Annotation.Models.DataViewModels;

namespace PttLesson09Annotation.Controllers
{
    public class PttMemberController : Controller
    {
        private static List<PttMember> _pttMembers = new List<PttMember>();

        // GET: PttMemberController
        public ActionResult Index()
        {
            return View(_pttMembers);
        }

        // GET: PttMemberController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PttMemberController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PttMemberController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PttMemberRegister pttMember)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PttMemberController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PttMemberController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PttMemberController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PttMemberController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}