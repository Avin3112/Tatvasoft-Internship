﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer;
using ServiceLayer.Model;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly BookService _bookService;

        public BookController(BookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet]
        public IActionResult GetAllBook()
        {
            var result = _bookService.GetAll();
            return Ok(result);
        }

        [HttpGet("GetBookById")]
        public IActionResult GetBookById(int id)
        {
            var result = _bookService.GetById(id);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult InsertBook(Book book)
        {
            var result = _bookService.InsertBook(book);
            return Ok(result);
        }
    }
}
