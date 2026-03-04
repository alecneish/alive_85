using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using alive_85.Models;
using alive_85.Services;

namespace alive_85.Pages.Explore;

public class CategoryModel : PageModel
{
    private readonly ExploreService _exploreService;

    public ExploreCategory? Category { get; private set; }

    public CategoryModel(ExploreService exploreService)
    {
        _exploreService = exploreService;
    }

    public IActionResult OnGet(string slug)
    {
        Category = _exploreService.GetCategory(slug);
        return Page();
    }
}
