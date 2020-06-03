using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities_CodeFirst
{
    public class CreatDB : CreateDatabaseIfNotExists<QLSV>
    {
        protected override void Seed(QLSV context)
        {
            context.SinhViens.Add(new SinhVien
            {
                MSSV = "001",
                NameSV = "AKV",
                Age = 20,
                ID_Lop = 1
            });
            context.SinhViens.Add(new SinhVien
            {
                MSSV = "002",
                NameSV = "BKL",
                Age = 19,
                ID_Lop = 2
            });
            context.SinhViens.Add(new SinhVien
            {
                MSSV = "003",
                NameSV = "KFA",
                Age = 20,
                ID_Lop = 3
            });
            context.SinhViens.Add(new SinhVien
            {
                MSSV = "004",
                NameSV = "KBFA",
                Age = 19,
                ID_Lop = 2
            });
            context.LopSVs.Add(new LopSV
            {
                ID_Lop = 1,
                NameLop = "18TCLC_DT1"
            });
            context.LopSVs.Add(new LopSV
            {
                ID_Lop = 2,
                NameLop = "18TCLC_DT2"
            });
            context.LopSVs.Add(new LopSV
            {
                ID_Lop = 3,
                NameLop = "18TCLC_DT3"
            });
        }
    }
}
