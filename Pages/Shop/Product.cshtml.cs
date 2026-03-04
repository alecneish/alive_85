using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using alive_85.Services;

namespace alive_85.Pages.Shop;

public class ProductModel : PageModel
{
    private readonly ProductService _productService;

    public Models.Product? Product { get; private set; }

    public ProductModel(ProductService productService)
    {
        _productService = productService;
    }

    public IActionResult OnGet(string id)
    {
        Product = _productService.GetById(id);

        if (Product is null)
            return Page();

        return Page();
    }
}
