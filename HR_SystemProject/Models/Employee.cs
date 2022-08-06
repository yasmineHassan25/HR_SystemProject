using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HR_SystemProject.Models.CustomValidations;

namespace HR_SystemProject.Models
{
    public enum Gender { male, female   }

    public class Employee
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string address { get; set; }

        [RegularExpression(@"01(1|2|5|0)\d{8}", ErrorMessage = "Phone must be eleven numbers and starts with 01")]
        public string phone { get; set; }

        [ValidHireDate]     //custom validation
        [Column(TypeName = "Date")]
        public DateOnly hiredate { get; set; }

        public Gender gender { get; set; }

        public string nationality { get; set; }

        [RegularExpression(@"\d{14}", ErrorMessage = "NationalID must be fourteen number")]
        public string nationalID { get; set; }


        [DataType(DataType.Time)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:HH:mm}")]
        public TimeOnly checkIn { get; set; }

        [DataType(DataType.Time)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:HH:mm}")]
        public TimeOnly checkOut { get; set; }

        public int salary { get; set; }

        [ValidBirthDate]    //custom validation
        [Column(TypeName ="Date")]
        public DateOnly birthDate { get; set; }
        
        [ForeignKey("department")]
        public int dept_Id { get; set; }

        public virtual Department department { get; set; }

        public virtual List<Attendence> attendences { get; set; }

    }
}
