using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace QuanLiKhachSan.CodeFirst
{
    public class Initializer : DropCreateDatabaseIfModelChanges<KhachSanContext>
    {
        protected override void Seed(KhachSanContext context)
        {
            using (var ks = new KhachSanContext())
            {
                var nv = new NhanVien()
                {
                    idNhom = null,
                    NhomNV = null,
                    sdt = 0981771024
                    ,
                    soCMND = 321780128,
                    tenNV = "Nam"
                };
                ks.NhanViens.Add(nv);
                ks.SaveChanges();
            }
        }
    }
}
