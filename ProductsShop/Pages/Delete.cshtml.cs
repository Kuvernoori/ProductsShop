using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProductsShop.Models;
using ProductsShop.Services;

namespace ProductsShop.Pages;

public class DeleteModel : PageModel
{
    private readonly IProductService _productService;

    public DeleteModel(IProductService productService)
    {
        _productService = productService;
    }

    [BindProperty]
    public Product Product { get; set; } = new();

    public async Task<IActionResult> OnGetAsync(int id)
    {
        var all = await _productService.GetAllAsync();
        Product = all.FirstOrDefault(p => p.Id == id)!;

        if (Product == null) return NotFound();
        return Page();
    }

    public async Task<IActionResult> OnPostAsync()
    {
        await _productService.DeleteAsync(Product.Id);
        return RedirectToPage("Index");
    }
}