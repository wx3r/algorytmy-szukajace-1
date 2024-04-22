using System.CodeDom.Compiler;

class Program 
{
    static void Main(string[] args)
    {
        int[] tab = WygenerujRandTab(100);

        int liczba = 38;

        //wyszukiwanie liniowe
        int wynikWyszukiwaniaLiniowego = WyszukiwanieLiniowe(tab, liczba);
        Console.WriteLine($"Wyszukiwanie liniowe: {wynikWyszukiwaniaLiniowego}");

        //wyszukiwanie liniowe z wartownikiem
        int wynikWyszukiwaniaWart = WyszukiwanieLinioweWartownik(tab, liczba);
        Console.WriteLine($"Wyszukiwanie liniowe z wartownikiem: {wynikWyszukiwaniaLiniowego}");
        Console.ReadLine();

        //tab liczb losowych
        static int[] WygenerujRandTab(int wielkosc)
        {
            Random random = new Random();
            int[] tab = new int[wielkosc];
            for (int i = 0;i < wielkosc; i++)
            {
                tab[i] = random.Next(100);
            }
            return tab;
        }

        //wyszukiwanie liniowe 
        static int WyszukiwanieLiniowe(int[] tab, int liczba)
        {
            for (int i = 0; i < tab.Length; i++)
            {
                if (tab[i] == liczba)
                {
                    return i; //zwraca jeśli została znaleziona
                }
            }
            return -1; //zwraca -1 jeśli nie została znaleziona
        }

        //wyszukiwanie z wartownikiem
        static int WyszukiwanieLinioweWartownik(int[] tab, int liczba)
        {
            int ostatniId = tab.Length - 1;
            int ostatniaWart = tab[ostatniId];
            tab[ostatniId] = liczba; //wartownik na końcu tab

            int i = 0;
            while (tab[i] != liczba) 
            {
                i++;
            }

            tab[ostatniId] = ostatniaWart;

            if (i < ostatniId || tab[ostatniId] == liczba)
            {
                return i;
            }
            else
            {
                return -1;
            }
        }
    }
}