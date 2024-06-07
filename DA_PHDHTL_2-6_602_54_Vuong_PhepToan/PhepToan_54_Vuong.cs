using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_PHDHTL_2_6_602_54_Vuong_PhepToan
{
    public class PhepToan_54_Vuong
    {
        // Khai báo ba biến công khai kiểu float: a, b, c
        public float a, b, c;
        public PhepToan_54_Vuong(float a, float b, float c)
        {
            // Gán giá trị tham số cho các biến của lớp
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public static String giaiB1(float a, float b)
        {
            // Nếu a bằng 0
            if (a == 0)
            {
                // Nếu b cũng bằng 0, phương trình có vô số nghiệm
                if (b == 0)
                    return "PTB1 Vô số nghiệm";
                // Nếu b khác 0, phương trình vô nghiệm
                else
                    return "PTB1 Vô nghiệm";
            }
            else
            {
                // Nếu a khác 0, phương trình có nghiệm duy nhất là -b/a
                return "" + (-b / a);
            }
        }
        public static String giaiB2(float a, float b, float c)
        {
            if (a == 0)
            {
                // Gọi phương thức giải phương trình bậc nhất
                return giaiB1(b, c);
            }
            else
            {
                // Tính delta (d)
                float d = (b * b) - (4 * a * c);
                if (d < 0)
                {
                    // Nếu delta nhỏ hơn 0, phương trình vô nghiệm
                    return "PTB2 Vô nghiệm";
                }
                // Nếu delta bằng 0, phương trình có nghiệm kép
                else if (d == 0)
                {
                    return "x1=x2=" + (-b / (2 * a));
                }
                // Nếu delta lớn hơn 0, phương trình có hai nghiệm phân biệt
                else
                {
                    float x1 = (float)(-b + Math.Sqrt(d)) / (2 * a);
                    float x2 = (float)(-b - Math.Sqrt(d)) / (2 * a);
                    return "x1=" + x1 + "x2=" + x2;
                }
            }
        }
        public static string KiemTraChanLe(float n)
        {
            // Nếu n chia hết cho 2, n là số chẵn
            if (n % 2 == 0)
            {
                return $"{n} là số chẵn";
            }
            // Nếu n không chia hết cho 2, n là số lẻ
            else
            {
                return $"{n} là số lẻ";
            }
        }
    }
}
