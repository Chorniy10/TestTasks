namespace ConsoleApp1
{
    internal class Program
    {

        static int Solve(int[] c, int t)
        {
            long total = (long)c[0] + c[1] + c[2];

            // Якщо вже всі бажаного кольору — 0
            if (c[t] == total)
                return 0;

            // Якщо всі одного кольору, але не t — неможливо
            if ((c[0] == total || c[1] == total || c[2] == total) && c[t] != total)
                return -1;
            // Інші два кольори
            int i = (t + 1) % 3;
            int j = (t + 2) % 3;
            // Можливо лише якщо їх кількості рівні
            if (c[i] != c[j])
                return -1;
            // Мінімальна кількість зустрічей
            return c[i];
        }
        static void Main(string[] args)
        {
            int[] c = { 8, 1, 9 };   // кількість їжаків кожного кольору
            int t = 0;               // бажаний колір (0 - червоний)
            Console.WriteLine(Solve(c, t));
        }
    }
}
