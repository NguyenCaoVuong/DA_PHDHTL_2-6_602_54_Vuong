using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DA_PHDHTL_2_6_602_54_Vuong_WebDriver
{
    public partial class Form1 : Form
    {
        private WebDriver_54_Vuong webDriver;
        public Form1()
        {
            InitializeComponent();
            webDriver = new WebDriver_54_Vuong();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Kiểm tra xem đối tượng webDriver có khác null không
            if (webDriver != null)
            {
                // Nếu webDriver khác null, gán null cho webDriver
                // Điều này có nghĩa là webDriver sẽ không còn tham chiếu đến đối tượng nào nữa
                webDriver = null;
            }
        }

        private void btnopenyoutube_54_Vuong_Click(object sender, EventArgs e)
        {
            webDriver.OpenYouTube(); // Gọi hàm mở url youtube từ file WebDriver_54_Vuong
        }

        private void btnsearchyoutube_54_Vuong_Click(object sender, EventArgs e)
        {
            string searchTerm = txtsearchyoutube_54_Vuong.Text; // Khai báo biến kiểu string cho TextBox
            webDriver.SearchYouTube(searchTerm); // Gọi hàm SearchYoutube từ file WebDriver_54_Vuong và lấy dữ liệu kiểu string đã nhập cho TextBox
        }

        private void btnopenvideoyoutube_54_Vuong_Click(object sender, EventArgs e)
        {
            webDriver.OpenFirstVideo(); // Gọi hàm mở video youtube từ file WebDriver_54_Vuong
        }

        private void btnskipvideoyoutube_54_Vuong_Click(object sender, EventArgs e)
        {
            webDriver.SkipVideo(); // Gọi hàm skip video youtube từ file WebDriver_54_Vuong
        }

        private void btnmutevideoyoutube_54_Vuong_Click(object sender, EventArgs e)
        {
            webDriver.MuteVideo(); // Gọi hàm mute video youtube từ file WebDriver_54_Vuong
        }

        private void btncloseyoutube_54_Vuong_Click(object sender, EventArgs e)
        {
            webDriver.CloseBrowser(); // Gọi hàm close trình duyệt từ file WebDriver_54_Vuong
        }
    }
}
