using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using Microsoft.Extensions.Configuration; // for configuration class---for pagenation

using WestWindSystem.BLL; // for categoryServices
using WestWindSystem.Entities; //for entities
using WestWindWebApp.Helpers;// for pagenator

namespace WestWindWebApp.Pages.Products
{
    public class CategoryProductsModel : PageModel
    {
        private readonly CategoryServices _categoryServices;
        private readonly ProductServices _productServices;
        private readonly SupplierServices _supplierServices;
        //for pagenation
        private IConfiguration _configuration;

        public CategoryProductsModel(CategoryServices categoryServices, ProductServices productServices,SupplierServices supplierServices,IConfiguration configuration)
        {
            _categoryServices = categoryServices;
            _productServices = productServices;
            _supplierServices = supplierServices;
            _configuration = configuration; //for pagenator 

            PAGE_SIZE = configuration.GetValue("PageSize", 3);  //for pagenator

            SupplierList = _supplierServices.Supplier_List();
        }

        #region Paginator   // for pagenator
        //my desired page size
        //private const int PAGE_SIZE = 5;
        private readonly int PAGE_SIZE;
        //be able to hold an instance of the Paginator
        public Paginator Pager { get; set; }
        #endregion

        public List<Supplier> SupplierList { get; set; } = new();

        public List<Category> CategoryList { get; private set; } = new();

        public List<Product> CategoryProductList { get; private set; } = new();

        [BindProperty(SupportsGet =true)]
        public int SelectedCategoryId { get; set; }
        [TempData]
        public string FeedbackMessage { get; set; }

        public IActionResult OnPostFetch()
        {
            return RedirectToPage("/Products/CategoryProducts",
                new {SelectedCategoryId = SelectedCategoryId });
        }

        public void OnPostClear()
        {

        }

        public void OnPostNew()
        {

        }

        public void OnGet(int? currentPage)
        {
            CategoryList = _categoryServices.Category_List();
            if (SelectedCategoryId > 0)
            {
                //determine the current page number
                int pagenumber = currentPage.HasValue ? currentPage.Value : 1;
                //setup the current state of the paginator (sizing)
                PageState current = new(pagenumber, PAGE_SIZE);
                //temporary local integer to hold the results of the query's total collection size
                // this will be need by the Paginator during the paginator's execution
                int totalcount;

                CategoryProductList = _productServices.Product_GetByCategoryID(
                SelectedCategoryId,
                PAGE_SIZE,
                pagenumber,
                out totalcount);

                //create the needed Pagnator instance
                Pager = new Paginator(totalcount, current);


                CategoryProductList = _productServices.Product_GetByCategoryID(SelectedCategoryId);
                FeedbackMessage = $"Query return {CategoryProductList.Count} record(s).";
            }

        }
    }
}
