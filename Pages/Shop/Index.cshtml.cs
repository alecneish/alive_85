using Microsoft.AspNetCore.Mvc.RazorPages;
using alive_85.Models;
using alive_85.Services;

namespace alive_85.Pages.Shop;

public class IndexModel : PageModel
{
    private readonly ProductService _productService;

    public List<Product> Products { get; private set; } = [];

    public IndexModel(ProductService productService)
    {
        _productService = productService;
    }

    public void OnGet()
    {
        Products = _productService.GetAll();
    }
}
