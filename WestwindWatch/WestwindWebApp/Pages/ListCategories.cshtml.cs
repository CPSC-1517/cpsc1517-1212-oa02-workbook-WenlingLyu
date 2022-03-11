using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WestwindSystem.BLL; // for categoryServices
using WestwindSystem.Entities; // for category

namespace WestwindWebApp.Pages
{
    public class ListCategoriesModel : PageModel
    {
        private readonly CategoryServices _categoryServices;
        public ListCategoriesModel(CategoryServices categoryServices)
        {
            _categoryServices = categoryServices;
        }

        public List<Category>WestwindCategories { get; private set; }
        public void OnGet()
        {
            WestwindCategories = _categoryServices.GetAllCategory();
        }
    }
}
