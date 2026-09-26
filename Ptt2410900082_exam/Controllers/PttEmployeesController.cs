
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Ptt2410900082_exam.Models;

public class PttEmployeesController : Controller
{
    private readonly PttEmployee2410900082DbContext _context;

    public PttEmployeesController(PttEmployee2410900082DbContext context)
    {
        _context = context;
    }

    // GET: PTTEMPLOYEES
    public async Task<IActionResult> Index()    
    {
        var members = await _context.PttEmployees.ToListAsync();

        return View("~/Views/PttEmployees/Index.cshtml", members);
    }

    // GET: PTTEMPLOYEES/Details/5
    public async Task<IActionResult> Details(long? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var pttemployee = await _context.PttEmployees
            .FirstOrDefaultAsync(m => m.Id == id);
        if (pttemployee == null)
        {
            return NotFound();
        }

        return View(pttemployee);
    }

    // GET: PTTEMPLOYEES/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: PTTEMPLOYEES/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Id,PttName,PttGender,PttBirthday,PttEmail,PttPhone,PttActive")] PttEmployee pttemployee)
    {
        if (ModelState.IsValid)
        {
            _context.Add(pttemployee);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(pttemployee);
    }

    // GET: PTTEMPLOYEES/Edit/5
    public async Task<IActionResult> Edit(long? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var pttemployee = await _context.PttEmployees.FindAsync(id);
        if (pttemployee == null)
        {
            return NotFound();
        }
        return View(pttemployee);
    }

    // POST: PTTEMPLOYEES/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(long? id, [Bind("Id,PttName,PttGender,PttBirthday,PttEmail,PttPhone,PttActive")] PttEmployee pttemployee)
    {
        if (id != pttemployee.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(pttemployee);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PttEmployeeExists(pttemployee.Id))
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
        return View(pttemployee);
    }

    // GET: PTTEMPLOYEES/Delete/5
    public async Task<IActionResult> Delete(long? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var pttemployee = await _context.PttEmployees
            .FirstOrDefaultAsync(m => m.Id == id);
        if (pttemployee == null)
        {
            return NotFound();
        }

        return View(pttemployee);
    }

    // POST: PTTEMPLOYEES/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(long? id)
    {
        var pttemployee = await _context.PttEmployees.FindAsync(id);
        if (pttemployee != null)
        {
            _context.PttEmployees.Remove(pttemployee);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool PttEmployeeExists(long? id)
    {
        return _context.PttEmployees.Any(e => e.Id == id);
    }
}
