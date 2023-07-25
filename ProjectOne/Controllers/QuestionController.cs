using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectOne.DbCon;
using ProjectOne.Models;

namespace ProjectOne.Controllers
{
    public class QuestionController : Controller
    {
        private readonly MvcDbContext _context;

        public QuestionController(MvcDbContext context)
        {
            _context = context;
        }
        // GET: QuestionController
        public ActionResult Index()
        {
            var question = _context.Question.ToList();
            return View(question);
        }

        // GET: QuestionController/Details/5
        public ActionResult Details(int id)
        {
            var data = _context.Question.Find(id);
            return View(data);
        }

        // GET: QuestionController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: QuestionController/Create
        [HttpPost]
        public ActionResult Create(Question question)
        {
            if (!ModelState.IsValid)
            {
                return View(question);
                
            }
            _context.Question.Add(question);
            _context.SaveChanges();

            return View(nameof(Index));
        }

        // GET: QuestionController/Edit/5
        public ActionResult Edit(int id)
        {
            var question = _context.Question.Find(id);
            return View(question);
        }

        // POST: QuestionController/Edit/5
        [HttpPost]
        public ActionResult Edit(Question question)
        {
            if (!ModelState.IsValid)
            {
                return View(question);
            }
            _context.Entry(question).State = EntityState.Modified;
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        // GET: QuestionController/Delete/5
        public ActionResult Delete(int id)
        {
            var question = _context.Question.Find(id);
            return View(question);
        }

        // POST: QuestionController/Delete/5
        [HttpPost, ActionName("Index")]
        public ActionResult DeleteConfirmed(int id)
        {
            var question = _context.Question.Find(id);
            if (question != null)
            {
                _context.Question.Remove(question);
                _context.SaveChanges();
                return View(nameof(Index));
                
            }
            return View();
        }
    }
}
