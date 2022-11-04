using System.ComponentModel.DataAnnotations;


namespace tranduchungBTTH2.Models
{
    public class sinhvien

    {

        //  Khai báo các thuộc tính
        // khai báo khoá chính
        [Key]
        // Tạo thông báo ràng buộc: không để trống phần nhập 
        [Required(ErrorMessage = "Mã sinh viên không được để trống")]
        public int masinhvien { get; set; }
        [Required(ErrorMessage = "Họ tên sinh viên không được để trống")]
        //  Nhập ít nhất 3 kí tự trở lên
        [MinLength(3)]
        public string? tensinhvien { get; set; }
        public int age { get; set; }
        public string? diachi { get; set; }
    }
}