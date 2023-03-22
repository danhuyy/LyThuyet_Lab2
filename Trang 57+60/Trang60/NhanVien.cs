using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trang60
{
    public class NhanVien
    {
        public int MaNV { get; set; }
        public string TenNV { get; set; }
        public int SoTC { get; set; }
        public NhanVien()
        {

        }
        public NhanVien(string ten)
        {
            this.TenNV = ten;
        }
        public NhanVien(int ma, string ten, int tc)
        {
            this.MaNV = ma;
            this.TenNV = ten;
            this.SoTC = tc;
        }
        public override string ToString()
        {
            return TenNV;
        }
    }
}
