namespace Zadanie_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Wprowadzanie_Przez_Urzytkownika();
            Losowanie_z_Sprawdzaniem(n);
            Losowanianie_liczb_parzystych(n);
            




        }


       
        
        public static int Wprowadzanie_Przez_Urzytkownika()
        {
            int liczba = int.Parse(Console.ReadLine());
            return liczba;
        }
        public static void Losowanie_z_Sprawdzaniem(int n)
        {   Random generator=new Random();
            int checker = 1;
            int liczba_temp;
            int proby = 0;
            while(checker<=n)
            {   liczba_temp = 0;
                liczba_temp = generator.Next(-8, 9);
                if(liczba_temp%2==0)
                {
                    Console.WriteLine((proby+1)+"."+" "+liczba_temp);
                    checker++;
                   
                }
                proby++;
            }
            Console.WriteLine("Próby=" + proby);

        }
        public static void  Losowanianie_liczb_parzystych(int n)
        {
            Random generator = new Random();
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine((i+1)+".\t"+generator.Next(-4, 4) * 2);

            }



        }
    }
    
    
    
}