using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinhVien
{
    public class LopHoc
    {
        public string MaLop { get; set; }
        public List<SinhVien> DanhSachSinhVien { get; set; }
        public int SoLuongSinhVien { get; set; }

        public LopHoc(string maLop, int maxSoLuongSinhVien)
        {
            MaLop = maLop;
            DanhSachSinhVien = new List<SinhVien>(maxSoLuongSinhVien);
            // Khởi tạo List với số lượng tối đa được chỉ định
        }

        // Cập nhật hàm tạo để chấp nhận mã phòng và số lượng tối đa từ người dùng
        public LopHoc()
        {
            Console.WriteLine("Nhập mã lớp học: ");
            MaLop = Console.ReadLine();
            Console.WriteLine("Nhập số lượng tối đa của lớp học: ");
            int maxSoLuongSinhVien = int.Parse(Console.ReadLine());
            DanhSachSinhVien = new List<SinhVien>(maxSoLuongSinhVien);
            // Khởi tạo List với số lượng tối đa được chỉ định
        }

        public void ThemSinhVien(SinhVien sinhVien)
        {
            if (SoLuongSinhVien < DanhSachSinhVien.Capacity) // Kiểm tra xem danh sách đã đầy chưa
            {
                DanhSachSinhVien.Add(sinhVien); 
            }
            else
            {
                Console.WriteLine("Phòng thi đã đầy, không thể thêm thí sinh.");
            }
        }

        public void XuatDanhSachSinhVien()
        {
            int i = 0;
            foreach (SinhVien sinhVien in DanhSachSinhVien)
            {
                Console.WriteLine($"\n---Sinh Viên {i + 1}---");
                NhapXuatSinhVien.XuatSinhVien(sinhVien);
                i++;
            }
        }
    }
}
