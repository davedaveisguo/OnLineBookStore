using BulkyBookII.DataAccess.Data;
using BulkyBookII.DataAccess.Repository.IRepository;
using BulkyBookII.Models;

namespace BulkyBookII.DataAccess.Repository
{
    public class ShoppingCartRepository : Repository<ShoppingCart>, IShoppingCartRepository
    {
        private readonly ApplicationDbContext _db;
        public ShoppingCartRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(ShoppingCart obj)
        {
            _db.Update(obj);

        }
    }
}
