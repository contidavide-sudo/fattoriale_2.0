namespace fattoriale_2._0
{
    internal class Program
    {
        static bool Pari(int n)
        {
            if (n % 2 == 0)
            {
                return true;
            }
            else 
            { 
                 return false;
            }
        }
        static int Fattoriale(int n)
        {
            int m = 1;

            for (int i = 1; i <= n; i++)
            {

                m = m * i;

            }

            return m;
        }
        static void Main(string[] args)
        {
            int num = 10, cont = 0;

            for (int i = 1; i <= num; i++)
            {
                if (Pari(i) == true)
                {
                    int fat = Fattoriale(i);
                    cont = fat + cont;
                }
            }

            Console.WriteLine(cont);
        }
    }
}
