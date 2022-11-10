using System.Text;

namespace ClassLibrary
{
    public class RSA
    {
        public RSA() { }
        static public string Encode(string data, long[] keys)
        {
            var builder = new StringBuilder();
            long n = keys[0], e = keys[1];
            int len = (int)Math.Floor(Math.Log10(n));

            for (int i = 0; i < data.Length; i += len)
            {
                var left = data.Length - i;
                var step = left < len ? left : len;
                long curr = long.Parse(data.Substring(i, step));

                builder.Append(curr.power(e, n));
                builder.Append(' ');
            }

            return builder.ToString();
        }

        static public string Decode(string data, long[] keys)
        {
            var builder = new StringBuilder();
            long n = keys[0], d = keys[1];

            var arr = data.Split(' ');

            foreach (var value in arr)
            {
                long number = long.Parse(value);
                builder.Append(number.power(d, n));
            }

            return builder.ToString();
        }
    }
}