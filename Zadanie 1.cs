namespace Zadanie_1
{
    internal class Program
    {
        static void Main(string[] args)
        { int licznik = 1;
            int podana_liczba = int.Parse(Console.ReadLine());
            int liczba_pocz = 2;
            if(podana_liczba >0)
            {   if(podana_liczba==1)
                {
                    Console.WriteLine(liczba_pocz);
                }
                    else
                    {
                    Console.WriteLine($"{liczba_pocz}");
                    liczba_pocz++;
                        while(licznik!=podana_liczba)
                        { int test = 0;
                            for(int i=2; i<liczba_pocz; i++)
                            {
                                if(liczba_pocz%i==0)
                                {
                                test++;
                                }
                                    
                              
                                    
                                    
                            }
                                if(test==0)
                                {
                                Console.WriteLine(liczba_pocz);
                                licznik++;
                               
                                }
                        liczba_pocz++;
                        }
                    }
                




            }
            
            


           
        }
    }
}