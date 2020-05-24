using BulkyBookII.DataAccess.Data;
using BulkyBookII.DataAccess.Repository.IRepository;
using BulkyBookII.Models;

namespace BulkyBookII.DataAccess.Repository
{
    public class CompanyRepository : Repository<Company>, ICompanyRepository
    {
        private readonly ApplicationDbContext _db;
        public CompanyRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Company company)
        {
            _db.Update(company);

        }
    }
}
