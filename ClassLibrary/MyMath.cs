namespace ClassLibrary
{
    public static class MyMath
    {
        public static long gcd(this long a, long b)
        {
            if (a == 0 || b == 0)
                return 0;

            if (a == b)
                return a;

            if (a > b)
                return b.gcd(a - b);

            return a.gcd(b - a);
        }

        public static long Mod(this long k, long n)
        {
            return ((k %= n) < 0) ? k + n : k;
        }

        public static int Mod(this int k, int n)
        {
            return ((k %= n) < 0) ? k + n : k;
        }

        public static long Invert(this long value, long modulus)
        {
            long t = 0, r = modulus, newT = 1, newR = value;

            while (newR != 0)
            {
                var q = r / newR;
                (t, newT) = (newT, t - (q * newT));
                (r, newR) = (newR, r - (q * newR));
            }

            return r <= 1
                ? t < 0
                    ? t + modulus
                    : t
                : 0;
        }
        public static int Invert(this int value, int modulus)
        {
            int t = 0, r = modulus, newT = 1, newR = value;

            while (newR != 0)
            {
                var q = r / newR;
                (t, newT) = (newT, t - (q * newT));
                (r, newR) = (newR, r - (q * newR));
            }

            return r <= 1
                ? t < 0
                    ? t + modulus
                    : t
                : 0;
        }

        public static bool IsPrime(this long number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
                if (number % i == 0)
                    return false;

            return true;
        }
        public static bool IsPrime(this int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
                if (number % i == 0)
                    return false;

            return true;
        }
        public static bool IsCoprime(this long n1, long n2)
        {
            return n1.gcd(n2) == 1;
        }
        public static void findPrimefactors(this int n, out HashSet<int> s)
        {
            s = new HashSet<int>();
            while (n % 2 == 0)
            {
                s.Add(2);
                n /= 2;
            }

            for (int i = 3; i <= Math.Sqrt(n); i += 2)
            {
                while (n % i == 0)
                {
                    s.Add(i);
                    n /= i;
                }
            }

            if (n > 2)
            {
                s.Add(n);
            }
        }
        public static int power(this int x, int y, int p)
        {
            int res = 1;

            x %= p;

            while (y > 0)
            {
                if (y % 2 == 1)
                {
                    res = (res * x) % p;
                }

                y >>= 1;
                x = (x * x) % p;
            }
            return res;
        }
        public static long power(this long x, long y, long p)
        {
            long res = 1;

            x %= p;

            while (y > 0)
            {
                if (y % 2 == 1)
                {
                    res = (res * x) % p;
                }

                y >>= 1;
                x = (x * x) % p;
            }
            return res;
        }
        public static int findPrimitive(this int n)
        {
            if (!n.IsPrime())
                return -1;

            int phi = n - 1;

            findPrimefactors(phi, out HashSet<int> s);

            for (int r = 2; r <= phi; r++)
            {
                bool flag = false;
                foreach (int a in s)
                {
                    if (r.power(phi / (a), n) == 1)
                    {
                        flag = true;
                        break;
                    }
                }
                if (flag == false)
                    return r;
            }

            return -1;
        }
    }
}