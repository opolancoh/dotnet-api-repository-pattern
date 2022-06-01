using System.Collections.Generic;
using DotNetApiRepositoryPatternEntities.Models;

namespace DotNetApiRepositoryPatternContracts
{
    public interface ICompanyRepository
    {
        IEnumerable<Company> GetAllCompanies(bool trackChanges);
    }
}