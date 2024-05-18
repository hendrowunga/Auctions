using Auctions.Models;

namespace Auctions.Data.Services
{
    public interface ICommentsServices
    {
        Task Add(Comment comment);
    }
}
