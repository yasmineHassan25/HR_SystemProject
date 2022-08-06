using HR_SystemProject.Models;
using System.ComponentModel.DataAnnotations;


namespace HR_SystemProject.Models.CustomValidations
{
    public class ValidBirthDateAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            Employee employee = validationContext.ObjectInstance as Employee;

            //check that birthdate must before hiredate...
            DateTime BD = Convert.ToDateTime(value);
            int check1 = DateTime.Compare(BD, Convert.ToDateTime(employee.hiredate) );

            //check birthdate that age must be at least 20 year...
            DateTime CheckAge = DateTime.Now.AddYears(-20);
            int check2 = DateTime.Compare(BD, CheckAge);

            if(check2 > 0 || check1 == 0 || check1 > 0)
            {
                return new ValidationResult("Employee age must be 20 as minimum");
            }
            return ValidationResult.Success;
        }
    }
}
