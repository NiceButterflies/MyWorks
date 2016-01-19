using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace RIS_lab5.Utils
{
    class El_Gamal
    {
        public static Int64 p;
        public static Int64 G;
        public static Int64 X;
        public static Int64 Y;
        public static Int64 K;

        public static int shifr(String str, BigInteger p, BigInteger g, BigInteger y, BigInteger x, BigInteger k)
        {
            StringBuilder result = new StringBuilder();
            BigInteger a = fast_exp(g, k, p);
            BigInteger b = (fast_exp2(y, k, p, new BigInteger(str[0])));
            BigInteger c = a + b;
            return Int32.Parse(c.ToString());
        }

        public static String deshifr(String str, BigInteger p, BigInteger g, BigInteger y, BigInteger x, BigInteger k)
        {
            BigInteger b, a;
            char[] devider = { ' ' };
            String[] text = str.Split(devider);
            StringBuilder result = new StringBuilder();
            a = (BigInteger)Int64.Parse(text[0]);
            for (int i = 1; i < text.Length - 1; i++)
            {

                b = (BigInteger)Int64.Parse(text[i]);
                BigInteger m = fast_exp2(a, p - 1 - x, p, b);
                result.Append((char)m);
            }
            return result.ToString();
        }


        public static BigInteger fast_exp2(BigInteger a, BigInteger z, BigInteger n, BigInteger m)
        {
            return (BigInteger.Multiply(fast_exp(a, z, n), (m % n))) % n;
        }

        public static BigInteger fast_exp(BigInteger a, BigInteger z, BigInteger n)
        {
            return BigInteger.ModPow(a, z, n);
        }
    }
}

