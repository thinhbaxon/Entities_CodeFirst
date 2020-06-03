using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities_CodeFirst
{
    [Table("DSSinhVien")]
    public class SinhVien
    {
        [Key]
        public string MSSV { get; set; }
        public string NameSV { get; set; }
        public int Age { get; set; }
        public int ID_Lop { get; set; }
        [ForeignKey("ID_Lop")]
        public virtual LopSV LopSV { get; set; }
    }
}
