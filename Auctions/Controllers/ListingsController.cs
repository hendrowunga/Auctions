using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Auctions.Data;
using Auctions.Models;
using Auctions.Data.Services;

namespace Auctions.Controllers
{
    public class ListingsController : Controller
    {
        private readonly IListingServices _listingsServices;

        public ListingsController(IListingServices listingsServices)
        {
            _listingsServices = listingsServices;
        }
        // GET: Listings
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _listingsServices.GetAll();
            return View(await applicationDbContext.ToListAsync());
        }


    }
}
