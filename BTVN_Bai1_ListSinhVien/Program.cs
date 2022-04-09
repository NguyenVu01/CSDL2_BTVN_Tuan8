using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BTVN_Bai1_ListSinhVien
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            DanhSach DS = new DanhSach();
            bool Run = true;

            while (Run)
            {
                Console.WriteLine("=================Chương trình quản lý sinh viên=============");
                Console.WriteLine("Các chức năng trong chương trình:");
                Console.WriteLine("1. Thêm sinh viên.");
                Console.WriteLine("2. Xóa sinh viên");
                Console.WriteLine("3. Tìm kiếm sinh viên theo tên nhập vào");
                Console.WriteLine("4. Số lượng sinh viên làm khóa luận/chuyên đề tốt nghiệp");
                Console.WriteLine("5. Hiển thị danh sách sinh viên");
                Console.WriteLine("0. Thoát chương trình");
                Console.WriteLine("------------------------------------------------------------");
                Console.Write("Bạn chọn chức năng số: ");
                int Choice = Convert.ToInt32(Console.ReadLine());
                switch (Choice)
                {
                    case 0:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Cảm ơn bạn đã sử dụng chương trình! Hẹn gặp lại lần sau!");
                        Run = false;
                        break;
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Bạn lựa chọn 1. Thêm sinh viên");
                        DS.ThemSinhVien();
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Bạn lựa chọn 2.Xóa sinh viên");
                        DS.XoaSinhVien();
                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Bạn lựa chọn 3.Tìm kiếm sinh viên theo tên");
                        DS.TimKiemSV();
                        break;
                    case 4:
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Bạn lựa chọn 4.Số lượng sinh viên làm khóa luận/chuyên đề");
                        DS.SoLuongKLCD();
                        break;
                    case 5:
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("Bạn lựa chọn 5.Hiển thị danh sách sinh viên");
                        DS.XuatDanhSach();
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("Vui lòng nhập đúng chức năng bạn muốn!");
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}