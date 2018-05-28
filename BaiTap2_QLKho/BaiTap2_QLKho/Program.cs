using System;
using System.Collections;
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

        private static void NhapTTKho()
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
        private static void NhapKhu()
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
        private static void NhapHang()
        {
            string tenkho, tenkhu;
            int sln;
            Console.WriteLine("Nhap vao ten kho can them mat hang: ");
            tenkho = Console.ReadLine();
            Console.WriteLine("Nhap vao ten khu can them mat hang: ");
            tenkhu = Console.ReadLine();
            Console.Write("Nhap so luong: ");
            sln = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < kho.Count; i++)
                for (int j = 0; j < kv.Count; j++)
                    if (tenkho == kho[i].TenKho && tenkhu == kv[j].TenKV)
                        if (kv[j].GetDienTich() >= sln * kv[j].DTCanChua)
                        {
                            kv[j].NhapHang(tenkho, tenkhu, sln);
                            kv[j].SetSL(kv[j].GetSL() + sln);
                        }
                        else
                        {
                            Console.WriteLine("Khu vuc khong du chua!");
                        }
        }
        private static void XemKho()
        {
            string tenkho;
            Console.Write("Nhap vao kho muon xem: ");
            tenkho = Console.ReadLine();

            for (int i = 0; i < kho.Count; i++)
                if (tenkho == kho[i].TenKho)
                {
                    kho[i].Xem();
                    for (int j = 0; j < kv.Count; j++)
                        if (kv[j].KTKVTrong() == false)
                        {
                            Console.WriteLine("--------------------------------");
                            kv[j].GetThongTin();
                        }
                        else Console.WriteLine("Khu vuc dang trong");
                }
        }
        private static void GetListKho()
        {
            for (int i = 0; i < kho.Count; i++)
            {
                kho[i].Xem();
                for (int j = 0; j < kv.Count; j++)
                    if (kv[j].KTKVTrong() == false)
                    {
                        Console.WriteLine("--------------------------------");
                        kv[j].GetThongTin();
                    }
            }
        }
        private static void XuatKho()
        {
            string makho, makhu;
            int slx;
            Console.Write("Nhap ma kho can xuat: ");
            makho = Console.ReadLine();
            Console.Write("Nhap ma khu can xuat: ");
            makhu = Console.ReadLine();
            Console.Write("Nhap so luong can xuat: ");
            slx = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < kho.Count; i++)
                for (int j = 0; j < kv.Count; j++)
                    if (makhu == kv[j].TenKV && makho == kho[i].TenKho)
                        if (kv[j].GetSL() >= slx)
                        {
                            kv[j].SetSL(kv[j].GetSL() - slx);
                        }
                        else Console.WriteLine("Kho khong co hang de xuat hoac so hang khong du.");
        }
        private static void XemHang()
        {
            string tenhang;
            Console.Write("Nhap vao ten mat hang muon xem: ");
            tenhang = Console.ReadLine();
            for (int i = 0; i < kho.Count; i++)
                for (int j = 0; j < kv.Count; j++)
                    if (tenhang == kv[j].GetTenHang())
                    {
                        kho[i].Xem();
                        kv[j].GetThongTin();
                    }
        }
        private static void Menu()
        {
            do
            {
                Console.WriteLine("---------------Menu------------------");
                Console.WriteLine("Moi ban chon muc:");
                Console.WriteLine("1. Them kho hang ");
                Console.WriteLine("2. Them hang ");
                Console.WriteLine("3. Xem kho co hang ");
                Console.WriteLine("4. Xuat hang");
                Console.WriteLine("5. List kho hang");
                Console.WriteLine("6. Xem mat hang");

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
                    case 5:
                        GetListKho();
                        break;
                    case 6:
                        XemHang();
                        break;
                }
            } while (LC < 7);
        }
        static void Main(string[] args)
        {
            Menu();
            Console.ReadKey();
        }
    }
}