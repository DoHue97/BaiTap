using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapTinhLuong
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;           
            //Programmer
            Programmer[] nv = new Programmer[1000];
            
            Console.WriteLine("Nhap so nhan vien : ");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                nv[i] = new Programmer();
                nv[i].NhapProgrammer();
            }
            Console.WriteLine("-------------Danh sach----------------");

            Console.WriteLine("Danh sach ");
            for (int i = 0; i < n; i++)
            {
                nv[i].XuatProgrammer();
            }
            //Tính lương cho nhân viên
            Console.WriteLine("-------------Lương nhân viên-----------------");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Luong cua nhan vien thu " + i + " la {1}" + nv[i].TinhLuong());
            }

            int dem = 0;
            Console.WriteLine("------------Số nhân viên có lỗi <5-----------------");

            //Số nv có lỗi lập trình <5
            for (int i = 0; i < n; i++)
            {
                if (nv[i].TongLoi() < 5)
                    i++;
                dem = i;
            }
            Console.WriteLine("Tong so nhan vien co so loi <5 là {0}" + dem);

            //Tester
            Tester[] nvTes = new Tester[1000];
            
            for (int i = 0; i < n; i++)
            {
                nvTes[i] = new Tester();
                nvTes[i].NhapTester();
            }

            Console.WriteLine("--------------Danh sach----------------");
            Console.WriteLine("Danh sách nhân viên ");
            for (int i = 0; i < n; i++)
            {
                nvTes[i].XuatTester();
            }
            //Lương
            Console.WriteLine("-------------Lương tester--------------");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Luong cua nhan vien thu " + i + " la {1}" + nvTes[i].TinhLuong());
            }
            //Nhân viên tester có số giờ OT max
            Console.WriteLine("-------------Max Lương tester--------------");
            double max = 0;
            max = nvTes[0].TongSoGioOT();
            for (int i = 0; i < n; i++)
            {                
                if (nvTes[i].TongSoGioOT() > max)
                {
                    max = nvTes[i].TongSoGioOT();
                    nvTes[i].XuatTester();
                }
            }
            
            Console.ReadKey();
        }
    }
}
