namespace CarrosIguais
{
    public class Program
    {
        public static void Main()
        {
            var solucao = Solution(new string[] { "100", "110", "010", "011", "100" });
            foreach (var item in solucao)
                Console.WriteLine(item);
        }

        internal static int[] Solution(string[] cars)
        {
            int[] arrInt = new int[cars.Length];
            for (int i = 0; i < cars.Length; i++)
                for (int j = i + 1; j < cars.Length; j++)
                    if (i != j && IsEquals(cars[i], cars[j]))
                    {
                        arrInt[i]++;
                        arrInt[j]++;
                    }
            return arrInt;
        }

        internal static bool IsEquals(string a, string b)
        {
            int diff = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != b[i])
                    diff++;
                if (diff > 1)
                    return false;
            }
            return true;
        }
    }
}