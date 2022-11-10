namespace ClassLibrary
{
    public class KeyGenerator
    {
        public static long[] GenerateRSA()
        {
            long p, q, e, d;
            p = q = 4;
            Random random = new();
            while (!p.IsPrime())
                p = random.NextInt64(32, 0x8f);
            while (!q.IsPrime() || p == q)
                q = random.NextInt64(32, 0x8f);
            long n = p * q, mod = (p - 1) * (q - 1);
            e = mod;
            while (!e.IsCoprime(mod))
                e = random.NextInt64(2, mod);
            d = e.Invert(mod);
            return new long[] { n, e, d };
        }

        public static int[] GenerateEG()
        {
            int p, g, x, y;
            p = 4;
            Random random = new();
            while (true)
            {
                while (!p.IsPrime())
                    p = random.Next(32, 0x8f);
                if ((g = p.findPrimitive()) != -1)
                    break;
            }
            x = random.Next(2, p - 1);
            y = g.power(x, p);

            return new int[] { p, g, x, y };
        }
    }
}
