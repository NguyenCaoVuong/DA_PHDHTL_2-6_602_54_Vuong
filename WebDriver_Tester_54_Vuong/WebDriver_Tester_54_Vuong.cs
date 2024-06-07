using DA_PHDHTL_2_6_602_54_Vuong_WebDriver;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading;

namespace WebDriver_Tester_54_Vuong
{
    [TestClass]
    public class WebDriver_Tester_54_Vuong
    {
        private WebDriver_54_Vuong webDriver;

        [TestInitialize]
        public void SetUp()
        {
            webDriver = new WebDriver_54_Vuong();
        }
        // TC01 (Kiểm tra tất cả chức năng trên YouTube)
        [TestMethod]
        public void TestYouTubeChucNang()
        {
            // Khai báo nội dung cần tìm kiếm để test
            string searchTerm = "Jojo S2 Muse VN";

            // Thực hiện các chức năng
            webDriver.OpenYouTube();
            Thread.Sleep(2000);
            webDriver.SearchYouTube(searchTerm);
            Thread.Sleep(3000);
            webDriver.OpenFirstVideo();
            Thread.Sleep(3000);
            webDriver.SkipVideo();
            Thread.Sleep(3000);
            webDriver.MuteVideo();
            Thread.Sleep(3000);
            webDriver.MuteVideo();
            Thread.Sleep(3000);
            webDriver.CloseBrowser();
        }
    }
}
