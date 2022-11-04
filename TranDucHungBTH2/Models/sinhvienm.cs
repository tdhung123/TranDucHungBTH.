using System.ComponentModel.DataAnnotations;

namespace TranDucHungBTH2.Models
{
    public class sinhvienm

    {

        //  Khai báo các thuộc tính
        // khai báo khoá chính
        [Key]

        public int masinhvien { get; set; }

        public string? tensinhvien { get; set; }
    }
}