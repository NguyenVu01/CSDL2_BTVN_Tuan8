using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Dữ liệu: Họ tên khách, số giờ thuê, loại xe thuê
◼ Phương thức: Nhập thông tin khách hàng, hiện thông tin
khách hàng, tính tiền khách hàng*/

namespace BTVN_Bai2_QuanLyThueXe
{
    internal class Khach
    {
        private string _HoTen;
        private double _SoGioThue;
        private string _LoaiXe;

        private string HoTen
        {
            get { return _HoTen; }
            set { _HoTen = value; }
        }
        private double SoGioThue
        {
            get { return _SoGioThue;}
            set { _SoGioThue = value;}
        }
        private string LoaiXe
        {
            get { return _LoaiXe; }
            set { _LoaiXe = value; }
        }
        public void NhapTTKhachHang()
        {
            Console.WriteLine("==================Bat dau nhap thong tin khach hang================");
            Console.Write("Nhap ho ten khach hang thue xe: ");
            HoTen = Console.ReadLine();
            Console.Write("Nhap so gio khach hang thue: ");
            SoGioThue = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap loai xe khach hang thue: ");
            Console.WriteLine("An phim 1 neu la xe du lich, 2 la xe tai:");
            int ChoiceLoaiXe = Convert.ToInt32(Console.ReadLine());
            while (ChoiceLoaiXe != 1 && ChoiceLoaiXe != 2)
            {
                Console.Write("Nhap lai an 1 de chon xe du lich, 2 la xe tai:");
                ChoiceLoaiXe = Convert.ToInt32(Console.ReadLine());
            }
            if (ChoiceLoaiXe == 1)
            {
                this.LoaiXe = "Xe du lich";
            }
            else this.LoaiXe = "Xe tai";
        }
        public void XuatTTKhachHang()
        {
            Console.WriteLine("====================Xuat thong tin khach hang==================");
            Console.WriteLine("Ho ten khach hang thue xe: {0}", this.HoTen);
            Console.WriteLine("So gio khach hang thue xe: {0}", this.SoGioThue);
            Console.WriteLine("Loai xe khach hang da thue: {0}", this.LoaiXe);
            Console.WriteLine("Tong tien khach hang phai thanh toan: {0}", this.TinhTienKhachHang());
            Console.WriteLine("");
        }
        public double TinhTienKhachHang()
        {
            if (this.LoaiXe == "Xe du lich")
            {
                return 250000 + 70000 * (this.SoGioThue - 1);
            }
            else return 220000 + 85000 * (this.SoGioThue - 1); 
        }
    }
}
