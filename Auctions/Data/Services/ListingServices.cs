using Auctions.Models;
using Microsoft.EntityFrameworkCore;

namespace Auctions.Data.Services
{
    
    public class ListingServices : IListingServices
    {
        private ApplicationDbContext _context;

        public ListingServices(ApplicationDbContext context)
        {
            _context = context;
        }
        public IQueryable<Listing> GetAll()
        {
            var applicationDbContext = _context.Listings.Include(l => l.User);
            return applicationDbContext;
        }
    }
}
