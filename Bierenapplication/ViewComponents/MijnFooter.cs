using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Bierenapplication.ViewComponents
{
    public class MijnFooter : ViewComponent
    {
        public IViewComponentResult Invoke(string footerTekst)
        {
            return View((object)footerTekst);
        }
    }
}
