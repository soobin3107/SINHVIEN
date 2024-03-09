using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SINHVIEN
{
    public class SinhVien
    {
        public string HoTen {  get; set; }
        public string Lop { get; set; }
        public float DiemThi { get; set; }
    }

    public class NhapXuatSinhVien
    {
        public static void NhapSinhVien(ref SinhVien sv)
        {
            Console.Write("Nhập Họ Tên: ");
            sv.HoTen = Console.ReadLine();

            Console.Write("Nhập Lớp: ");
            sv.Lop = Console.ReadLine();

            Console.Write("Nhập Điểm Thi: ");
            sv.DiemThi = float.Parse(Console.ReadLine());
        }

        public static void XuatSinhVien(SinhVien sv)
        {
            Console.WriteLine($"Họ Tên: {sv.HoTen}");
            Console.WriteLine($"Lớp: {sv.Lop}");
            Console.WriteLine($"Điểm Thi: {sv.DiemThi}");
        }

        public class Program
        {
            const int N = 100;
            public static void Main()
            {
                Console.OutputEncoding = Encoding.UTF8;
                SinhVien[] sv = new SinhVien[N];
                int n = 0;
                NhapDSSV(sv, ref n);
                XuatDSSV(sv, n);
                Console.ReadLine();
            }

            static void NhapDSSV(SinhVien[] sv, ref int n)
            {
                Console.Write("Nhập số lượng Thí Sinh: ");
                n = int.Parse(Console.ReadLine());
                for (int i = 0; i < n; i++)
                {
                    sv[i] = new SinhVien();
                    Console.WriteLine("---------------------------");
                    Console.WriteLine($"---Thí Sinh thứ {i + 1}---");
                    NhapXuatSinhVien.NhapSinhVien(ref sv[i]);
                }
            }

            // Hàm xuất danh sách thí sinh
            static void XuatDSSV(SinhVien[] sv, int n)
            {
                Console.WriteLine("\n=-=DANH SÁCH CÁC THÍ SINH=-=");
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine($"---Thí Sinh thứ {i + 1}---");
                    NhapXuatSinhVien.XuatSinhVien(sv[i]);
                    Console.WriteLine("---------------------------");
                }
            }
        }
    }
}
