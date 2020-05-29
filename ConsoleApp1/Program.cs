using System;

namespace SimpleAlgorithm
{
    class Program
    {
        private static void Main()
        {
            int[] m = { 357, 260, 198, 493, 853, -232, -15 };

            var man = m[0];
            for (var l = 1; l < m.Length; l++)
            {
                if (m[l] >= man) continue;
                man = m[l];
            }
            Console.WriteLine("Min={0}", man);
            var max = m[0];
            for (var t = 1; t < m.Length; t++)
            {
                if (m[t] <= max) continue;
                max = m[t];
            }
            Console.WriteLine("Max={0}", max);
            for (var i = 0; i < m.Length - 1; i++)
            {
                for (var j = i + 1; j < m.Length; j++)
                {
                    if (m[i] <= m[j]) continue;
                    var option = m[i];
                    m[i] = m[j];
                    m[j] = option;
                }
            }
            Console.WriteLine("По возрастанию:");
            foreach (var t in m)
            {
                Console.WriteLine(t);
            }

            for (var i = m.Length - 1 - 1; i >= 0; i--)
            {
                for (var j = m.Length - 1; j > i; j--)
                {
                    if (m[i] >= m[j]) continue;
                    var option1 = m[i];
                    m[i] = m[j];
                    m[j] = option1;
                }
            }
            Console.WriteLine("По убыванию:");

            foreach (var t in m)
            {
                Console.WriteLine(t);
            }
            Console.ReadKey();

        }
    }
}
