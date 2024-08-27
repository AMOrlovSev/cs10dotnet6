using Microsoft.AspNetCore.Mvc.RazorPages; // PageModel
using Packt.Shared; // NorthwindContext
using Microsoft.AspNetCore.Mvc; // [BindProperty], IactionResult

namespace Northwind.Web.Pages;
public class SuppliersModel : PageModel
{
    //public IEnumerable<string>? Suppliers { get; set; }
    public IEnumerable<Supplier>? Suppliers { get; set; }
    private NorthwindContext db;

    [BindProperty]
    public Supplier? Supplier { get; set; }

    public IActionResult OnPost()
    {
        if ((Supplier is not null) && ModelState.IsValid)
        {
            db.Suppliers.Add(Supplier);
            db.SaveChanges();
            return RedirectToPage("/suppliers");
        }
        else
        {
            return Page(); // возвращает исходную страницу
        }
    }

    public SuppliersModel(NorthwindContext injectedContext)
    {
        db = injectedContext;
    }
    public void OnGet()
    {
        ViewData["Title"] = "Northwind B2B - Suppliers";
        //Suppliers = new[]
        //{
        //    "Alpha Co", "Beta Limited", "Gamma Corp"
        //};
        Suppliers = db.Suppliers
            .OrderBy(c => c.Country).ThenBy(c => c.CompanyName);
    }
}