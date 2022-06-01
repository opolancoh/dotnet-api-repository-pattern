using DotNetApiRepositoryPatternContracts;
using DotNetApiRepositoryPatternService.Contracts;

namespace DotNetApiRepositoryPatternService
{
    internal sealed class EmployeeService : IEmployeeService
    {
        private readonly IRepositoryManager _repository;

        public EmployeeService(IRepositoryManager repository)
        {
            _repository = repository;
        }
    }
}