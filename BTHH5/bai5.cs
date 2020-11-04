using System;
using System.Collections.Generic;
using System.Text;

namespace BTHH5 /*bai5-BTH5: */
{
    class person

    {
        private string name;
        private int age;
        private string nationality;
        public person()
        {
            name = nationality = "";
            age = 0;

        }
        public person(string name, int age, string nationality)
        {
            this.name = name;
            this.age = age;
            this.nationality = nationality;
        }
        public void nhap()
        {
            Console.WriteLine(" nhập thông tin người");
            Console.WriteLine();
            Console.WriteLine("nhập họ và tên người");
            name = Console.ReadLine();
            Console.WriteLine("nhập tuổi:");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("nhập quốc tịch");
            nationality = Console.ReadLine();
            Console.WriteLine();
        }
        public void Hien()
        {
            Console.WriteLine("thông tin:");
            Console.WriteLine("{0}\n{1}\n}{2}", name, age, nationality);

        }
        class player: person
        {
            private int number;
            private string position;
            //public player()
            //{
            //    number = 0;
            //    position = "";
            //}
            //public player(int number,string position)
            //{
            //    this.number = number;
            //    this.position = position;
            //}
            public void nhap()
            {
                do
                {
                    Console.WriteLine(" nhập số áo:");
                    number = int.Parse(Console.ReadLine());
                } while (number <= 0);
                Console.WriteLine("vi trí thi đấu:");
                position = Console.ReadLine();
            }
            public void Hien()
            {
                Console.WriteLine("{0}\n{1}",number,position);
                Console.WriteLine();
            }
        }
        class Coach:person
        {
            private int year;
            public Coach() : base()
            {
                year = 0;
            }
            public Coach(string name, string nationality, int age, int year) : base(name, nationality, age)
            {
                this.year = year;
            }
            public new void nhap()
            {
                base.nhap();
                Console.Write("Nhap so nam lam huan luyen vien:"); year = int.Parse(Console.ReadLine());
            }
            public new void Hien()
            {
                base.Hien();
                Console.Write("{0}", year);
            }
        }
        class Team

        {
            private string name;
            private Coach coach;
            private player[] ds;
            public void Nhap()
            {
                Console.Write("Ten doi bong: "); 
                name = Console.ReadLine();
                ds = new player[15];

                for (int i = 0; i < 15; i++)
                {
                    Console.WriteLine("Nhap cau thu so:{0}", i + 1);
                    ds[i] = new player();
                    ds[i].nhap();

                }
            }
            //===============================================================================================
            public void Hien()
            {
                Console.WriteLine("{0}", name);
                for (int i = 0; i < 11; i++)
                    ds[i].Hien();
            }
        }
        class Test
        {
            static void Main5()
            {
                Team t = new Team();
                Console.WriteLine("Thông tin đội bóng");
                Console.WriteLine();
                t.Nhap();
                t.Hien();
                Console.ReadKey();
            }
        }
    }

}
