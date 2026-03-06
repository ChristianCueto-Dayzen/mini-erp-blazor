// Este código define las propiedades de la clase Employee, un empleado en el sistema
// Cada propiedad tiene validaciones para asegurar que los datos ingresados sean correctos y cumplan con ciertos formatos

using Microsoft.AspNetCore.Authentication;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Reflection.Metadata;

namespace mini_erp.Entities
{
    public class Employee
    {
        private const string NamePattern = @"^[\p{L}]+(\s[\p{L}]+)*$";
        private const string PositionPattern = @"^[\p{L}]+(\s[\p{L}]+)*$";
        private const string EmailPattern = @"^[\w]+([._%+-][\w]+)*@[\w]+(-[\w]+)*(\.[A-Za-z]{2,})+$";

        [Required(ErrorMessage = "{0} can't be empty")]
        [StringLength(40, ErrorMessage = "{0} is too long")]
        [RegularExpression(NamePattern, ErrorMessage = "{0} contains invalid characters")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "{0} can't be empty")]
        [StringLength(30, ErrorMessage = "{0} is too long")]
        [RegularExpression(PositionPattern, ErrorMessage = "{0} contains invalid characters")]
        public string? Position { get; set; }
        [Required(ErrorMessage = "{0} can't be empty")]
        [StringLength(40, ErrorMessage = "{0} is too long")]
        [RegularExpression(EmailPattern, ErrorMessage = "{0} contains invalid format")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "{0} can't be empty")]
        [Range(0.01, double.MaxValue, ErrorMessage = "{0} must be greater than 0.01")]
        
        public float? Salary { get; set; }
        
    }
}
