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
        private void Form1_Load(object sender, EventArgs e)
        {
            // get all coulmns in db when app started
            //johndoeDb db = new johndoeDb();
            //dataGridView1.DataSource = db.제품_테이블.ToList();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchTable searchTable = new SearchTable(txtItem.Text);
            dataGridView1.DataSource = searchTable.SearchByName();
            
        }


    }
}