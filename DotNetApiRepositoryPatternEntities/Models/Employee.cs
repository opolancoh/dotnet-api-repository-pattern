using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DotNetApiRepositoryPatternEntities.Models
{
    public class Employee
    {
        [Column("EmployeeId")]
        public Guid Id { get; set; }
        
        [Required(ErrorMessage = "Employee Name is required")]
        [MaxLength(30, ErrorMessage = "Employee Name cannot be longer than 30 characters")]
        public string? Name { get; set; }
        
        [Required(ErrorMessage = "Employee Age is required")]
        public int? Age { get; set; }
        
        [Required(ErrorMessage = "Employee Position is required")]
        [MaxLength(20, ErrorMessage = "Employee Position cannot be longer than 20 characters")]
        public string? Position { get; set; }
        
        [ForeignKey(nameof(Company))]
        public Guid CompanyId { get; set; }
        
        public Company? Company { get; set; }
    }
}