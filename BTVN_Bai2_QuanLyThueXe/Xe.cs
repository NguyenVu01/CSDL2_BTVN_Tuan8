using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN_Bai2_QuanLyThueXe
{
    internal class Xe
    {
        private string _TenXe;
        private string _LoaiXe;
        private string _BienSo;
        private int _SoGheNgoi;
        private double _SoGioThue;
        public string TenXe
        {
            get { return _TenXe; }
            set { _TenXe = value; }
        }
        public string LoaiXe
        {
            get { return _LoaiXe; }
            set { LoaiXe = value; }
        }
        public string BienSo
        {
            get { return _BienSo; }
            set { _BienSo = value; }
        }
        public int SoGheNgoi
        {
            get { return _SoGheNgoi; }
            set { SoGheNgoi = value; }
        }
        public double SoGioThue
        {
            get { return _SoGioThue; }
            set { _SoGioThue = value; }
        }
        public virtual void Nhap()
        {
            Console.WriteLine("==================Bat dau nhap thong tin xe================");
            Console.Write("Nhap ten xe:");
            TenXe = Console.ReadLine();

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

            Console.Write("Nhap bien so xe: ");
            BienSo = Console.ReadLine();
            Console.Write("Nhap so ghe ngoi co trong xe: ");
            SoGheNgoi = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap so gio thue: ");
            SoGioThue = Convert.ToDouble(Console.ReadLine());
        }
        public virtual void Xuat()
        {
            Console.WriteLine("=========================Thong tin xe===========================");
            Console.WriteLine("Ten xe o to: {0}", this.TenXe);
            Console.WriteLine("Loai xe o to: {0}", this.LoaiXe);
            Console.WriteLine("Bien so xe o to: {0", this.BienSo);
            Console.WriteLine("Xe co so ghe ngoi: {0}", this.SoGheNgoi);
            Console.WriteLine("Thue {0} tieng thi tong tien xe la: {1}", this.SoGioThue, this,TinhTien());
        }
        public virtual double TinhTien()
        {
            return 0;
        }
    }
}
