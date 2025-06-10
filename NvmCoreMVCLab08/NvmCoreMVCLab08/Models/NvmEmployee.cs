using System;
using System.ComponentModel.DataAnnotations;

namespace NvmCoreMVCLab08.Models
{
    public class NvmEmployee
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Họ và tên")]
        [Required(ErrorMessage = "Họ và tên không được để trống")]
        [StringLength(100, ErrorMessage = "Họ và tên tối đa 100 ký tự")]
        public string NvmFullName { get; set; }

        [Display(Name = "Địa chỉ email")]
        [Required(ErrorMessage = "Email không được để trống")]
        [EmailAddress(ErrorMessage = "Email không đúng định dạng")]
        public string NvmEmail { get; set; }

        [Display(Name = "Số điện thoại")]
        [Phone(ErrorMessage = "Số điện thoại không hợp lệ")]
        public string NvmPhone { get; set; }

        [Display(Name = "Địa chỉ")]
        [StringLength(200, ErrorMessage = "Địa chỉ tối đa 200 ký tự")]
        public string NvmAddress { get; set; }

        [Display(Name = "Ảnh đại diện")]
        public string NvmAvatar { get; set; } // Đường dẫn ảnh

        [Display(Name = "Ngày sinh")]
        [DataType(DataType.Date)]
        public DateTime NvmBirthday { get; set; }

        [Display(Name = "Giới tính")]
        public string NvmGender { get; set; } // Có thể dùng Enum sau này

        [Display(Name = "Mật khẩu")]
        [Required(ErrorMessage = "Mật khẩu không được để trống")]
        [DataType(DataType.Password)]
        public string NvmPassword { get; set; }

        [Display(Name = "Facebook")]
        [Url(ErrorMessage = "Link Facebook không đúng định dạng")]
        public string NvmFaceBook { get; set; }
    }
}
