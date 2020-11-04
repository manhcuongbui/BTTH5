using System;
using System.Collections.Generic;
using System.Text;

namespace BTHH5 /* bai4-BTH5:Xây dựng lớp có tên PTBH dùng để giải phương trình bậc hai
 ax
2
+bx+c=0 với a≠0
Sau đó xây dựng lớp PTTP kế thừa từ lớp PTBH dùng để giải phương trình trùng phương
ax
4
+bx2
+c=0 với a≠0*/
{   class PTBH
    {
        protected double a, b, c;
    public PTBH()
    {
        a = b = c = 0;
    }
    public PTBH(double a, double b, double c)
    {
        this.a = a; this.b = b; this.c = c;
    }
    // ===================================================================================================
    public void Nhap()
    {
        Console.Write("a="); 
        a = double.Parse(Console.ReadLine());
        Console.Write("b="); 
        b = double.Parse(Console.ReadLine());
        Console.Write("c="); 
        c = double.Parse(Console.ReadLine());

    }
     //====================================================================================================
    public double A
    {
        get
        {
            return a;
        }
        set
        {
            if (value != 0) a = value;
        }
    }
    // tinh delta
    public double Delta()
    {
        return (b * b - 4 * A* c);
    }
    public void GiaiPT()
    {

        if (Delta() > 0)
        {
            double x1 = (-b - Math.Sqrt(Delta())) / (2 * A);
            double x2 = (-b + Math.Sqrt(Delta())) / (2 * A);
            Console.WriteLine("Phuong trinh co hai nghiem x1={0}\t\t x2={1}", x1, x2);
        }
        else if (Delta() == 0) 
                Console.WriteLine("Phuong trinh co nghiem duy nhat x1=x2={0}", -b / (2 * A));
        else 
                Console.WriteLine("Phuong trinh vo nghiem");
    }

}
class PTTP : PTBH
{
    public new void GiaiPT()
    {
        double d = Delta();
        if (d == 0)
        {
            double c = -b / (2 * A);
            if (c < 0) Console.WriteLine("Phuong trinh vo nghiem!");
            else
                Console.WriteLine("Phuong trinh trung phuong co 2 nghiem x1={0}\tx2={1}", Math.Sqrt(c), -Math.Sqrt(c));
        }
        else if (d < 0) 
                Console.WriteLine("Phuong trinh vo nghiem");
        else
        {
            double c1 = (-b - Math.Sqrt(Delta())) / (2 * A);
            double c2 = (-b + Math.Sqrt(Delta())) / (2 * A);
            if (c1 < 0 && c2 < 0)
                Console.WriteLine("Phuong trinh vo nghiem");
            else if (c1 > 0 && c2 < 0)
                Console.WriteLine("Phuong trinh co 2 nghiem x1={0}\t\t x2={1}", Math.Sqrt(c1), -Math.Sqrt(c1));
            else if (c1 < 0 && c2 > 0)
                Console.WriteLine("Phuong trinh co 2 nghiem :x1={0}\t\t x2={1}", Math.Sqrt(c2), -Math.Sqrt(c2));
            else Console.WriteLine("Phuong trinh co 4 nghiem phan biet:\n x1={0}\n\t x2={1}\n/t x3={2}\n\t x4={3}", Math.Sqrt(c1), -Math.Sqrt(c1), Math.Sqrt(c2), -Math.Sqrt(c2));
        }
    }
}
    class Test
    {
        static void Main4()
        {
            PTTP pt = new PTTP();
            pt.Nhap();
            pt.GiaiPT();
            Console.ReadKey();
        }
    }
}

