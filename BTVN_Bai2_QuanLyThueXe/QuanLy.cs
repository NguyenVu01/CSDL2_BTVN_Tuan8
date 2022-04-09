using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN_Bai2_QuanLyThueXe
{
    internal class QuanLy
    {
        private Khach[] DanhSachKH;
        private int n;

        public QuanLy(int x)
        {
            n = x;
            DanhSachKH = new Khach[n];
        }
        public void NhapDSKH()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("==================Nhap danh sach khach hang===================");
            for (int i = 0; i < DanhSachKH.Length; i++)
            {
                Console.WriteLine("Nhap khach hang thu {0}", i + 1);
                DanhSachKH[i] = new Khach();
                DanhSachKH[i].NhapTTKhachHang();
                Console.WriteLine("");
            }
        }
        public void XuatDSKH()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("==================Thong tin chi tiet danh sach khach hang===================");
            for (int i = 0; i < DanhSachKH.Length; i++)
            {
                Console.WriteLine("Thong tin sinh vien thu {0}", i + 1);
                DanhSachKH[i].XuatTTKhachHang();
                Console.WriteLine("");
            }
            Console.WriteLine("Doanh thu cua cua hang la: {0}", this.TongTienDoanhThu());
        }
        public double TongTienDoanhThu()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("==================Tong doanh thu cua cua hang===================");
            double Revenue = 0;
            for (int i = 0; i < DanhSachKH.Length; i++)
            {
                Revenue = Revenue + DanhSachKH[i].TinhTienKhachHang();
            }
            return Revenue;
        }
    }
}
