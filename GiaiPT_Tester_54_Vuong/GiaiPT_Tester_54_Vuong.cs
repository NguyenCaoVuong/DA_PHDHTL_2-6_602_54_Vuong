using DA_PHDHTL_2_6_602_54_Vuong_PhepToan;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace GiaiPT_Tester_54_Vuong
{
    [TestClass]
    public class GiaiPT_Tester_54_Vuong
    {
        // TC01 (PTB1 Vô số nghiệm)
        [TestMethod]
        public void Test_giaiB1_VoSoNghiem()
        {
            // Nhập giá trị test
            float a = 0;
            float b = 0;

            string expected = "PTB1 Vô số nghiệm";
            string actual = PhepToan_54_Vuong.giaiB1(a, b);

            // Kiểm tra kết quả có đúng không
            Assert.AreEqual(expected, actual);
        }
        // TC02 (PTB1 Vô nghiệm)
        [TestMethod]
        public void Test_giaiB1_VoNghiem()
        {
            // Nhập giá trị test
            float a = 0;
            float b = 1;

            string expected = "PTB1 Vô nghiệm";
            string actual = PhepToan_54_Vuong.giaiB1(a, b);

            // Kiểm tra kết quả có đúng không
            Assert.AreEqual(expected, actual);
        }
        // TC03 (PTB1 Có nghiệm)
        [TestMethod]
        public void Test_giaiB1_CoNghiem()
        {
            // Nhập giá trị test
            float a = 2;
            float b = 4;

            string expected = "-2";
            string actual = PhepToan_54_Vuong.giaiB1(a, b);

            // Kiểm tra kết quả có đúng không
            Assert.AreEqual(expected, actual); // -4 / 2 = -2
        }
        // TC04 (PTB2 Vô nghiệm)
        [TestMethod]
        public void Test_giaiB2_VoNghiem()
        {
            // Nhập giá trị test
            float a = 1;
            float b = 2;
            float c = 3;

            string expected = "PTB2 Vô nghiệm";
            string actual = PhepToan_54_Vuong.giaiB2(a, b, c);

            // Kiểm tra kết quả có đúng không
            Assert.AreEqual(expected, actual);
        }
        // TC05 (PTB2 Nghiệm kép)
        [TestMethod]
        public void Test_giaiB2_NghiemKep()
        {
            // Nhập giá trị test
            float a = 1;
            float b = 2;
            float c = 1;

            string expected = "x1=x2=-1";
            string actual = PhepToan_54_Vuong.giaiB2(a, b, c);

            // Kiểm tra kết quả có đúng không
            Assert.AreEqual(expected, actual);
        }
        // TC06 (PTB2 Hai nghiệm)
        [TestMethod]
        public void Test_giaiB2_HaiNghiem()
        {
            // Nhập giá trị test
            float a = 1;
            float b = -3;
            float c = 2;

            string expected = "x1=2x2=1";
            string actual = PhepToan_54_Vuong.giaiB2(a, b, c);

            // Kiểm tra kết quả có đúng không
            Assert.AreEqual(expected, actual);
        }
        // TC07 (PTB2 Thực chất là PTB1)
        [TestMethod]
        public void Test_giaiB2_ThucChatLaPTB1()
        {
            // Nhập giá trị test
            float a = 0;
            float b = 1;
            float c = -1;

            string expected = "1";
            string actual = PhepToan_54_Vuong.giaiB2(a, b, c);

            // Kiểm tra kết quả có đúng không
            Assert.AreEqual(expected, actual);
        }
    }
}
