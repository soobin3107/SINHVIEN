using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinhVien
{
    // Class SinhVien để định nghĩa thông tin của sinh viên
    public class SinhVien
    {
        public string MaSinhVien { get; set; }
        public string TenSinhVien { get; set; }
        public string MaLop { get; set; }
    }

    // Class Nhập/Xuất để quản lý việc nhập và xuất thông tin sinh viên
    public class NhapXuatSinhVien
    {
        // Hàm nhập thông tin của một thí sinh
        public static void NhapSinhVien(ref SinhVien sinhVien)
        {
            Console.Write("Nhập mã sinh viên: ");
            sinhVien.MaSinhVien = Console.ReadLine();
            Console.Write("Nhập tên sinh viên: ");
            sinhVien.TenSinhVien = Console.ReadLine();
            Console.Write("Nhập lớp học: ");
            sinhVien.MaLop = Console.ReadLine(); // Nhập thông tin về lớp học
        }

        // Hàm xuất thông tin của một thí sinh
        public static void XuatSinhVien(SinhVien sinhVien)
        {
            Console.WriteLine($"{"Mã Sinh viên:",-12}{sinhVien.MaSinhVien}");
            Console.WriteLine($"{"Họ Tên:",-12}{sinhVien.TenSinhVien}");
            Console.WriteLine($"{"Lớp học:",-12}{sinhVien.MaLop}");
        }

    }
}
