using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trang60
{
    public class Manv
    {
        public string MaSo { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh;
        public string DiaChi;
        public string PhongBan;
        public string Hinh;
        public string Mail;
        public string SoDT;
        public string GioiTinh;
        public DanhSachNhanVien dsNhanVien;
        public Manv()
        {
            dsNhanVien = new DanhSachNhanVien();

        }
        public Manv(string maso, string hoTen, DateTime ngaysinh, DanhSachNhanVien ds, string diaChi, string phongBan, string hinh, string mail, string soDT, string gt)
        {
            this.MaSo = maso;
            this.HoTen = hoTen;
            this.NgaySinh = ngaysinh;
            this.dsNhanVien = ds;
            this.DiaChi = diaChi;
            this.PhongBan = phongBan;
            this.Hinh = hinh;
            this.Mail = mail;
            this.SoDT = soDT;
            this.GioiTinh = gt;
        }

    }
}
