using System;
using System.Collections.Generic;
using DotNetApiRepositoryPatternContracts;
using DotNetApiRepositoryPatternEntities.Models;
using DotNetApiRepositoryPatternService.Contracts;

namespace DotNetApiRepositoryPatternService
{
    internal sealed class CompanyService : ICompanyService
    {
        private readonly IRepositoryManager _repository;

        public CompanyService(IRepositoryManager repository)
        {
            _repository = repository;
        }


        public IEnumerable<Company> GetAllCompanies(bool trackChanges)
        {
            try
            {
                var companies = _repository.Company.GetAllCompanies(trackChanges);
                
                return companies;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}