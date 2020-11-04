using System;
using System.Collections.Generic;
using System.Text;

namespace BTHH5 /* bai2-BTH5:Xây dựng lớp có tên là TamGiac dùng để tính diện tích của một tam giác khi biết
độ dài các cạnh, thông tin về lớp TamGiac bao gồm
- Dữ liệu: Độ dài ba cạnh
- Phương thức: 
Bài tập thực hành lập trình hướng đối tượng Trang 17
o Phương thức thiết lập không và ba tham số
o Phương thức nhập
o Phương thức hiện
o Phương thức tính diện tích*/
{
    class Diem
    {
        private int x, y;
        //==========================================================================================
        public void Nhap()
        {
            Console.Write("Nhap x="); x = int.Parse(Console.ReadLine());
            Console.Write("Nhap y="); y = int.Parse(Console.ReadLine());
        }
        public void Hien()
        {
            Console.WriteLine("({0},{1})", x, y);
        }
        public double TinhKC(Diem B)
        {
            return Math.Sqrt(Math.Pow(B.x - this.x, 2) + Math.Pow(B.y - this.y, 2));
        }
    }
    //==========================================================================================================
    class TamGiac
    {
        private Diem A, B, C;
        public void Nhap()
        {
            Console.WriteLine("Nhập các tọa độ điểm");
            Console.WriteLine("Nhập tọa độ điểm A:");
            A = new Diem(); A.Nhap();
            Console.WriteLine("Nhập tọa độ điểm B:");
            B = new Diem(); B.Nhap();
            Console.WriteLine("Nhập tọa độ điểm C:");
            C = new Diem(); C.Nhap();
        }
        //-----------------------------------------------------------------------------------------------
        public void Hien()
        {
            Console.WriteLine("Thong tin doa do diem A:"); A.Hien();
            Console.WriteLine("Thong tin doa do diem B:"); B.Hien();
            Console.WriteLine("Thong tin doa do diem C:"); C.Hien();
        }
        
        public bool Ktra(double a, double b, double c)
        {
            return a + b > c && b + c > a && a + c > b;
        }
        //------------------------------------------------------------------------------------------------
        public double Tinhdientich()
        {
            double a = B.TinhKC(C);
            double b = A.TinhKC(C);
            double c = A.TinhKC(B);
            if (Ktra(a, b, c))
            {
                double p = (a + b + c) / 2;
                double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                Console.WriteLine("Diem tich la:" + s);
            }
            else
                Console.WriteLine("Ba Điểm A,B,C thẳng hàng");
        }

    }
    //---------------------------------------------------------------------------------------------------------
    class Tudien : TamGiac
    {
        private double h;
        public Tudien() : base()
        {
            h = 0;
        }
        public Tudien(double a, double b, double c, double h) : base ()
        {
            this.h = h;
        }
        public new void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap chieu cao h="); h = int.Parse(Console.ReadLine());
        }
        public double Tinhtt()
        {
            return TinhDienTich() * 1/3 * h;
        }
        public new void Hien()
        {
            base.Hien();
            Console.WriteLine("Chieu cao={0}\n The tich={1}", h, Tinhtt());
        }
    }
    class test
    {
        static void Main2()
        {
            Tudien t = new Tudien();
            t.Nhap();
            t.Hien();
            Console.ReadKey();
        }
    }
}

