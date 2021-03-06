using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CompanyEmployee.Entities.Models
{
    public class Employee
    {
        [Column("EmployeeId")]
        public Guid Id { get; set; }

        [Required(ErrorMessage ="Employee name is required field. ")]
        [MaxLength(50, ErrorMessage = "Maximum lenght for the Name is 50 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Age is required field. ")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Position is a required field.")]
        [MaxLength(20, ErrorMessage = "Maximum length for the Position is 20 characters.")]
        public string Position { get; set; }


        [ForeignKey(nameof(Company))]
        public Guid CompanyId { get; set; }
        public Company Company { get; set; }
    }
}
