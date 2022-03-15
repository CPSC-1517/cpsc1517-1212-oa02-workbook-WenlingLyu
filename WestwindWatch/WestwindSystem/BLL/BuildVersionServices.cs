using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WestwindSystem.DAL; //for WestWindContext
using WestwindSystem.Entities;//for BuildVersion

namespace WestwindSystem.BLL
{
    public class BuildVersionServices
    {
        private readonly WestwindContext _context;

        internal BuildVersionServices(WestwindContext context)
        {
            _context = context;
        }

        public BuildVersion? GetBuildVersion() //cause firstOrdefault could return null, so ? means nullable
        {
            return _context.BuildVersion.FirstOrDefault(); //return first or null(default)
        }
    }
}
