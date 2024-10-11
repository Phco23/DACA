using db.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace db.Controllers
{
    public class StudentController : Controller
    {
        private readonly EduDbConnect eduDbConnect;
        public StudentController(EduDbConnect eduDbConnect)
        {
            this.eduDbConnect = eduDbConnect;
        }
        public async Task<IActionResult>  Index()
        {
            var students = await this.eduDbConnect.Students.ToArrayAsync();
            return View(students);
        }

        public async Task<IActionResult> Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Student student)
        {
            if (ModelState.IsValid) 
            { 
                this.eduDbConnect.Add(student);
                await this.eduDbConnect.SaveChangesAsync();
                return Redirect(nameof(Index));
            }
            return View();
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) { }
        }
    }
}
