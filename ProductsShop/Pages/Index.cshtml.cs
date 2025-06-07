using Microsoft.AspNetCore.Mvc;

using Microsoft.AspNetCore.Mvc.RazorPages;
using ProductsShop.Models;
using ProductsShop.Services;

namespace ProductsShop.Pages;

public class IndexModel : PageModel
{
    private readonly IProductService _service;
    
      public IndexModel(IProductService service) => _service = service;
      public List<Product> Products { get; set; } = new();
      public async Task OnGetAsync() => Products = await _service.GetAllAsync();

}