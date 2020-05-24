using BulkyBookII.DataAccess.Data;
using BulkyBookII.DataAccess.Repository.IRepository;
using BulkyBookII.Models;

namespace BulkyBookII.DataAccess.Repository
{
    public class OrderDetailsRepository : Repository<OrderDetails>, IOrderDetailsRepository
    {
        private readonly ApplicationDbContext _db;
        public OrderDetailsRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(OrderDetails obj)
        {
            _db.Update(obj);

        }
    }
}
