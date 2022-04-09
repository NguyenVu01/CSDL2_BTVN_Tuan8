using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN_Bai1_ListSinhVien
{
    internal class DanhSach : SinhVien
    {
        private List<SinhVien> danhSach;
        private int n { get; set; }
        public DanhSach(int x)
        {
            n = x;
            danhSach = new List<SinhVien>(n);
        }
        public DanhSach()
        {
            danhSach = new List<SinhVien>();
        }
        public int SoLuongSV()
        {
            int Count = 0;
            if(danhSach != null)
            {
                Count = danhSach.Count;
            }
            return Count;
        }


        public void ThemSinhVien()
        {
            SinhVien sv = new SinhVien();
            Console.WriteLine("----------Nhập thông tin sinh viên----------");
            Console.Write("Nhap ten cua sinh vien: ");
            sv.HoTen = Console.ReadLine();

            Console.Write("Nhap ngay sinh cua sinh vien: ");
            sv.NgaySinh = Convert.ToDateTime(Console.ReadLine());

            Console.Write("Nhap diem mon Lap Trinh:");
            sv.LapTrinh = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nhap diem mon Co So Du Lieu:");
            sv.CoSoDuLieu = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nhap diem Thiet ke Web:");
            sv.ThietKeWeb = Convert.ToDouble(Console.ReadLine());
            // Them vao 
            danhSach.Add(sv);
        }

        public void XuatDanhSach()
        {
            if (danhSach != null && danhSach.Count > 0)
            {
                 Console.WriteLine("------------------Danh sách sinh viên----------------");
                 foreach (SinhVien sv in danhSach)
                 {
                        Console.WriteLine("---------------------------------------------");
                        Console.WriteLine("Họ và tên sinh viên: {0}", sv.HoTen);
                        Console.WriteLine("Ngày sinh: {0}", sv.NgaySinh);
                        Console.WriteLine("Điểm lập trình: {0}", sv.LapTrinh);
                        Console.WriteLine("Điểm cơ sở dữ liệu: {0}", sv.CoSoDuLieu);
                        Console.WriteLine("Điểm thiết kế web: {0}", sv.ThietKeWeb);
                        Console.WriteLine("Điểm trung bình: {0}", sv.DiemTB);
                 }
            }
            else Console.WriteLine("Danh sách rỗng, không có sinh viên nào cả!");
        }

        /*Đưa ra số lượng sinh viên được làm khoá luận tốt nghiệp; 
        Số lượng sinh viên làm chuyên đề tốt nghiệp với các điều kiện:
         Làm khoá luận nếu điểm Trung bình >= 8 và không môn nào dưới 5
         Làm chuyên đề tốt nghiệp nếu Không có môn nào dưới 5*/
        public void SoLuongKLCD()
        {
            int c1 = 0, c2 = 0;
            if (danhSach != null && danhSach.Count > 0)
            {
                foreach(SinhVien sv in danhSach)
                {
                    if(sv.CoSoDuLieu >= 5 && sv.LapTrinh >= 5 && sv.ThietKeWeb >= 5)
                    {
                        if (sv.DiemTB >= 8)
                        {
                            c1 += 1;
                            c2 += 1;
                        }
                        else c2 += 1;
                    }
                }
            }
            Console.WriteLine("Số lượng sinh viên làm khóa luận tốt nghiệp: {0}", c1);
            Console.WriteLine("Số lượng sinh viên làm chuyên đề tốt nghiệp: {0}", c2);
        }

        public void XoaSinhVien()
        {
            int pos = ViTriTheoTen();
            if(pos != -1)
            {
                danhSach.Remove(danhSach[pos]);
            }
            else Console.WriteLine("Không xóa được! Có lẽ sinh viên này không tồn tại.");
        }

        private int ViTriTheoTen()
        {
            int pos = -1;
            Console.Write("Nhập tên sinh viên: ");
            string name = Console.ReadLine();
            
            if(danhSach != null && danhSach.Count > 0)
            {
                for(int i = 0; i < danhSach.Count; i++)
                {
                    if(danhSach[i].HoTen == name)
                    {
                        pos = i;
                        break;
                    }
                }
            }
            return pos;
        }

        public void TimKiemSV()
        {
            int pos = ViTriTheoTen();
            if(pos != -1)
            {
                Console.WriteLine("Thông tin sinh viên: {0}", danhSach[pos].HoTen);
                Console.WriteLine("Ngày sinh: {0}", danhSach[pos].NgaySinh);
                Console.WriteLine("Điểm lập trình: {0}", danhSach[pos].LapTrinh);
                Console.WriteLine("Điểm cơ sở dữ liệu: {0}", danhSach[pos].CoSoDuLieu);
                Console.WriteLine("Điểm thiết kế web: {0}", danhSach[pos].ThietKeWeb);
                Console.WriteLine("Điểm trung bình: {0}", danhSach[pos].DiemTB); 
            }
            else
            {
                Console.WriteLine("Không tìm thấy sinh viên bạn vừa nhập vào!");
            }
        }
    }
}
