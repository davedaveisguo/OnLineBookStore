using BulkyBookII.DataAccess.Data;
using BulkyBookII.DataAccess.Repository.IRepository;
using BulkyBookII.Models;

namespace BulkyBookII.DataAccess.Repository
{
    public class ApplicationUserRepository : Repository<ApplicationUser>, IApplicationUserRepository
    {
        private readonly ApplicationDbContext _db;
        public ApplicationUserRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
