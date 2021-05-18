using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLiKhachSan
{
    public class NhomNV
    {
        [ForeignKey("NhanVien")]
        // NhomNV(idNhom, idCV, idNhomTruong)
        public int idNhom { get; set; }
        public virtual NhanVien TruongNhom { get; set; }
        public ICollection<NhanVien> nhanViens { get; set; }
    }
}
