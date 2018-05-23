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
            Console.WriteLine("-------------Luong nhan vien-----------------");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Luong cua nhan vien thu " + i + " la " + nv[i].TinhLuong());
            }

            int dem = 0;
            Console.WriteLine("------------Nhan vien co loi < 5-----------------");

            //Số nv có lỗi lập trình <5
            for (int i = 0; i < n; i++)
            {
                if (nv[i].TongLoi() < 5)
                    i++;
                dem = i;
            }
            Console.WriteLine("Tong so nhan vien co so loi < 5 la " + dem);

            //Tester
            Tester[] nvTes = new Tester[1000];

            for (int i = 0; i < n; i++)
            {
                nvTes[i] = new Tester();
                nvTes[i].NhapTester();
            }

            Console.WriteLine("--------------Danh sach----------------");
            Console.WriteLine("Danh sach nhan vien ");
            for (int i = 0; i < n; i++)
            {
                nvTes[i].XuatTester();
            }
            //Lương
            Console.WriteLine("-------------Luong tester--------------");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Luong cua nhan vien thu " + i + " la " + nvTes[i].TinhLuong());
            }
            //Nhân viên tester có số giờ OT max
            Console.WriteLine("-------------Max OT tester--------------");
            double max = nvTes[0].TongSoGioOT(), d = 0;

            for (int i = 1; i < n; i++)
            {
                if (nvTes[i].TongSoGioOT() >= max)
                {
                    max = nvTes[i].TongSoGioOT();
                    d = max;
                }
            }
            for (int i = 0; i < n; i++)
                if (nvTes[i].TongSoGioOT() == d)
                    nvTes[i].XuatTester();
            Console.ReadKey();
        }
    }
}
