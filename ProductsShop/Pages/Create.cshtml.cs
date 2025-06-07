using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProductsShop.Models;
using ProductsShop.Services;

public class CreateModel : PageModel
{
    private readonly IProductService _service;

    [BindProperty]
    public Product Product { get; set; } = new();

    public CreateModel(IProductService service) => _service = service;

    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid) return Page();

        await _service.AddAsync(Product);
        return RedirectToPage("Index");
    }
}