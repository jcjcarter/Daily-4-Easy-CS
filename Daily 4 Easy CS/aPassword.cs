using System;
using System.Text;

namespace Daily_4_Easy_CS
{
    public class aPassword : iPassword
    {
        public string randonPassword()
        {
            StringBuilder sb = new StringBuilder();
            Random ranInt = new Random();

            for (int i = 0; i < 10; i++) {
                sb.Append((char)ranInt.Next(33,126));
            }

            return sb.ToString();
        }
    }
}
