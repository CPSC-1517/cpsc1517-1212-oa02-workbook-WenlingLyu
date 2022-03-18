using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WestwindSystem.BLL;
using WestwindSystem.Entities;

namespace WestwindWebApp.Pages.Regions
{
    public class IndexModel : PageModel
    {
        private readonly RegionServices _regionServices;
        public IndexModel(RegionServices regionServices)
        {
            _regionServices = regionServices;
        }

        #region properties for list of categories
        public List<Region> RegionList { get; set; } = new();
        #endregion
        public void OnGet()
        {
            RegionList = _regionServices.Region_List();
        }
    }
}
