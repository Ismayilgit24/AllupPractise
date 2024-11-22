using AllupProject.DAL;
using AllupProject.Models;
using AllupProject.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AllupProject
{
    public class HomeController : Controller
    {
        public readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {

            HomeVM homeVM = new HomeVM()
            {
                Slides = _context.Slides.OrderBy(s => s.Order).ToList(),
                Products = _context.Products.Include(p => p.ProductImages).ToList()
            };
            return View(homeVM);
        }
    }
}
