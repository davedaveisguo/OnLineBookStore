using System;

namespace BulkyBookII.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        IApplicationUserRepository ApplicationUser { get; }
        ICompanyRepository Company { get; }
        ICategoryRepository Category { get; }

        ICoverTypeRepository CoverType { get; }

        IProductRepository Product { get; }

        IOrderHeaderRepository OrderHeader { get; }

        IOrderDetailsRepository OrderDetails { get; }

        IShoppingCartRepository ShoppingCart { get; }

        SP_Call SP_Call { get; }


        void Save();


    }
}
