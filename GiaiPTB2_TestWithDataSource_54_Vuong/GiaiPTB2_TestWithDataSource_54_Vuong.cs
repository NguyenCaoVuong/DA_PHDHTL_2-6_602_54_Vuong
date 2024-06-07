using DA_PHDHTL_2_6_602_54_Vuong_PhepToan;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Text;

namespace GiaiPTB2_TestWithDataSource_54_Vuong
{
    [TestClass]
    public class GiaiPTB2_TestWithDataSource_54_Vuong
    {
        public TestContext TestContext { get; set; }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @".\Data\TestData.csv", "TestData#csv", DataAccessMethod.Sequential)]
        [TestMethod]
        public void GiaiPTB2_54_Vuong()
        {
            // Trích xuất dữ liệu kiểm tra từ dòng hiện tại của tệp CSV
            float a = float.Parse(TestContext.DataRow[0].ToString());
            float b = float.Parse(TestContext.DataRow[1].ToString());
            float c = float.Parse(TestContext.DataRow[2].ToString());
            string expected = TestContext.DataRow[3].ToString();

            // Chuyển đổi chuỗi sang mã UTF-8
            byte[] expectedBytes = Encoding.Default.GetBytes(expected);
            expected = Encoding.UTF8.GetString(expectedBytes);

            // Gọi phương thức được kiểm tra với dữ liệu đầu vào
            string actual = PhepToan_54_Vuong.giaiB2(a, b, c);

            // Kiểm tra kết quả
            Assert.AreEqual(expected, actual);
        }
    }
}
