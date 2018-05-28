using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap2_QLKho
{
    public class KhuVuc : Kho
    {
        public int MaKV;
        string TenKV;
        public float DTich;
        public int SLHang;
        //MatHang mh;

        public void SetSL(int SLg)
        {
            SLHang = SLg;
        }
        public int GetSL()
        {
            return SLHang;
        }
        public float GetDienTich()
        {            
            return DTich;
        }
        public bool KTKVTrong()
        {
            if (GetSL() <= 0)
                return true;
            else return false;
        }
        //public bool KTraDay()
        //{
        //    mh = new MatHang();
        //    if (mh.DTCanChua * GetSL() > GetDienTich())
        //        return true;
        //    else return false;
        //}
        public void GetThongTin()
        {
            Console.WriteLine("Ma khu " + MaKV);
            Console.WriteLine("Ten khu " + TenKV);
            Console.WriteLine("Dien tich " + GetDienTich());
            Console.WriteLine("So luong mat hang " + GetSL());
        }
        public void NhapKhu()
        {
            Console.Write("Nhap ma khu : ");
            MaKV = Convert.ToInt16(Console.ReadLine());
            Console.Write("Nhap ten khu: ");
            TenKV = Console.ReadLine();
        }
    }
}
