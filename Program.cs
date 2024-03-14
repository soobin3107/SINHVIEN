using System;

namespace SinhVien
{
    public class Program
    {
        static void NhapDSSV(LopHoc maLop)
        {
            Console.Write("\nNhập số lượng Sinh Viên: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                SinhVien sinhVien = new SinhVien();
                Console.WriteLine("---------------------------");
                Console.WriteLine($"---Sinh Viên thứ {i + 1}---");
                NhapXuatSinhVien.NhapSinhVien(ref sinhVien);
                maLop.ThemSinhVien(sinhVien); // Thêm thí sinh vào phòng thi
            }
        }

        // Hàm xuất thông tin của sinh viên
        static void XuatDSSV(LopHoc maLop)
        {
            if (maLop.DanhSachSinhVien != null && maLop.DanhSachSinhVien.Count > 0)
            {
                maLop.XuatDanhSachSinhVien();
            }
            else
            {
                Console.WriteLine("Không có sinh viên nào trong phòng thi.");
            }
        }


        // Hàm Chỉnh sửa danh sách sinh viên trong phòng thi
        static void ChinhSuaDSSV(LopHoc maLop)
        {
            Console.Write("\nNhập mã sinh viên cần chỉnh sửa: ");
            string maSinhVien = Console.ReadLine();
            bool found = false;
            for (int i = 0; i < maLop.DanhSachSinhVien.Count; i++)
            {
                if (maLop.DanhSachSinhVien[i].MaSinhVien == maSinhVien)
                {
                    Console.WriteLine("--Nhập thông tin mới--");
                    SinhVien sinhVien = maLop.DanhSachSinhVien[i];
                    NhapXuatSinhVien.NhapSinhVien(ref sinhVien);
                    maLop.DanhSachSinhVien[i] = sinhVien;
                    found = true;
                    Console.WriteLine("Chỉnh sửa thành công.");
                    break;
                }
            }
            if (!found)
            {
                Console.WriteLine("Không tìm thấy sinh viên có mã số đã nhập.");
            }
        }

        // Hàm thay đổi phòng thi của sinh viên
        static void ThayDoiLopHoc(LopHoc maLop)
        {
            Console.Write("\nNhập mã sinh viên cần thay đổi phòng thi: ");
            string maSinhVien = Console.ReadLine();
            Console.Write("Nhập phòng thi mới: ");
            string lopHocMoi = Console.ReadLine();
            foreach (SinhVien sinhVien in maLop.DanhSachSinhVien)
            {
                if (sinhVien.MaSinhVien == maSinhVien)
                {
                    sinhVien.MaSinhVien = lopHocMoi;
                    Console.WriteLine("Thay đổi phòng thi thành công");
                    return;
                }
            }
            Console.WriteLine("Không tìm thấy Sinh Viên có mã số đã nhập.");
        }

        // Hàm xóa thông tin của một sinh viên trong phòng thi
        static void XoaDSSV(LopHoc maLop)
        {
            Console.Write("\nNhập mã sinh viên cần xóa: ");
            string maSinhVien = Console.ReadLine();

            bool found = false;
            for (int i = 0; i < maLop.DanhSachSinhVien.Count; i++)
            {
                if (maLop.DanhSachSinhVien[i].MaSinhVien == maSinhVien)
                {
                    maLop.DanhSachSinhVien.RemoveAt(i); // Xóa thí sinh khỏi danh sách
                    found = true;
                    Console.WriteLine("Xóa thành công.");
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine("Không tìm thấy thí sinh có mã số đã nhập.");
            }
        }

        // Hàm Main để chạy chương trình
        public static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            int soLuongToiDa;

            // Nhập số lượng sinh viên tối đa
            Console.Write("Nhập số lượng sinh viên tối đa: ");
            soLuongToiDa = int.Parse(Console.ReadLine());

            LopHoc phongA = new LopHoc(" ", soLuongToiDa);

            int luaChon;
            do
            {
                Console.WriteLine("\n---MENU---");
                Console.WriteLine("1. Nhập Thông Tin Sinh Viên");
                Console.WriteLine("2. Xuất Thông Tin Sinh Viên");
                Console.WriteLine("3. Chỉnh Sửa Thông Tin Sinh Viên Trong Lớp Học");
                Console.WriteLine("4. Thay đổi Phòng Thi của Sinh Viên");
                Console.WriteLine("5. Xóa Dữ Liệu của Sinh Viên");
                Console.WriteLine("6. Thoát Chương Trình");
                Console.Write("Nhập Lựa Chọn của Bạn: ");
                luaChon = int.Parse(Console.ReadLine());

                switch (luaChon)
                {
                    case 1:
                        Console.WriteLine("\n===============================");
                        NhapDSSV(phongA);
                        Console.WriteLine("\n===============================");
                        break;
                    case 2:
                        Console.WriteLine("\n===============================");
                        XuatDSSV(phongA);
                        Console.WriteLine("\n===============================");
                        break;
                    case 3:
                        Console.WriteLine("\n===============================");
                        ChinhSuaDSSV(phongA);
                        Console.WriteLine("\n===============================");
                        break;
                    case 4:
                        Console.WriteLine("\n===============================");
                        ThayDoiLopHoc(phongA);
                        Console.WriteLine("\n===============================");
                        break;
                    case 5:
                        Console.WriteLine("\n===============================");
                        XoaDSSV(phongA);
                        Console.WriteLine("\n===============================");
                        break;
                    case 6:
                        Console.WriteLine("Thoát chương trình...");
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng chọn lại.");
                        break;
                }
            } while (luaChon != 6);
        }

    }
}
