using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Trang60
{
    public class DanhSachNhanVien
    {
        public ArrayList ds;
        public DanhSachNhanVien()
        {
            ds = new ArrayList();
        }
        public NhanVien this[int index]
        {
            get { return ds[index] as NhanVien; }
            set { ds[index] = value; }
        }
        public void Them(NhanVien nv)
        {
            ds.Add(nv);
        }
        public override string ToString()
        {
            string s = "Danh sach mon hoc:";
            foreach (object nv in ds)
            {
                s += nv as NhanVien + ";";
            }
            return s;
        }
    }
}
