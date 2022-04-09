using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN_Bai1_ListSinhVien
{
    internal class SinhVien
    {
        private string _HoTen;
        private DateTime _NgaySinh;
        private double _LapTrinh, _CoSoDuLieu, _ThietKeWeb, _DiemTB;
        public SinhVien()
        {
            _HoTen = "";
            _NgaySinh = DateTime.Now;
            _LapTrinh = 0;
            _CoSoDuLieu = 0;
            _ThietKeWeb = 0;
            _DiemTB = 0;
        }
        public SinhVien(string ht, DateTime ns, double lt, double csdl, double tkw)
        {
            this._HoTen = ht;
            this._NgaySinh = ns;
            this._LapTrinh = lt;
            this._CoSoDuLieu = csdl;
            this._ThietKeWeb = tkw;
        }
        public string HoTen
        {
            get { return _HoTen; }
            set { _HoTen = value; }
        }
        public DateTime NgaySinh
        {
            get { return _NgaySinh; }
            set { _NgaySinh = value; }
        }
        public double LapTrinh
        {
            get { return _LapTrinh; }
            set
            {
                _LapTrinh = value;
            }
        }
        public double CoSoDuLieu
        {
            get { return _CoSoDuLieu; }
            set
            {
                _CoSoDuLieu = value;
            }
        }
        public double ThietKeWeb
        {
            get { return _ThietKeWeb; }
            set
            {
                _ThietKeWeb = value;
            }
        }
        //Thuoc tinh DiemTrungBinh- (read only)
        public double DiemTB
        {
            get { return _DiemTB = (_LapTrinh + _CoSoDuLieu + _ThietKeWeb) / 3; }
            set
            {
                _DiemTB = value;
            }
        }
        public void Nhap()
        {
        }
        public void Xuat()
        {
        }
    }
}
