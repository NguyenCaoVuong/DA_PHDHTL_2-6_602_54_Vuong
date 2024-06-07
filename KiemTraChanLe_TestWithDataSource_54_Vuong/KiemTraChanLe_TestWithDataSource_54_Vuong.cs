using DA_PHDHTL_2_6_602_54_Vuong_PhepToan;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Text;

namespace KiemTraChanLe_TestWithDataSource_54_Vuong
{
    [TestClass]
    public class KiemTraChanLe_TestWithDataSource_54_Vuong
    {
        public TestContext TestContext { get; set; }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @".\Data\TestData.csv", "TestData#csv", DataAccessMethod.Sequential)]
        [TestMethod]
        public void KiemTraChanLe_54_Vuong()
        {

            // Trích xuất dữ liệu kiểm tra từ dòng hiện tại của tệp CSV
            float so = float.Parse(TestContext.DataRow[0].ToString());
            string expected = TestContext.DataRow[1].ToString();

            // Chuyển đổi chuỗi sang mã UTF-8
            byte[] expectedBytes = Encoding.Default.GetBytes(expected);
            expected = Encoding.UTF8.GetString(expectedBytes);

            // Gọi phương thức được kiểm tra với dữ liệu đầu vào
            string actual = PhepToan_54_Vuong.KiemTraChanLe(so);

            // Kiểm tra kết quả
            Assert.AreEqual(expected, actual);
        }
    }
}
