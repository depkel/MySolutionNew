using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MyMvcApp.Models;

namespace MyMvcApp.Controllers;

public class HomeController(ILogger<HomeController> logger) : Controller
{
    private readonly ILogger<HomeController> _logger = logger;

    private static readonly List<Employee> _employees = new()
        {
            new Employee { Id = 1, Name = "Alice", Department = "HR", Email = "alice@corp.com" },
            new Employee { Id = 2, Name = "Bob", Department = "Finance", Email = "bob@corp.com" },
            new Employee { Id = 3, Name = "Charlie", Department = "IT", Email = "charlie@corp.com" }
        };
        
    public IActionResult Index()
    {


        return View(_employees);

    }

    [HttpGet]
        public IActionResult EditEmployeePartial(int id)
        {
            var emp = _employees.FirstOrDefault(e => e.Id == id);
            if (emp == null)
                return NotFound();

            return PartialView("_EditEmployeePartial", emp);
        }

    // Handle AJAX form submit
    [HttpPost]
    public IActionResult UpdateEmployee(Employee updatedEmp)
    {
        var emp = _employees.FirstOrDefault(e => e.Id == updatedEmp.Id);
        if (emp == null)
            return NotFound();

        emp.Name = updatedEmp.Name;
        emp.Department = updatedEmp.Department;
        emp.Email = updatedEmp.Email;

        // Return updated row partial
        return PartialView("_EmployeeRowPartial", emp);
    }
        
         [HttpGet]
        public IActionResult DeleteEmployeePartial(int id)
        {
            var emp = _employees.FirstOrDefault(e => e.Id == id);
            if (emp == null) return NotFound();
            return PartialView("_DeleteConfirmPartial", emp);
        }

        [HttpPost]
        public IActionResult ConfirmDelete(int id)
        {
            var emp = _employees.FirstOrDefault(e => e.Id == id);
            if (emp == null) return NotFound();

            _employees.Remove(emp);
            return Ok(); // no need to return view — handled in JS
        }
  
      [HttpGet]
    public IActionResult GetProducts()
    {
       var products = new List<object>
        {
            new { Id = 1, Name = "Laptop", Price = 1200, Category = "Electronics" },
            new { Id = 2, Name = "Smartphone", Price = 800, Category = "Electronics" },
            new { Id = 3, Name = "Table", Price = 150, Category = "Furniture" },
            new { Id = 4, Name = "Chair", Price = 85, Category = "Furniture" },
            new { Id = 5, Name = "Book", Price = 20, Category = "Books" },
            new { Id = 6, Name = "Shoes", Price = 50, Category = "Fashion" },


             new { Id = 7, Name = "Laptop", Price = 1200, Category = "Electronics" },
            new { Id = 8, Name = "Smartphone", Price = 800, Category = "Electronics" },
            new { Id = 9, Name = "Table", Price = 150, Category = "Furniture" },
            new { Id = 10, Name = "Chair", Price = 85, Category = "Furniture" },
            new { Id = 11, Name = "Book", Price = 20, Category = "Books" },
            new { Id = 12, Name = "Shoes", Price = 50, Category = "Fashion" },
             new { Id = 13, Name = "Laptop", Price = 1200, Category = "Electronics" },
            new { Id = 14, Name = "Smartphone", Price = 800, Category = "Electronics" },
            new { Id = 15, Name = "Table", Price = 150, Category = "Furniture" },
            new { Id = 16, Name = "Table", Price = 150, Category = "Furniture" },
            new { Id = 17, Name = "Laptop", Price = 1200, Category = "Electronics" },
            new { Id = 18, Name = "Smartphone", Price = 800, Category = "Electronics" },
            new { Id = 19, Name = "Table", Price = 150, Category = "Furniture" },
            new { Id = 20, Name = "Chair", Price = 85, Category = "Furniture" },
            new { Id = 21, Name = "Book", Price = 20, Category = "Books" },
            new { Id = 22, Name = "Shoes", Price = 50, Category = "Fashion" },
             new { Id = 23, Name = "Laptop", Price = 1200, Category = "Electronics" },
            new { Id = 24, Name = "Smartphone", Price = 800, Category = "Electronics" },
            new { Id = 25, Name = "Table", Price = 150, Category = "Furniture" }

        };

        return Json(new { data=products });  // DataTables expects { data: [...] }
    }
}

