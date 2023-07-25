using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectOne.DbCon;
using ProjectOne.Models;

namespace ProjectOne.Controllers
{
    public class ExamController : Controller
    {
        private readonly MvcDbContext _context;

        public ExamController(MvcDbContext context)
        {
            _context = context;
        }

        // GET: ExamController
        public ActionResult Index()
        {
            var data = _context.Exams.ToList();
            return View(data);
        }

        // GET: ExamController/Details/5
        public ActionResult Details(int id)
        {
            var data = _context.Exams.Find(id);
            return View(data);
        }

        // GET: ExamController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ExamController/Create
        [HttpPost]
        public ActionResult Create(Exam exam)
        {
            if (!ModelState.IsValid)
            {
                return View(exam);
            }
            _context.Exams.Add(exam);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        // GET: ExamController/Edit/5
        public ActionResult Edit(int id)
        {
            var data = _context.Exams.Find(id);
            return View(data);
        }

        // POST: ExamController/Edit/5
        [HttpPost]
        public ActionResult Edit(Exam exam)
        {
            if (!ModelState.IsValid)
            {
                return View(exam);
            }
            _context.Entry(exam).State = EntityState.Modified;
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        // GET: ExamController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_context.Exams.Find(id));
        }

        // POST: ExamController/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            var exam = _context.Exams.Find(id);
            if (exam != null)
            {
                _context.Exams.Remove(exam);
                _context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            return View();
        }
    }
}
