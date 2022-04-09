using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN_Bai2_QuanLyThueXe
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Khach kh1 = new Khach();
            kh1.NhapTTKhachHang();
            kh1.XuatTTKhachHang();*/

            QuanLy ds1 = new QuanLy(3);
            ds1.NhapDSKH();
            ds1.XuatDSKH();
            Console.ReadLine();
        }
    }
}
