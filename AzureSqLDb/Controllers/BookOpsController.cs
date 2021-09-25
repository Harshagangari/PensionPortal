using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AzureSqLDb.Models;

namespace AzureSqLDb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookOpsController : ControllerBase
    {
        private readonly BookDbContext context;
        public BookOpsController(BookDbContext _context) 
        {
            context = _context;
        }
        [HttpGet]
        public ActionResult<List<BookClass>> Get()
        {
            return context.books.ToList();
        }
        [HttpPost]
        public ActionResult<BookClass> GetById(int id)
        {
            var book = context.books.Find(id);
            if (book == null)
                return null;
            else
                return book;
        }
    }
}
