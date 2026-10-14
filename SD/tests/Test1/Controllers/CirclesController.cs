using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Test1.Data;

namespace Test1.Controllers;

public class CirclesController(AppDbContext db) : Controller
{
    public async Task<IActionResult> Index()
    {
        return View(await db.Circles.OrderBy(circle => circle.Id).ToListAsync());
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(int r)
    {
        if (r <= 0)
        {
            ModelState.AddModelError(nameof(r), "Radius must be greater than zero.");
            return View("Index", await db.Circles.OrderBy(circle => circle.Id).ToListAsync());
        }

        db.Circles.Add(new Circle.Circle { R = r });
        await db.SaveChangesAsync();

        return RedirectToAction(nameof(Index));
    }
}
