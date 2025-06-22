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
    public class NhanViensController : Controller
    {
        private readonly AppDbContext _context;

        public NhanViensController(AppDbContext context)
        {
            _context = context;
        }

        // GET: NhanViens
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.NhanVien.Include(n => n.PhongBan);
            return View(await appDbContext.ToListAsync());
        }

        // GET: NhanViens/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.NhanVien == null)
            {
                return NotFound();
            }

            var nhanVien = await _context.NhanVien
                .Include(n => n.PhongBan)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (nhanVien == null)
            {
                return NotFound();
            }

            return View(nhanVien);
        }

        // GET: NhanViens/Create
        public IActionResult Create()
        {
            ViewData["MaPhong"] = new SelectList(_context.Set<PhongBan>(), "Id", "TenPhong");
            return View();
        }

        // POST: NhanViens/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,MaPhong,HoTen,Luong")] NhanVien nhanVien)
        {
            if (ModelState.IsValid)
            {
                _context.Add(nhanVien);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MaPhong"] = new SelectList(_context.Set<PhongBan>(), "Id", "TenPhong", nhanVien.MaPhong);
            return View(nhanVien);
        }

        // GET: NhanViens/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.NhanVien == null)
            {
                return NotFound();
            }

            var nhanVien = await _context.NhanVien.FindAsync(id);
            if (nhanVien == null)
            {
                return NotFound();
            }
            ViewData["MaPhong"] = new SelectList(_context.Set<PhongBan>(), "Id", "TenPhong", nhanVien.MaPhong);
            return View(nhanVien);
        }

        // POST: NhanViens/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,MaPhong,HoTen,Luong")] NhanVien nhanVien)
        {
            if (id != nhanVien.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(nhanVien);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NhanVienExists(nhanVien.Id))
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
            ViewData["MaPhong"] = new SelectList(_context.Set<PhongBan>(), "Id", "TenPhong", nhanVien.MaPhong);
            return View(nhanVien);
        }

        // GET: NhanViens/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.NhanVien == null)
            {
                return NotFound();
            }

            var nhanVien = await _context.NhanVien
                .Include(n => n.PhongBan)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (nhanVien == null)
            {
                return NotFound();
            }

            return View(nhanVien);
        }

        // POST: NhanViens/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.NhanVien == null)
            {
                return Problem("Entity set 'AppDbContext.NhanVien'  is null.");
            }
            var nhanVien = await _context.NhanVien.FindAsync(id);
            if (nhanVien != null)
            {
                _context.NhanVien.Remove(nhanVien);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NhanVienExists(int id)
        {
            return (_context.NhanVien?.Any(e => e.Id == id)).GetValueOrDefault();
        }

        //Tìm kiếm theo phòng ban
        public async Task<IActionResult> TimKiemTheoPhong(int? phongId) // Nhận ID phòng từ dropdown, có thể null
        {
            // Lấy danh sách phòng ban đưa vào DropDownList
            ViewBag.PhongBans = new SelectList(
                await _context.PhongBan.ToListAsync(), // Truy vấn tất cả phòng ban từ DB
                "Id",           // Giá trị của mỗi item trong dropdown (value)
                "TenPhong"      // Hiển thị tên phòng (text hiển thị trong dropdown)
            );

            if (phongId == null) // Nếu chưa chọn phòng ban
            {
                ViewBag.DaChonPhong = false; // Đặt cờ để view biết chưa chọn
                return View(new List<NhanVien>()); // Trả về danh sách rỗng
            }

            // Truy vấn danh sách nhân viên theo phòng ban được chọn
            var nhanVienTrongPhong = await _context.NhanVien
                .Where(nv => nv.MaPhong == phongId)     // Lọc theo mã phòng ban
                .Include(nv => nv.PhongBan)             // Include để lấy thông tin phòng ban (join bảng)
                .OrderBy(nv => nv.Luong)                // Sắp xếp tăng dần theo lương, giảm dần là orderbydes... , sắp xếp theo tên là thenby
                .ToListAsync();                         // Thực hiện truy vấn async

            ViewBag.DaChonPhong = true; // Đặt cờ để view biết đã chọn phòng
            return View(nhanVienTrongPhong); // Trả kết quả ra view
        }

        //thống kê phòng ban có tỏng lương lớn hơn 50tr 
        public async Task<IActionResult> ThongKeTongLuongPhong()
        {
            var danhSachPhong = await _context.PhongBan
                .Include(p => p.NhanViens)      // Include nhân viên để tính tổng lương từng phòng
                .ToListAsync();                 // Lấy tất cả phòng ban từ DB

            var danhSachThongKe = danhSachPhong
                .Select(p => new ThongKePhongBanViewModel // Duyệt từng phòng ban và tạo model kết quả
                {
                    TenPhong = p.TenPhong,                // Gán tên phòng
                    ViTri = p.ViTri,                      // Gán vị trí
                    KinhPhi = p.KinhPhi,                  // Gán kinh phí
                    TongLuongChiTra = p.NhanViens?.Sum(nv => nv.Luong) ?? 0, // Tính tổng lương chi trả (nếu có nhân viên)
                    DanhSachNhanVien = p.NhanViens?.ToList() ?? new List<NhanVien>() // Danh sách nhân viên của phòng
                })
                .Where(p => p.TongLuongChiTra >= 50000000) // Chỉ lấy phòng có tổng lương ≥ 50 triệu
                .ToList(); // Chuyển kết quả sang List để hiển thị

            return View(danhSachThongKe); // Trả danh sách thống kê cho view
        }

    }
}
