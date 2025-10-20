namespace _5Esercizi
{
    internal class Program
    {
        static double MediaIntervallo(int N1, int N2)
        {
            int I = 0, S = 0;
            double M;

            if (N1 < N2)
            {
                while (N1 <= N2)
                {
                    if (N1 % 2 == 1)
                    {
                        S = S + N1;
                        N1 = N1 + 2;
                        I++;
                    }
                    else
                    {
                        N1++;
                    }
                }
                M = S / I;
            }
            else
            {
                while (N2 <= N1)
                {
                    if (N2 % 2 == 1)
                    {
                        S = S + N2;
                        N2 = N2 + 2;
                        I++;
                    }
                    else
                    {
                        N1++;
                    }
                }
                M = S / I;
            }

            Console.WriteLine("La media è " + M);
            return M;

        }
        static int Fattoriale(int n)
        {
            int F = 1;

            for (int i = 1; i <= n; i++)
            {

                F = F * i;

            }

            Console.WriteLine("Il fattoriale del numero inserito è " + F);
            return F;

        }
        static int NumeroCifre(int num)
        {
            int i = 0;
            while (num > 1)
            {
                num = num / 10;
                i++;
            }
            Console.WriteLine("Il numero delle cifre è " + i);
            return i;
        }
        static string ValoreIntervallo(int Num1, int Num2, int X)
        {
            int b = 0;
            string m;

            while (Num1 <= Num2)
            {
                if (X == Num1)
                {
                    b++;
                }
                Num1++;
            }

            if (b > 0)
            {
                m = "Il numero inserito è interno all'intervallo";
            }
            else
            {
                m = "Il numero inserito è esterno all'intervallo";
            }
            Console.WriteLine(m);
            return m;
        }
        static string NumeroPerfetto(int Numero)
        {
            float D, S = 0;
            int R;
            string Mess;

            R = Numero;

            for (int i = 1; i <= Numero; i++)
            {
                D = Numero / i;

                if (D % 2 == 0)
                {
                    if (D == R)
                    {

                    }
                    else
                    {
                        S = S + D;
                    }
                }
            }

            if (S == R)
            {
                Mess = "Il numero inserito è perfetto";
            }
            else
            {
                Mess = "Il numero inserito non è perfetto";
            }

            Console.WriteLine(Mess);
            return Mess;
        }
        static void Main(string[] args)
        {
            int N1, N2, n, num, Num1, Num2, X, Numero;

            Console.WriteLine("dimmi il primo numero");
            N1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Dimmi il secondo numero");
            N2 = Convert.ToInt32(Console.ReadLine());

            MediaIntervallo(N1, N2);

            Console.WriteLine("Dimmi un numero per calcolare il fattoriale");
            n = Convert.ToInt32(Console.ReadLine());

            Fattoriale(n);

            Console.WriteLine("Dimmi un numero per calcolare il numero delle cifre");
            num = Convert.ToInt32(Console.ReadLine());

            NumeroCifre(num);

            Console.WriteLine("Dimmi il primo numero dell'intervallo");
            Num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Dimmi il secondo numero dell'intervallo");
            Num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Dimmi un numero");
            X = Convert.ToInt32(Console.ReadLine());

            ValoreIntervallo(Num1, Num2, X);

            Console.WriteLine("Dimmi un numero");
            Numero = Convert.ToInt32(Console.ReadLine());

            NumeroPerfetto(Numero);
        }
    }
}

