using Auctions.Models;
namespace Auctions.Data.Services
{

    public interface IListingServices
    {


        IQueryable<Listing> GetAll();
    }
}
