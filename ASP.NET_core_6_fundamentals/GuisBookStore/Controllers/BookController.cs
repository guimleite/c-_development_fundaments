using GuisBookStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace GuisBookStore.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookRepository _bookRepository;
        private readonly ICategoryRepository _categoryRepository;

        public BookController(IBookRepository bookRepository, ICategoryRepository categoryRepository)
        {
            _bookRepository = bookRepository;
            _categoryRepository = categoryRepository;
        }

        public IActionResult List()
        {
            return View(_bookRepository.AllBooks);
        }
    }
}
