using Auctions.Models;

namespace Auctions.Data.Services
{
    public class CommentsServices:ICommentsServices
    {
        private readonly ApplicationDbContext _context;
        public CommentsServices(ApplicationDbContext context) { 
            _context = context;
        }

        public async Task Add(Comment comment)
        {
           _context.Comments.Add(comment);  
            await _context.SaveChangesAsync();
        }
    }
}
