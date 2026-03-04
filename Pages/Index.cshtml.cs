using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using alive_85.Models;
using alive_85.Services;

namespace alive_85.Pages;

public class IndexModel : PageModel
{
    private readonly ProductService _productService;
    private readonly TriviaService _triviaService;

    public List<Product> FeaturedProducts { get; private set; } = [];
    public List<TriviaQuestion> TriviaQuestions { get; private set; } = [];
    public bool NewsletterSubmitted { get; set; }

    [BindProperty]
    public string NewsletterEmail { get; set; } = "";

    public IndexModel(ProductService productService, TriviaService triviaService)
    {
        _productService = productService;
        _triviaService = triviaService;
    }

    public void OnGet()
    {
        FeaturedProducts = _productService.GetAll().Take(4).ToList();
        TriviaQuestions = _triviaService.GetRandomSet(5);
    }

    public IActionResult OnPost()
    {
        FeaturedProducts = _productService.GetAll().Take(4).ToList();
        TriviaQuestions = _triviaService.GetRandomSet(5);
        NewsletterSubmitted = true;
        return Page();
    }
}
