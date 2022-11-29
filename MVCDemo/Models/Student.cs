using System.ComponentModel.DataAnnotations;

namespace MVCDemo.Models
{
    public class Student
    {
        [Required(ErrorMessage ="Roll no is required")]
        [Display(Name ="Roll Number")]
        public int RollNo { get; set; }

        [Required(ErrorMessage ="Name is required")]
        [MaxLength(40,ErrorMessage ="Name must have less than 40 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Email is required")]
        [DataType(DataType.EmailAddress,ErrorMessage ="Email is not in proper format")]
        public string Email { get; set; }

        [Required(ErrorMessage ="Age is required")]
        [Range(18,60,ErrorMessage ="Age must be in between 18 to 60")]
        public int Age { get; set; }

        [Required(ErrorMessage ="Password is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
