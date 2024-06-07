using DA_PHDHTL_2_6_602_54_Vuong_PhepToan;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Net.NetworkInformation;
using System.Text;

namespace GiaiPTB1_TestWithDataSource_54_Vuong
{
    [TestClass]
    public class GiaiPTB1_TestDataWithSource_54_Vuong
    {
        public TestContext TestContext { get; set; }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @".\Data\TestData.csv", "TestData#csv", DataAccessMethod.Sequential)]
        [TestMethod]
        public void GiaiP1B1_54_Vuong()
        {

            // Trích xuất dữ liệu kiểm tra từ dòng hiện tại của tệp CSV
            float a = float.Parse(TestContext.DataRow[0].ToString());
            float b = float.Parse(TestContext.DataRow[1].ToString());
            string expected = TestContext.DataRow[2].ToString();

            // Chuyển đổi chuỗi sang mã UTF-8
            byte[] expectedBytes = Encoding.Default.GetBytes(expected);
            expected = Encoding.UTF8.GetString(expectedBytes);

            // Gọi phương thức được kiểm tra với dữ liệu đầu vào
            string actual = PhepToan_54_Vuong.giaiB1(a, b);

            // Kiểm tra kết quả
            Assert.AreEqual(expected, actual);
        }
    }
}
