using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DotNetApiRepositoryPatternEntities.Models
{
    public class Company
    {
        [Column("CompanyId")]
        public Guid Id { get; set; }
        
        [Required(ErrorMessage = "Company Name is required")]
        [MaxLength(60, ErrorMessage = "Company Name cannot be longer than 60 characters")]
        public string? Name { get; set; }
        
        [Required(ErrorMessage = "Company Address is required")]
        [MaxLength(60, ErrorMessage = "Company Address cannot be longer than 60 characters")]
        public string? Address { get; set; }
        
        public string? Country { get; set; }
        
        public ICollection<Employee>? Employees { get; set; }
    }
}