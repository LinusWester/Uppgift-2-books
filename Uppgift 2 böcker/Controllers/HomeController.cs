using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Uppgift_2_böcker.Controllers
{
    public class Books
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Info { get; set; }
    }
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            return View();
        }

        [HttpGet]
        public ActionResult GetBook(int Id)
        {
            IList<Books> booklist = new List<Books>
            {
                new Books { Id = 1, Title = "Hobbit", Author = "J.R.R Tolkien", Info = "The Hobbit is set within Tolkien's fictional universe and follows the quest of home-loving Bilbo Baggins" },
                new Books { Id = 2, Title = "The lord of the Rings", Author = "J.R.R Tolkien", Info = "The Lord of the Rings is an epic high fantasy novel[ by the English author and scholar J. R. R. Tolkien. Set in Middle-earth," },
                new Books { Id = 3, Title = "Fool's Errand", Author = "Robin Hobb", Info = "Fifteen years have passed since the end of the Red Ship War with the terrifying Outislanders." },
                new Books { Id = 4, Title = "Fool's Fate", Author = "Robin Hobb", Info = "Once assassin to the king, Fitz is now Skillmaster to Prince Dutiful's small band, sailing towards the distant Out Island of Aslevjal." }
            };
            var selectedBook = booklist.Where(o => o.Id == Id).FirstOrDefault();

            if (selectedBook == null)
                return new HttpStatusCodeResult(204);

            return new JsonResult { Data = selectedBook, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }

        [HttpGet]
        public ActionResult GetAllBooks()
        {
            IList<Books> booklist = new List<Books>
            {
                new Books { Id = 1, Title = "Hobbit", Author = "J.R.R Tolkien", Info = "The Hobbit is set within Tolkien's fictional universe and follows the quest of home-loving Bilbo Baggins" },
                new Books { Id = 2, Title = "The lord of the Rings", Author = "J.R.R Tolkien", Info = "The Lord of the Rings is an epic high fantasy novel[ by the English author and scholar J. R. R. Tolkien. Set in Middle-earth," },
                new Books { Id = 3, Title = "Fool's Errand", Author = "Robin Hobb", Info = "Fifteen years have passed since the end of the Red Ship War with the terrifying Outislanders." },
                new Books { Id = 4, Title = "Fool's Fate", Author = "Robin Hobb", Info = "Once assassin to the king, Fitz is now Skillmaster to Prince Dutiful's small band, sailing towards the distant Out Island of Aslevjal." }
            };

            return new JsonResult { Data = booklist, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }
        
        [HttpPost]
        public ActionResult CreateBook(Books book)
        {
            IList<Books> booklist = new List<Books>();
            {
                booklist.Add(book);
                return new HttpStatusCodeResult(200);
            }
        }

        [HttpDelete]
        public ActionResult DeleteBook(int Id)
        {
            IList<Books> booklist = new List<Books>
            {
                new Books { Id = 1, Title = "Hobbit", Author = "J.R.R Tolkien", Info = "The Hobbit is set within Tolkien's fictional universe and follows the quest of home-loving Bilbo Baggins" },
                new Books { Id = 2, Title = "The lord of the Rings", Author = "J.R.R Tolkien", Info = "The Lord of the Rings is an epic high fantasy novel[ by the English author and scholar J. R. R. Tolkien. Set in Middle-earth," },
                new Books { Id = 3, Title = "Fool's Errand", Author = "Robin Hobb", Info = "Fifteen years have passed since the end of the Red Ship War with the terrifying Outislanders." },
                new Books { Id = 4, Title = "Fool's Fate", Author = "Robin Hobb", Info = "Once assassin to the king, Fitz is now Skillmaster to Prince Dutiful's small band, sailing towards the distant Out Island of Aslevjal." }
            };
            var selectedBook = booklist.Where(o => o.Id == Id).FirstOrDefault();

            if (selectedBook == null)
                return new HttpStatusCodeResult(204);

                booklist.Remove(selectedBook);
                return new HttpStatusCodeResult(200);
        }

    }
}
