using DA_PHDHTL_2_6_602_54_Vuong_PhepToan;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace KiemTraChanLe_Tester_54_Vuong
{
    [TestClass]
    public class KiemTraChanLe_Tester_54_Vuong
    {
        // TC01
        [TestMethod]
        public void Test_KiemTraChanLe_SoChan()
        {
            // Nhập giá trị test
            float n = 100;

            string expected = "100 là số chẵn";
            string actual = PhepToan_54_Vuong.KiemTraChanLe(n);

            // Kiểm tra kết quả có đúng không
            Assert.AreEqual(expected, actual);
        }
        // TC02
        [TestMethod]
        public void Test_KiemTraChanLe_SoLe()
        {
            // Nhập giá trị test
            float n = 7;

            string expected = "7 là số lẻ";
            string actual = PhepToan_54_Vuong.KiemTraChanLe(n);

            // Kiểm tra kết quả có đúng không
            Assert.AreEqual(expected, actual);
        }
    }
}
