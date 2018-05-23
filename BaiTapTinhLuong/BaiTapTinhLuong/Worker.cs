using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapTinhLuong
{
    public class Worker
    {
        public int MaNV;
        public string TenNV;
        public void Nhap()
        {
            Console.WriteLine("Ma nhan vien: ");
            this.MaNV = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Ten nhan vien: ");
            this.TenNV = Console.ReadLine();
        }
        public void Xuat()
        {
            Console.WriteLine("Ma nhan vien {0}: ", MaNV);
            Console.WriteLine("Ma nhan vien {0}: ", TenNV);           
        }
    }
}
