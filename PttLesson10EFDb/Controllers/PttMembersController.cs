
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PttLesson10EFDb.Models;

public class PttMembersController : Controller
{
    private readonly PttLesson10EfContext _context;

    public PttMembersController(PttLesson10EfContext context)
    {
        _context = context;
    }

    // GET: PTTMEMBERS
    public async Task<IActionResult> Index()    
    {
        return View(await _context.PttMembers.ToListAsync());
    }

    // GET: PTTMEMBERS/Details/5
    public async Task<IActionResult> Details(long? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var pttmember = await _context.PttMembers
            .FirstOrDefaultAsync(m => m.Id == id);
        if (pttmember == null)
        {
            return NotFound();
        }

        return View(pttmember);
    }

    // GET: PTTMEMBERS/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: PTTMEMBERS/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Id,PttUserName,PttPassword,PttFullName,PttEmail,PttPhone,PttStatus")] PttMember pttmember)
    {
        if (ModelState.IsValid)
        {
            _context.Add(pttmember);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(pttmember);
    }

    // GET: PTTMEMBERS/Edit/5
    public async Task<IActionResult> Edit(long? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var pttmember = await _context.PttMembers.FindAsync(id);
        if (pttmember == null)
        {
            return NotFound();
        }
        return View(pttmember);
    }

    // POST: PTTMEMBERS/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(long? id, [Bind("Id,PttUserName,PttPassword,PttFullName,PttEmail,PttPhone,PttStatus")] PttMember pttmember)
    {
        if (id != pttmember.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(pttmember);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PttMemberExists(pttmember.Id))
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
        return View(pttmember);
    }

    // GET: PTTMEMBERS/Delete/5
    public async Task<IActionResult> Delete(long? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var pttmember = await _context.PttMembers
            .FirstOrDefaultAsync(m => m.Id == id);
        if (pttmember == null)
        {
            return NotFound();
        }

        return View(pttmember);
    }

    // POST: PTTMEMBERS/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(long? id)
    {
        var pttmember = await _context.PttMembers.FindAsync(id);
        if (pttmember != null)
        {
            _context.PttMembers.Remove(pttmember);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool PttMemberExists(long? id)
    {
        return _context.PttMembers.Any(e => e.Id == id);
    }
}
