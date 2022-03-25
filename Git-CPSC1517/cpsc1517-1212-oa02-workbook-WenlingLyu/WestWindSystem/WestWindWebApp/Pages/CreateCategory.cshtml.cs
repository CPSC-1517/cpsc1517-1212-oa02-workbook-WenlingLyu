#region Add namespaces for access BLL and Entities
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WestWindSystem.BLL;
using WestWindSystem.Entities;
#endregion

namespace WestWindWebApp.Pages
{
    public class CreateCategoryModel : PageModel
    {
        #region Declare constructor a dependency of CategoryServices
        private readonly CategoryServices _categoryServices;

        public CreateCategoryModel(CategoryServices categoryServices)
        {
            _categoryServices = categoryServices;
        }
        #endregion

        #region Define properties for data the web page needs to access the web page

        [TempData]
        public string FeedbackMessage { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SearchValue { get; set; }

        public List<Category> QueryResultList { get; set; } = new();

        #endregion

        #region Define handler for the page
        public IActionResult OnPostSearch()
        {
            if (string.IsNullOrEmpty(SearchValue))
            {
                FeedbackMessage = "A search value is required.";
            }
            return RedirectToPage (new {SearchValue = SearchValue});
        }

        public IActionResult OnPostClear()
        {
            FeedbackMessage = "";
            ModelState.Clear();
            QueryResultList.Clear();
            return RedirectToPage(new { SearchValue = (string?)null });
        }
        public void OnGet()
        {
            if (!string.IsNullOrEmpty(SearchValue))
            {
                QueryResultList = _categoryServices.Category_GetByPartialCategoryNameOrDescription(SearchValue);
                FeedbackMessage = $"Search returned {QueryResultList.Count}records.";
            }

        }
        #endregion
    }
}
