using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PustokBookStore.DAL;
using PustokBookStore.Entities;

namespace PustokBookStore.Controllers
{
    public class BookController : Controller
    {
        readonly PustokDbContext _context;
        public BookController(PustokDbContext context)
        {
            _context = context;
        }
        public IActionResult GetDetail(int id)
        {
            Book book = _context.Books
                .Include(x => x.BookImages)
                .Include(x => x.Genre)
                .Include(x => x.Author)
                .Include(x => x.BookTags).ThenInclude(x =>x.Tag)
                .FirstOrDefault(x => x.Id == id);
            return PartialView("_BookModalPartial", book);
        }
    }
}
