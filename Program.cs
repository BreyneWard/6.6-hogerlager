namespace _6._6_hogerlager;
class Program
{
    static void Main(string[] args)
    {
         
        Random orakel = new Random();
        int getal = orakel.Next(1, 101);
        int gok = 0;
        int pogingen = 0;

        do
        {
            if(pogingen != 10)
            {
                Console.WriteLine($"Raad het getal van 1 t.e.m. 100. (10 pogingen):");
                gok = int.Parse(Console.ReadLine());
                if (gok > getal)
                {
                    Console.WriteLine("Fout getal: Getal is lager.");
                    pogingen++;
                }
                else if (gok < getal)
                {
                    Console.WriteLine("Fout getal: Getal is hoger.");
                    pogingen++;
                }
                else
                {
                    pogingen++;
                    Console.WriteLine($"Gewonnen in {pogingen} pogingen.");
                }      
            }
            else
            {
                Console.WriteLine($"Verloren: max aantal pogingen bereikt.");
                break;
            }
        }while (getal != gok);    
    }
}
