using BulkyBookII.Models;

namespace BulkyBookII.DataAccess.Repository.IRepository
{
    public interface IProductRepository : IRepository<Product>
    {
        void Update(Product product);
    }
}
