using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHocSinh_WPFDemo
{
    public class SinhVien
    {
        private string ten;
        private string mssv;
        private string diachi;
        private string sdt;

        public string Ten
        {
            get { return this.ten; }
            set { this.ten = value; }
        }

        public string Mssv
        {
            get { return this.mssv; }
            set { this.mssv = value; }
        }

        public string Diachi
        {
            get { return this.diachi; }
            set { this.diachi = value; }
        }

        public string Sdt
        {
            get { return this.sdt; }
            set { this.sdt = value; }
        }

        public SinhVien() { }

        public SinhVien(string ten,string mssv,string diachi, string sdt) 
        {
            this.ten = ten;
            this.mssv = mssv;
            this.diachi = diachi;
            this.sdt = sdt;
        }
    }
}
