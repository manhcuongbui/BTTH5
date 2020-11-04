using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace BTHH5 /*bai1-BTH5: Xây dựng lớp có tên là TienDien với các thông tin bao gồm:
+ Dữ liệu:
- Họ tên chủ hộ
- Địa chỉ
- Số công tơ tháng trước
- Số công tơ tháng này
+ Phương thức
- Phương thức thiết lập không tham số và 4 tham số
- Phương thức nhập dữ liệu
- Phương thức hiện
- Thuộc tính tính số công tơ điện đã dùng(=Số công tơ tháng này- Số công tơ tháng
trước)
- Phương thức tính tiền điện được tính theo công thức: Số điện đã dùng*500
Sau đó xây dựng lớp TienDienMoi bằng việc kế thừa lớp TienDien để tính tiền điện
theo một quy định mới. Việc tính tiền điện lúc này căn cứ vào định mức quy định.
Nếu trong định mức là 500, ngoài định mức là 600 */
{
    class TIENDIEN

    {
        private string chuho;
        private string diachi;
        private int congtothangtruoc;
        private int congtothangnay;
        public TIENDIEN()
        {
            chuho = diachi = "";
            congtothangtruoc = congtothangnay;
        }
        public TIENDIEN(string chuho,string diachi,int congtothangtruoc,int congtothangnay)
        {
            this.chuho = chuho;
            this.diachi = diachi;
            this.congtothangnay = congtothangnay;
            this.congtothangtruoc =congtothangtruoc;
        }
        public void nhap()
        {
            Console.WriteLine("nhập thông tin ");
            Console.WriteLine("nhập tên chủ hộ");
            chuho = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("địa chỉ chủ hộ");
            diachi = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("nhập số công tơ tháng trước");
            congtothangtruoc = int.Parse(Console.ReadLine());
            Console.WriteLine("nhập số công tơ tháng này");
            congtothangnay = int.Parse(Console.ReadLine());


        }
        public void Hien()
        {
            Console.WriteLine("thông tin hiển thị");
            Console.WriteLine("{0}\n{1}\n{2}\n{3}",chuho,diachi,congtothangnay,congtothangtruoc);
            Console.WriteLine() ;
        }
        public int Congtodadung
        {
            get
            {
                return (congtothangnay - congtothangtruoc);

            }

        }
        public int tiendien()
        {
            return Congtodadung * 500;
        }

    }
    class TIENDIENMOI:TIENDIEN
    {
        private int dinhmuc;
        public TIENDIENMOI() : base()
        {
            dinhmuc = 50;
        }
        public TIENDIENMOI(string tenchuho, string diachi, int sodienthangtruoc, int sodienthangnay, int dinhmuc) : base(tenchuho, diachi, sodienthangtruoc, sodienthangnay)
        {
            this.dinhmuc = dinhmuc;
        }
        public new void nhap()
        {
            base.nhap();
            Console.Write("Nhap he so dinh muc: "); 
            dinhmuc = int.Parse(Console.ReadLine());

        }
        public new int tiendien()
        {
            if (Congtodadung< dinhmuc) return Congtodadung * 500;
            else return Congtodadung * 600;
        }
    }
    class Test1
    {
        static void Main1(string[] args)
        {
            TIENDIENMOI t = new TIENDIENMOI();
            t.nhap();
            t.Hien();
            Console.WriteLine("Tien dien phai tra:{0}", t.tiendien());
            Console.ReadKey();
        }
    }
}



