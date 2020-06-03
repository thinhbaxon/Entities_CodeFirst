using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities_CodeFirst
{
    [Table("LopHP")]
    public class LopSV
    {
        [Key]
        public int ID_Lop { get; set; }
        public string NameLop { get; set; }
        public virtual ICollection<SinhVien> SinhViens { get; set; }
        public LopSV()
        {
            this.SinhViens = new HashSet<SinhVien>();
        }
    }
}
