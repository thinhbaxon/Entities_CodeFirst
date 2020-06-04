using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entities_CodeFirst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btShow_Click(object sender, EventArgs e)
        {
            QLSV db = new QLSV();
            var l = db.SinhViens.Select(p => new
            {
                p.MSSV,
                p.NameSV,
                p.Age,
                p.ID_Lop,
                p.LopSV.NameLop
            });
            dataGridView1.DataSource = l.ToList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
