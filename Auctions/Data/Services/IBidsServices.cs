using Auctions.Models;

namespace Auctions.Data.Services
{
    public interface IBidsServices
    {
        Task Add(Bid bid);
        IQueryable<Bid> GetAll();
    }
}
