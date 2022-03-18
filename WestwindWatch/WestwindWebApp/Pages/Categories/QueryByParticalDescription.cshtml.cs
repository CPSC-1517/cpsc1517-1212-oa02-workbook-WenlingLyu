using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WestwindSystem.BLL;
using WestwindSystem.Entities;

namespace WestwindWebApp.Pages.Categories
{
    public class QueryByParticalDescriptionModel : PageModel
    {

        private readonly CategoryServices _categoryServices;

        public QueryByParticalDescriptionModel(CategoryServices categoryServices)
        {
            _categoryServices = categoryServices;
        }
        public string FeedbackMessage { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SearchValue { get; set; }
        public List<Category> SearchResultList { get; set; } = new();
        public IActionResult OnPostFetch()
        {
            // Check if the search value is valid
            if (string.IsNullOrEmpty(SearchValue))
            {
                FeedbackMessage = "Search value is required";
            }
            return RedirectToPage(new { searchValue = SearchValue });
        }

        public IActionResult OnPostClear()
        {
            FeedbackMessage = "";
            ModelState.Clear();
            return RedirectToPage(new { searchValue = (string?)null });
        }
        public void OnGet()
        {
            if (!string.IsNullOrWhiteSpace(SearchValue))
            {
                SearchResultList = _categoryServices.Category_GetByPartialDescription(SearchValue);
                if(SearchResultList.Count == 0)
                {
                    FeedbackMessage = "No results returned";
                }

            }
        }
    }
}
