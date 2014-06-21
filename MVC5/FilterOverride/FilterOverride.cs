using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Filters;

namespace MVC5.FilterOverride
{
    public class FilterOverrideAttribute : FilterAttribute, IOverrideFilter
    {
        public Type FiltersToOverride
        {
            get
            {
                return typeof(IAuthorizationFilter);
            }
        }
    }
}