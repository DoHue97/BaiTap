using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapTinhLuong
{
    public class Programmer : Worker
    {        
        int SoLoi;
        public override void Nhap()
        {
            
            base.Nhap();            
            Console.Write("Nhap so loi: ");
            this.SoLoi = Convert.ToInt16(Console.ReadLine());
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("Luong thuc te {0} ",LuongCB);
            Console.WriteLine("So loi {0} ", SoLoi);
        }
        public override Double GetLuong()
        {            
            if(SoLoi<20)
            {
                return LuongCB + LuongCB * 10 /100;
            }
            return this.LuongCB;
        }
        public int GetLoi()
        {
            return SoLoi;
        }
    }
}
