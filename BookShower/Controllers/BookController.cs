﻿using AutoMapper;
using BookShower.BLL.Models;
using BookShower.BLL.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;


namespace BookShower.PL.Controllers
{
    [Route("Api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookService _bookService;
        public BookController(IBookService bookService,IMapper mapper)
        {
            _bookService = bookService;
        }

        [HttpGet("GetBook")]
        public IActionResult Get(int id)
        {
            return Ok(_bookService.GetById(id));
        }

        [HttpGet("GetAllBooks")]
        public IActionResult GetAll()
        {
            return Ok(_bookService.GetAll());
        }

        [HttpPost("CreateBook")]
        public IActionResult Insert(BookModel model)
        {
            try
            {
                _bookService.Insert(model);
                return Ok();
            }
            catch(Exception ex)
            {
                return BadRequest(ex);
                throw;
            }            
        }

        [HttpPut("UpdateBook")]
        public IActionResult Update(BookModel model)
        {
            try
            {
                _bookService.Update(model);
                return Ok();
            }
            catch(Exception ex)
            {
                return BadRequest(ex);
                throw;
            }
        }

        [HttpDelete("DeleteBook")]
        public IActionResult Delete(int id)
        {
            try
            {
                _bookService.Delete(id);
                return Ok();
            }
            catch(Exception ex)
            {
                return BadRequest(ex);
                throw;
            }
        }
    }
}
