using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace QuanLiKhachSan
{
    public class NhanVien
    {
        // Nhanvien(idNV, tenNV, sdt, soCMND, idNhom)
        public int idNV { get; set; }
        public string tenNV { get; set; }
        public decimal sdt { get; set; }
        public decimal soCMND { get; set; }
        public int? idNhom { get; set; }
        public NhomNV NhomNV { get; set; }
    }
}
