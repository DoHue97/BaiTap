﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap2_QLKho
{
    public class Kho
    {
        public int MaKho;
        string TenKho;
        public float CDai, CRong;
        public int SLKhu;
        public int MaKv;
        public float GetDT()
        {
            return CDai * CRong;
        }
        public void ThemKho()
        {
            Console.Write("Nhap ma kho: ");
            this.MaKho = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap ten kho: ");
            this.TenKho = Console.ReadLine();
            Console.Write("Nhap chieu dai: ");
            this.CDai = float.Parse(Console.ReadLine());
            Console.Write("Nhap chieu rong: ");
            this.CRong = float.Parse(Console.ReadLine());
            Console.Write("Nhap so luong khu vuc: ");
            this.SLKhu = Convert.ToInt32(Console.ReadLine());
        }
        public void Xem()
        {
            Console.WriteLine("Ma kho " + MaKho);
            Console.WriteLine("Ten kho " + TenKho);
            Console.WriteLine("Chieu dai " + CDai);
            Console.WriteLine("Chieu rong " + CRong);
            Console.WriteLine("So luong khu vuc " + SLKhu);
        }
    }
}
