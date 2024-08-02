using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HandsOnEFDBFirstCRUD.Entities;

namespace HandsOnEFDBFirstCRUD.Controllers
{
    public class EmployeeDetailsController : Controller
    {
        private readonly MyDb1Context _context;

        public EmployeeDetailsController(MyDb1Context context)
        {
            _context = context;
        }

        // GET: EmployeeDetails
        public async Task<IActionResult> Index()
        {
            var myDb1Context = _context.EmployeeDetails.Include(e => e.DeptCodeNavigation);
            return View(await myDb1Context.ToListAsync());
        }

        // GET: EmployeeDetails/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employeeDetail = await _context.EmployeeDetails
                .Include(e => e.DeptCodeNavigation)
                .FirstOrDefaultAsync(m => m.EmpId == id);
            if (employeeDetail == null)
            {
                return NotFound();
            }

            return View(employeeDetail);
        }

        // GET: EmployeeDetails/Create
        public IActionResult Create()
        {
            ViewData["DeptCode"] = new SelectList(_context.Departments, "DeptCode", "DeptCode");
            return View();
        }

        // POST: EmployeeDetails/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EmpId,EmpName,DeptCode,Designation,JoinDate,Manager")] EmployeeDetail employeeDetail)
        {
            if (ModelState.IsValid)
            {
                _context.Add(employeeDetail);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DeptCode"] = new SelectList(_context.Departments, "DeptCode", "DeptCode", employeeDetail.DeptCode);
            return View(employeeDetail);
        }

        // GET: EmployeeDetails/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employeeDetail = await _context.EmployeeDetails.FindAsync(id);
            if (employeeDetail == null)
            {
                return NotFound();
            }
            ViewData["DeptCode"] = new SelectList(_context.Departments, "DeptCode", "DeptCode", employeeDetail.DeptCode);
            return View(employeeDetail);
        }

        // POST: EmployeeDetails/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("EmpId,EmpName,DeptCode,Designation,JoinDate,Manager")] EmployeeDetail employeeDetail)
        {
            if (id != employeeDetail.EmpId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(employeeDetail);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmployeeDetailExists(employeeDetail.EmpId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["DeptCode"] = new SelectList(_context.Departments, "DeptCode", "DeptCode", employeeDetail.DeptCode);
            return View(employeeDetail);
        }

        // GET: EmployeeDetails/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employeeDetail = await _context.EmployeeDetails
                .Include(e => e.DeptCodeNavigation)
                .FirstOrDefaultAsync(m => m.EmpId == id);
            if (employeeDetail == null)
            {
                return NotFound();
            }

            return View(employeeDetail);
        }

        // POST: EmployeeDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var employeeDetail = await _context.EmployeeDetails.FindAsync(id);
            if (employeeDetail != null)
            {
                _context.EmployeeDetails.Remove(employeeDetail);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EmployeeDetailExists(int id)
        {
            return _context.EmployeeDetails.Any(e => e.EmpId == id);
        }
    }
}
