using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DA_PHDHTL_2_6_602_54_Vuong_PhepToan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGiaiPTB1_54_Vuong_Click(object sender, EventArgs e)
        {
            // Lấy giá trị a và b từ các TextBox
            float a = float.Parse(txta_54_Vuong.Text);
            float b = float.Parse(txtb_54_Vuong.Text);
            string ketqua = PhepToan_54_Vuong.giaiB1(a, b);
            txtkqpt_54_Vuong.Text = ketqua;
        }

        private void btnGiaiPTB2_54_Vuong_Click(object sender, EventArgs e)
        {
            // Lấy giá trị a, b và c từ các TextBox
            float a = float.Parse(txta_54_Vuong.Text);
            float b = float.Parse(txtb_54_Vuong.Text);
            float c = float.Parse(txtc_54_Vuong.Text);

            // Giải phương trình bậc 2
            string ketqua = PhepToan_54_Vuong.giaiB2(a, b, c);

            // Hiển thị kết quả
            txtkqpt_54_Vuong.Text = ketqua;
        }

        private void btnkiemtrachanle_54_Vuong_Click(object sender, EventArgs e)
        {
            // Lấy giá trị so từ các TexBox
            float n = float.Parse(txtn_54_Vuong.Text);
            // Kiểm tra chẵn lẻ
            string ketqua = PhepToan_54_Vuong.KiemTraChanLe(n);
            // Hiển thị kết quả
            txtkqchanle_54_Vuong.Text = ketqua;
        }

        private void btnlamlaipt_54_Vuong_Click(object sender, EventArgs e)
        {
            // Xóa nội dung các TextBox
            txta_54_Vuong.Clear();
            txtb_54_Vuong.Clear();
            txtc_54_Vuong.Clear();
            txtkqpt_54_Vuong.Clear();
        }

        private void btnlamlaichanle_54_Vuong_Click(object sender, EventArgs e)
        {
            txtn_54_Vuong.Clear();
            txtkqchanle_54_Vuong.Clear();
        }
    }
}
