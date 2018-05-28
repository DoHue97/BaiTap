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
            int n, m;
            //Programmer
            Programmer[] nv = new Programmer[1000];

            Console.Write("Nhap so nhan vien : ");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                nv[i] = new Programmer();
                nv[i].Nhap();
            }
            Console.WriteLine("-------------Danh sach----------------");

            Console.WriteLine("Danh sach ");
            for (int i = 0; i < n; i++)
            {
                nv[i].Xuat();
            }
            //Tính lương cho nhân viên
            Console.WriteLine("-------------Luong nhan vien-----------------");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Luong cua nhan vien thu " + i + " la " + nv[i].GetLuong());
            }

            int dem = 0;
            Console.WriteLine("------------Nhan vien co loi < 5-----------------");

            //Số nv có lỗi lập trình <5
            for (int i = 0; i < n; i++)
            {
                if (nv[i].GetLoi() < 5)
                    i++;
                dem = i;
            }
            Console.WriteLine("Tong so nhan vien co so loi < 5 la " + dem);

            //Tester
            Console.Write("Nhap so nhan vien tester : ");
            m = Convert.ToInt32(Console.ReadLine());
            Tester[] nvTes = new Tester[1000];

            for (int i = 0; i < m; i++)
            {
                nvTes[i] = new Tester();
                nvTes[i].Nhap();
            }

            Console.WriteLine("--------------Danh sach----------------");
            Console.WriteLine("Danh sach nhan vien ");
            for (int i = 0; i < m; i++)
            {
                nvTes[i].Xuat();
            }
            //Lương
            Console.WriteLine("-------------Luong tester--------------");
            for (int i = 0; i < m; i++)
            {
                Console.WriteLine("Luong cua nhan vien thu " + i + " la " + nvTes[i].GetLuong());
            }
            //Nhân viên tester có số giờ OT max
            Console.WriteLine("-------------Max OT tester--------------");
            double max = nvTes[0].GetGioOT();
            if (m == 1)
            {
                nvTes[0].Xuat();
            }
            else if (m > 1)
            {
                for (int i = 1; i < m; i++)
                {
                    if (nvTes[i].GetGioOT() >= max)
                    {
                        nvTes[i].Xuat();
                    }
                }
            }
            Console.ReadKey();
        }
    }
}