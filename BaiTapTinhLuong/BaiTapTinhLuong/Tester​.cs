using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapTinhLuong
{
    public class Tester​ : Worker
    {
        double Luong;
        double SoGioOT;

        public void NhapTester()
        {
            Nhap();
            Console.WriteLine("Nhap luong: ");
            this.Luong = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhap so gio OT: ");
            this.SoGioOT = Convert.ToDouble(Console.ReadLine());
        }
        public void XuatTester()
        {
            Xuat();
            Console.WriteLine("Luong {0}: ", Luong);
            Console.WriteLine("So gio OT {0}: ", SoGioOT);
        }
        public Double TinhLuong()
        {
            if (SoGioOT == 0) return Luong;
            else return Luong + SoGioOT * 200000;
        }
        public Double TongSoGioOT()
        {
            return SoGioOT;
        }
    }
}
