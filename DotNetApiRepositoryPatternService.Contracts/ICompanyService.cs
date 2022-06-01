using System.Collections.Generic;
using DotNetApiRepositoryPatternEntities.Models;

namespace DotNetApiRepositoryPatternService.Contracts
{
    public interface ICompanyService
    {
        IEnumerable<Company> GetAllCompanies(bool trackChanges);
    }
}