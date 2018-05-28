using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap2_QLKho
{
    public class MatHang
    {
        public int SL;
        string TenHang;
        public float DTCanChua;
        public void Nhap(int makho,int makhu)
        {
            Console.Write("Nhap ten hang: ");
            TenHang = Console.ReadLine();
            Console.Write("Nhap so luong: ");
            SL = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap dien tich can chua: ");
            DTCanChua = float.Parse(Console.ReadLine());
        }
        public void Xuat(int makho,int makv)
        {
            Console.Write("Nhap so luong hang: ");
            SL = Convert.ToInt32(Console.ReadLine());
        }
        public int GetSL()
        {
            return SL;
        }
    }
}
