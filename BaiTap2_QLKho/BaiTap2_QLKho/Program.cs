using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap2_QLKho
{
    class Program
    {
        static List<Kho> kho;
        static List<KhuVuc> kv;        
        static int LC;
        public static void NhapTTKho()
        {
            //Them kho
            int SLKho;
            Console.Write("Nhap so luong kho: ");
            SLKho = Convert.ToInt16(Console.ReadLine());
            kho = new List<Kho>();
            for (int i = 0; i < SLKho; i++)
            {
                Kho k = new Kho();
                k.ThemKho();
                kho.Add(k);
            }
        }
        public static void NhapKhu()
        {
            Console.WriteLine("--------------------------------");
            kv = new List<KhuVuc>();
            Console.WriteLine("Nhap thong tin khu");

            //thong tin khu vuc

            for (int i = 0; i < kho.Count; i++)
            {
                for (int j = 0; j < kho[i].SLKhu; j++)
                {
                    KhuVuc khu = new KhuVuc();
                    khu.NhapKhu();
                    kv.Add(khu);
                }
            }
            Console.WriteLine("--------------------------------");
            for (int i = 0; i < kho.Count; i++)
            {
                float dt;
                dt = kho[i].GetDT();
                for (int j = 0; j < kho[i].SLKhu; j++)
                {
                    kv[j].DTich = dt / kho[i].SLKhu;
                    kv[j].GetDienTich();
                    Console.WriteLine("--------------------------------");
                }
            }
        }
        protected static void NhapHang()
        {
            //Nhap hang vao kho
            MatHang mh = new MatHang();
            int makhu,makho;
            Console.WriteLine("Nhap vao ma kho can them mat hang: ");
            makho = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Nhap vao ma khu can them mat hang: ");
            makhu = Convert.ToInt16(Console.ReadLine());

            mh.Nhap(makho,makhu);
            for (int i = 0; i < kho.Count; i++)
                for (int j = 0; j < kv.Count; j++)
                if (makho == kho[i].MaKho && makhu == kv[j].MaKV && kv[j].DTich > (mh.SL + kv[j].GetSL()))
                {
                    kv[j].SetSL(mh.SL + kv[j].GetSL());
                }
                else
                {
                    Console.WriteLine("Khu vuc day roi!");
                }
        }
        public static void XemKho()
        {
            int makho;
            Console.Write("Nhap vao kho muon xem: ");
            makho = Convert.ToInt16(Console.ReadLine());

            for (int i = 0; i < kho.Count; i++)
                if(makho==kho[i].MaKho)
                {
                    for (int j = 0; j < kv.Count; j++)
                        if (kv[j].KTKVTrong() == false)
                        {
                            kho[i].Xem();
                            Console.WriteLine("--------------------------------");
                            kv[j].GetThongTin();
                        }
                }
        }
        public static void XuatKho()
        {
            MatHang mh = new MatHang();
            int makho, makhu;
            Console.Write("Nhap ma kho can xuat: ");
            makho = Convert.ToInt16(Console.ReadLine());
            Console.Write("Nhap ma khu can xuat: ");
            makhu = Convert.ToInt16(Console.ReadLine());            
            mh.Xuat(makho, makhu);
            for (int i = 0; i < kho.Count; i++)
                for (int j = 0; j < kv.Count; j++)
                    if (makhu == kv[j].MaKV && makho == kho[i].MaKho)
                    {
                        kv[j].SetSL(kv[j].GetSL() - mh.GetSL());
                    }
                    else Console.WriteLine("Kho khong co hang de xuat hoac so hang khong du.");
        }       
        public static void Menu()
        {
            do
            {
                Console.WriteLine("---------------Menu------------------");
                Console.WriteLine("Moi ban chon muc:");
                Console.WriteLine("1. Them kho hang ");
                Console.WriteLine("2. Them hang ");
                Console.WriteLine("3. Xem kho co hang ");
                Console.WriteLine("4. Xuat hang");
                
                LC = Convert.ToInt16(Console.ReadLine());

                switch (LC)
                {
                    case 1:
                        NhapTTKho();
                        NhapKhu();
                        NhapHang();
                        break;
                    case 2:
                        NhapHang();
                        break;
                    case 3:
                        XemKho();
                        break;
                    case 4:
                        XuatKho();
                        break;
                }
            } while (LC < 5);
        }
        static void Main(string[] args)
        {
            Menu();
            Console.ReadKey();
        }
    }
}
