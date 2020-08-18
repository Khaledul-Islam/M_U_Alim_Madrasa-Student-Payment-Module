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
    public class PaymentController : Controller
    {

        private readonly ApplicationDbContext _db;
        [TempData]
        public string message { get; set; }
        public PaymentController(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<IActionResult>Index(string searchString)
        {

            
            var result = from m in _db.Student
                         select m;

            if (!string.IsNullOrEmpty(searchString))
            {
                result = result.Where(s => s.Roll.Contains(searchString));
            }
            return View(await result.ToListAsync());
        }

        [HttpPost, ActionName("Index")]
        public IActionResult IndexPost()
        {
            return View();
        }

        //payment get

        public IActionResult Payment()
        {
            
            return View();
        }

        //create payment post
        [HttpPost, ActionName("Payment")]
        public async Task<IActionResult> MakePayment(Payment pay)
        {
            pay.Total = pay.AdmissionFees + pay.ExamFees + pay.HealthFees + pay.SportsFees + pay.TuitionFees + pay.Others;

            if(pay.Total>pay.Paid)
            {
                pay.Due = pay.Total - pay.Paid;
            }

            else
            {
                pay.Due = 0;
            }

           // pay.Others = pay.AdmissionFees + pay.ExamFees + pay.HealthFees + pay.SportsFees + pay.TuitionFees;
            _db.payment.Add(pay);
            await _db.SaveChangesAsync();
            message = "Payment Successfull";
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult>Invoice(string searchString)
        {

            var result = from m in _db.payment
                         select m;

            if (!string.IsNullOrEmpty(searchString))
            {
             
                result = result.Where(s => s.Roll.Contains(searchString));
            }
            return View(await result.ToListAsync());
        }

        //details get
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dID = await _db.payment.FindAsync(id);

            if (dID == null)
            {
                return NotFound();
            }

            return View(dID);
        }

        //edit get

        public async Task<IActionResult> PayDue(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pID = await _db.payment.FindAsync(id);

            if (pID == null)
            {
                return NotFound();
            }

            return View(pID);
        }

        //edit post
        [HttpPost, ActionName("PayDue")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DueEdit(int id,Payment pay)
        {
            pay.Total = pay.AdmissionFees + pay.ExamFees + pay.HealthFees + pay.SportsFees + pay.TuitionFees + pay.Others;
            pay.Due = pay.Total - pay.Paid;
            if (id != pay.ID)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                _db.payment.Update(pay);
                await _db.SaveChangesAsync();
                message = "Data has been updated successfully";
                return RedirectToAction(nameof(Invoice));
            }

            return View(pay);
        }
    }
}