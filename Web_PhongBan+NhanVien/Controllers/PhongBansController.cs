using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Web_PhongBan_NhanVien.Models;

namespace Web_PhongBan_NhanVien.Controllers
{
    public class PhongBansController : Controller
    {
        private readonly AppDbContext _context;

        public PhongBansController(AppDbContext context)
        {
            _context = context;
        }

        // GET: PhongBans
        public async Task<IActionResult> Index()
        {
              return _context.PhongBan != null ? 
                          View(await _context.PhongBan.ToListAsync()) :
                          Problem("Entity set 'AppDbContext.PhongBan'  is null.");
        }

        // GET: PhongBans/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.PhongBan == null)
            {
                return NotFound();
            }

            var phongBan = await _context.PhongBan
                .FirstOrDefaultAsync(m => m.Id == id);
            if (phongBan == null)
            {
                return NotFound();
            }

            return View(phongBan);
        }

        // GET: PhongBans/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PhongBans/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TenPhong,ViTri,KinhPhi")] PhongBan phongBan)
        {
            if (ModelState.IsValid)
            {
                _context.Add(phongBan);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(phongBan);
        }

        // GET: PhongBans/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.PhongBan == null)
            {
                return NotFound();
            }

            var phongBan = await _context.PhongBan.FindAsync(id);
            if (phongBan == null)
            {
                return NotFound();
            }
            return View(phongBan);
        }

        // POST: PhongBans/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TenPhong,ViTri,KinhPhi")] PhongBan phongBan)
        {
            if (id != phongBan.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(phongBan);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PhongBanExists(phongBan.Id))
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
            return View(phongBan);
        }

        // GET: PhongBans/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.PhongBan == null)
            {
                return NotFound();
            }

            var phongBan = await _context.PhongBan
                .FirstOrDefaultAsync(m => m.Id == id);
            if (phongBan == null)
            {
                return NotFound();
            }

            return View(phongBan);
        }

        // POST: PhongBans/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.PhongBan == null)
            {
                return Problem("Entity set 'AppDbContext.PhongBan'  is null.");
            }
            var phongBan = await _context.PhongBan.FindAsync(id);
            if (phongBan != null)
            {
                _context.PhongBan.Remove(phongBan);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PhongBanExists(int id)
        {
          return (_context.PhongBan?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
