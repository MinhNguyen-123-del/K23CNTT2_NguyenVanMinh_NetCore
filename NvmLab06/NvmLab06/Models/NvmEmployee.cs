using System;

namespace NvmLab06.Models
{
    public class NvmEmployee
    {
        public string NvmId { get; set; }
        public string NvmName { get; set; }
        public DateTime NvmBirthday { get; set; }
        public string NvmEmail { get; set; }
        public string NvmPhone { get; set; }
        public double NvmSalary { get; set; }
        public bool NvmStatus { get; set; }

        // Constructor không tham số
        public NvmEmployee() { }

        // Constructor đầy đủ tham số
        public NvmEmployee(string nvmId, string nvmName, DateTime nvmBirthday,
                           string nvmEmail, string nvmPhone, double nvmSalary, bool nvmStatus)
        {
            NvmId = nvmId;
            NvmName = nvmName;
            NvmBirthday = nvmBirthday;
            NvmEmail = nvmEmail;
            NvmPhone = nvmPhone;
            NvmSalary = nvmSalary;
            NvmStatus = nvmStatus;
        }

        // Hàm hiển thị thông tin
        public void DisplayInfo()
        {
            Console.WriteLine($"ID: {NvmId}");
            Console.WriteLine($"Tên: {NvmName}");
            Console.WriteLine($"Ngày sinh: {NvmBirthday:yyyy-MM-dd}");
            Console.WriteLine($"Email: {NvmEmail}");
            Console.WriteLine($"Số điện thoại: {NvmPhone}");
            Console.WriteLine($"Lương: {NvmSalary}");
            Console.WriteLine($"Trạng thái: {(NvmStatus ? "Đang làm" : "Đã nghỉ")}");
        }
    }

}
