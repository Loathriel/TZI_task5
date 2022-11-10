
namespace ClassLibrary
{
    public class EG
    {
        public EG() { }
        static public string Sign(string data, int[] keys)
        {
            int p = keys[0], g = keys[1], x = keys[2];
            int r = p - 1;
            while (!((long)r).IsCoprime((p-1)))
                r = new Random().Next(2, p - 1);
            int s1 = g.power(r, p);
            int m = Hash(data);
            r = r.Invert(p - 1);
            int s2 = ((m - x * s1) * r).Mod(p - 1);

            return $"{s1} {s2}";
        }

        static public bool Check(string data, string sign, int[] keys)
        {
            int p = keys[0], g = keys[1], h = keys[2];
            int m = Hash(data);
            var split = sign.Split(' ');
            int s1 = int.Parse(split[0]), s2 = int.Parse(split[1]);

            int c1 = g.power(m, p);
            int c2 = (h.power(s1, p) * s1.power(s2, p)).Mod(p);

            return c1 == c2;
        }

        static public int Hash(string data)
        {
            int result = 0;
            int len = 9;
            for (int i = 0; i < data.Length; i += len)
            {
                var left = data.Length - i;
                var step = left < len ? left : len;
                int elem = int.Parse(data.Substring(i, step));
                result += elem;
            }
            return result.power(data.Length, 0x7FFFFFFF);
        }
    }
}
