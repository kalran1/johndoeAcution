using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace johndoeAcution
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtItem_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }

        private void RefreshGrid()
        {
            using (var db = new johndoeDb())
            {
                var itemlist = db.제품_테이블.ToList();

                dataGridView1.DataSource= itemlist;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           RefreshGrid();
        }
    }
}
