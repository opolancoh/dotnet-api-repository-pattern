using System.Collections.Generic;
using System.Linq;
using DotNetApiRepositoryPatternContracts;
using DotNetApiRepositoryPatternEntities.Models;

namespace DotNetApiRepositoryPatternRepository
{
    public class CompanyRepository : RepositoryBase<Company>, ICompanyRepository
    {
        public CompanyRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }
        
        public IEnumerable<Company> GetAllCompanies(bool trackChanges) =>
            FindAll(trackChanges)
                .OrderBy(c => c.Name)
                .ToList();
    }
}