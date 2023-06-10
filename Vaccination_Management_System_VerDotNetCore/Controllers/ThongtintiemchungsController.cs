using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Vaccination_Management_System_VerDotNetCore.Models.Entities;

namespace Vaccination_Management_System_VerDotNetCore.Controllers
{
    public class ThongtintiemchungsController : Controller
    {
        private readonly HETHONGTIEMCHUNGContext _context;

        public ThongtintiemchungsController(HETHONGTIEMCHUNGContext context)
        {
            _context = context;
        }

        // GET: Thongtintiemchungs
        public async Task<IActionResult> Index()
        {
            var hETHONGTIEMCHUNGContext = _context.Thongtintiemchungs;
            return View(await hETHONGTIEMCHUNGContext.ToListAsync());
        }

        // GET: Thongtintiemchungs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var thongtintiemchung = await _context.Thongtintiemchungs
                .FirstOrDefaultAsync(m => m.Mathongtin == id);
            if (thongtintiemchung == null)
            {
                return NotFound();
            }

            return View(thongtintiemchung);
        }

        // GET: Thongtintiemchungs/Create
        public IActionResult Create()
        {
            ViewData["KhachHang"] = new List<Khachhang>(_context.Khachhangs);
            //ViewData["Makh"] = new SelectList(_context.Khachhangs, "Makh", "Makh");
            //ViewData["Manv"] = new SelectList(_context.Nhanviens, "Manv", "Manv");
            ViewData["VacXin"] = new List<Vacxin>(_context.Vacxins);
            //ViewData["Mavc"] = new SelectList(_context.Vacxins, "Mavc", "Mavc");
            return View();
        }

        // POST: Thongtintiemchungs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Mathongtin,Makh,Mavc,Manv,Ngaytiem,Ngaytiemtieptheo,Tinhtrangbn,Ghichu")] Thongtintiemchung thongtintiemchung)
        {
            if (ModelState.IsValid)
            {
                _context.Add(thongtintiemchung);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Makh"] = new SelectList(_context.Khachhangs, "Makh", "Makh", thongtintiemchung.Makh);
            ViewData["Manv"] = new SelectList(_context.Nhanviens, "Manv", "Manv", thongtintiemchung.Manv);
            ViewData["Mavc"] = new SelectList(_context.Vacxins, "Mavc", "Mavc", thongtintiemchung.Mavc);
            return View(thongtintiemchung);
        }

        // GET: Thongtintiemchungs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var thongtintiemchung = await _context.Thongtintiemchungs.FindAsync(id);
            if (thongtintiemchung == null)
            {
                return NotFound();
            }
            ViewData["Makh"] = new SelectList(_context.Khachhangs, "Makh", "Makh", thongtintiemchung.Makh);
            ViewData["Manv"] = new SelectList(_context.Nhanviens, "Manv", "Manv", thongtintiemchung.Manv);
            ViewData["Mavc"] = new SelectList(_context.Vacxins, "Mavc", "Mavc", thongtintiemchung.Mavc);
            return View(thongtintiemchung);
        }

        // POST: Thongtintiemchungs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Mathongtin,Makh,Mavc,Manv,Ngaytiem,Ngaytiemtieptheo,Tinhtrangbn,Ghichu")] Thongtintiemchung thongtintiemchung)
        {
            if (id != thongtintiemchung.Mathongtin)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(thongtintiemchung);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ThongtintiemchungExists(thongtintiemchung.Mathongtin))
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
            ViewData["Makh"] = new SelectList(_context.Khachhangs, "Makh", "Makh", thongtintiemchung.Makh);
            ViewData["Manv"] = new SelectList(_context.Nhanviens, "Manv", "Manv", thongtintiemchung.Manv);
            ViewData["Mavc"] = new SelectList(_context.Vacxins, "Mavc", "Mavc", thongtintiemchung.Mavc);
            return View(thongtintiemchung);
        }

        // GET: Thongtintiemchungs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var thongtintiemchung = await _context.Thongtintiemchungs
                .FirstOrDefaultAsync(m => m.Mathongtin == id);
            if (thongtintiemchung == null)
            {
                return NotFound();
            }

            return View(thongtintiemchung);
        }

        // POST: Thongtintiemchungs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var thongtintiemchung = await _context.Thongtintiemchungs.FindAsync(id);
            _context.Thongtintiemchungs.Remove(thongtintiemchung);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ThongtintiemchungExists(int id)
        {
            return _context.Thongtintiemchungs.Any(e => e.Mathongtin == id);
        }
    }
}
