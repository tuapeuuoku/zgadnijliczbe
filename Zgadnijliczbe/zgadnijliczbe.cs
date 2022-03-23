Random r = new Random();
int liczba = r.Next(1, 11);
int liczba2;
bool win = true;
Console.WriteLine("Wygenerowana została liczba od 1 do 10, zgadnij tę liczbę)");
liczba2 = Convert.ToInt32(Console.ReadLine());
while (liczba2 != liczba)
{
    if (liczba2 < liczba)
    {
        Console.WriteLine("Zbyt mało");
        liczba2 = Convert.ToInt32(Console.ReadLine());
    }
    else
    {
        if (liczba2 > liczba)
        {
            Console.WriteLine("Za dużo");
            liczba2 = Convert.ToInt32(Console.ReadLine());
        }
        if (liczba2 == liczba)


        {

            win = true;
            Console.WriteLine("Brawo");
            Console.WriteLine("prawidłowa liczba to" + liczba);
            break;
        }
    }
}