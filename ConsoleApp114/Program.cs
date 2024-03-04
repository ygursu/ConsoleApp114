Console.Write("Kaç adet sayı gireceksiniz:");
int n = Convert.ToInt32(Console.ReadLine());
double kareToplam = 0;
for (int i = 0; i < n; i++)
{
    Console.Write("{0}. sayıyı girin:", i + 1);
    int sayi = Convert.ToInt32(Console.ReadLine());
    kareToplam += Math.Pow(sayi, 2);

}
Console.WriteLine("Girilen sayıların karelerinin toplamı={0}", kareToplam);
Console.ReadKey();