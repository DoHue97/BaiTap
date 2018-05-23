using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapTinhLuong
{
    public class Programmer : Worker
    {        
        double Luong;
        int SoLoi;
        public void NhapProgrammer()
        {
            Nhap();
            Console.WriteLine("Nhap luong: ");
            this.Luong = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhap so loi: ");
            this.SoLoi = Convert.ToInt16(Console.ReadLine());
        }
        public void XuatProgrammer()
        {
            Xuat();
            Console.WriteLine("Luong {0}: ",Luong);            
            Console.WriteLine("So loi {0}: ",SoLoi);
        }
        public Double TinhLuong()
        {            
            if(SoLoi<20)
            {
                return Luong + Luong * 10 /100;         
            }
            return this.Luong;
        }
        public int TongLoi()
        {
            return SoLoi;
        }
    }
}
