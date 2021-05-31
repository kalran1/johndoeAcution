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

        private void btnBuy_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;
            int id = (int)dataGridView1.Rows[index].Cells[0].Value;

            PurchaseItem purchaseItem = new PurchaseItem(id);
            int q = purchaseItem.purchaseItem();
            
            if (q == 2)
                MessageBox.Show("구매를 취소했습니다.", "Refund Complete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (q == 1)
                MessageBox.Show("구매를 완료했습니다.", "Purchase Complete", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
                MessageBox.Show("오류가 발생했습니다","Unknown Error",MessageBoxButtons.OK,MessageBoxIcon.Error);

            refreshGrid();
        }

        private void refreshGrid()
        {
            SearchTable searchTable = new SearchTable(txtItem.Text);
            dataGridView1.DataSource = searchTable.SearchByName();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}