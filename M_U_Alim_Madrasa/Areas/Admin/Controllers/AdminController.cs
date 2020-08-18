using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using M_U_Alim_Madrasa.Data;
using M_U_Alim_Madrasa.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace M_U_Alim_Madrasa.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext _db;

        public AdminController(ApplicationDbContext db)
        {
            _db = db;
        }
        [TempData]
        public string message { get; set; }
        [BindProperty]
        public Students student { get; set; }

        //get student list
        public IActionResult Index()
        {
            return View(_db.Student.ToList());
        }

        //create get
        public IActionResult CreateStudent()
        {
            return View();
        }

        //create post

        [HttpPost, ActionName("CreateStudent")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create()
        {
            if (ModelState.IsValid)
            {
                _db.Student.Add(student);
                await _db.SaveChangesAsync();
                message = "Data has been create successfully";
                return RedirectToAction(nameof(Index));
            }

            return View(student);
        }

        //edit get

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pID = await _db.Student.FindAsync(id);

            if (pID == null)
            {
                return NotFound();
            }

            return View(pID);
        }

        //edit post
        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id)
        {
            if (id != student.ID)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                _db.Student.Update(student);
                await _db.SaveChangesAsync();
                message = "Data has been edited successfully";
                return RedirectToAction(nameof(Index));
            }

            return View(student);
        }


        //details get
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dID = await _db.Student.FindAsync(id);

            if (dID == null)
            {
                return NotFound();
            }

            return View(dID);
        }
        //delete get
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var delId = await _db.Student.FindAsync(id);

            if (delId == null)
            {
                return NotFound();
            }

            return View(delId);
        }

        //delete post

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (id != student.ID)
            {
                return NotFound();
            }
            _db.Student.Remove(student);
            await _db.SaveChangesAsync();
            message = "Student has been deleted successfully";
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Abouts()
        {
            return View();
        }


    }
}