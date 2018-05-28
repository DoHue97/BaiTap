using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapTinhLuong
{
    public class Tester​ : Worker
    {        
        double SoGioOT;

        public override void Nhap()
        {
            base.Nhap();            
            Console.Write("Nhap so gio OT ");
            this.SoGioOT = Convert.ToDouble(Console.ReadLine());
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("So gio OT {0} ", SoGioOT);
        }
        public override Double GetLuong()
        {
            if (SoGioOT == 0) return LuongCB;
            else return LuongCB + SoGioOT * 200000;
        }
        public Double GetGioOT()
        {
            return SoGioOT;
        }      
    }
}
