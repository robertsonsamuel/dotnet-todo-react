using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoApp;
using TodoApp.Interfaces;
using TodoApp.Models;
using TodoApp.Repository;

namespace TodoApp.Controllers
{
   [Route("api/[controller]")]
    public class TodoListController : ControllerBase
    {
        private IRepositoryWrapper _repository;

        public TodoListController(IRepositoryWrapper repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult GetAllTodoLists()
        {

            var todoLists = _repository.TodoList.GetAll();
            return Ok(todoLists);
        }
    }
    
}
