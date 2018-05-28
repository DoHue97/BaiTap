using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapTinhLuong
{
    public abstract class Worker
    {
        protected int MaNV;
        protected string TenNV;
        protected double LuongCB;

        public virtual void Nhap()
        {
            Console.Write("Ma nhan vien: ");
            this.MaNV = Convert.ToInt16(Console.ReadLine());
            Console.Write("Ten nhan vien: ");
            this.TenNV = Console.ReadLine();
            Console.Write("Nhap luong: ");
            this.LuongCB = Convert.ToDouble(Console.ReadLine());
        }
        public virtual void Xuat()
        {
            Console.WriteLine("Ma nhan vien {0} ", MaNV);
            Console.WriteLine("Ma nhan vien {0} ", TenNV);
            Console.WriteLine("Luong {0} ", LuongCB);
        }
        public abstract Double GetLuong();   
    }
}
