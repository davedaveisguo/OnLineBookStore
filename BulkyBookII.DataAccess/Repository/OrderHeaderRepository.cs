using BulkyBookII.DataAccess.Data;
using BulkyBookII.DataAccess.Repository.IRepository;
using BulkyBookII.Models;

namespace BulkyBookII.DataAccess.Repository
{
    public class OrderHeaderRepository : Repository<OrderHeader>, IOrderHeaderRepository
    {
        private readonly ApplicationDbContext _db;
        public OrderHeaderRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(OrderHeader obj)
        {
            _db.Update(obj);

        }
    }
}
