using System.Data;
using System.ComponentModel.DataAnnotations;
namespace TranDucHungBTH2.Models
{
    public class Student
    {
        [Required]
        public string? ID { get; set; }
        [Required]
        public string? StudentID { get; set; }
        [Required]
        public string? Studentname { get; set; }


    }
}