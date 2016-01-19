using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RIS_lab5.Utils
{
    class El_GamalGenerator
    {
        public static Int64 generateG(Int64 p)
        {
            Random rand = new Random();
            int start = (int)rand.Next((int)p / 60, (int)p - 1);
            List<Int64> fact = new List<Int64>();
            Int64 phi = p - 1, n = phi;
            for (Int64 i = 2; i * i <= n; ++i)
                if (n % i == 0)
                {
                    fact.Add(i);
                    while (n % i == 0)
                        n /= i;
                }
            if (n > 1)
                fact.Add(n);

            for (int res = start; res <= p; ++res)
            {
                bool ok = true;
                for (int i = 0; i < fact.Count && ok; ++i)
                    ok &= fast_exp(res, phi / (Int64)fact[i], p) != 1;
                if (ok) return res;
            }
            return -1;
        }

        public static Int64 generateX(Int64 p)
        {
            Int64 x;
            Random rand = new Random();
            do
            {
                x = rand.Next((int)p - 1);
            } while (x == 1 || x == 0);
            return x;
        }

        public static Int64 generateY(Int64 g, Int64 x, Int64 p)
        {
            return fast_exp(g, x, p);
        }

        public static Int64 generateK(Int64 p)
        {
            Int64 k;
            Random rand = new Random();
            do
            {
                k = rand.Next((int)p - 1);
            } while (NOD(p - 1, k) != 1);

            return k;
        }

        public static Int64 NOD(Int64 a, Int64 b)
        {
            if (a == 0) return b;
            if (b == 0) return a;
            if (a == b) return a;
            if (a == 1 || b == 1) return 1;
            if ((a % 2 == 0) && (b % 2 == 0)) return 2 * NOD(a / 2, b / 2);
            if ((a % 2 == 0) && (b % 2 != 0)) return NOD(a / 2, b);
            if ((a % 2 != 0) && (b % 2 == 0)) return NOD(a, b / 2);
            return NOD(b, (Int64)Math.Abs(a - b));
        }


        public static bool isSimple(Int64 value)
        {
            Int64 divider = 1;

            if (value == 1)
            {
                return false;
            }
            else
            {
                if (value % 2 == 0) divider = 0;
                while ((divider += 2) <= Math.Floor(Math.Sqrt(value)))
                {
                    if ((value % divider == 0))
                    {
                        return false;
                    }
                }
                return true;
            }
        }



        public static Int64 fast_exp2(Int64 a, Int64 z, Int64 n, Int64 m)// x=a^z * m mod n
        {
            return (fast_exp(a, z, n) * (m % n)) % n;
        }

        public static Int64 fast_exp(Int64 a, Int64 z, Int64 n)// x=a^z mod n
        {
            Int64 x = 1;
            while (z > 0)
            {
                if (z % 2 == 0)
                {
                    z /= 2;
                    a = a * a % n;
                }
                else
                {
                    z--;
                    x = x * a % n;
                }
            }
            return x;
        }
    }
}
