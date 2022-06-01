using DotNetApiRepositoryPatternContracts;
using DotNetApiRepositoryPatternEntities.Models;

namespace DotNetApiRepositoryPatternRepository
{
    public class EmployeeRepository : RepositoryBase<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}