//1 -> Konsol ekranına 10 kere "Kendime inanıyorum, ben bu yazılım işini hallederim!" yazdırınız.
/* for ( int i = 1; i <= 10; i++)
{
    Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
}*/


//2 -> 1 ile 20 arasındaki sayıları konsol ekranına yazdırınız.
/*for ( int i = 1; i <=20; i++ )
{
    Console.WriteLine(i);
}*/


//3 -> 1 ile 20 arasındaki çift sayıları konsol ekranına yazdırınız.
/*for (int i = 1; i<=20; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}*/


//4 -> 50 ile 150 arasındaki sayıların toplamını ekrana yazdırınız.
/*int toplam = 0;
for (int i = 50; i <= 150; i++)
{
    toplam += i;
}
Console.WriteLine("50 ile 150 arasındaki sayıların toplamı: " + toplam); */



//5-> 1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdırınız.
int tekToplam = 0;
int ciftToplam = 0;
for (int i = 1; i <=120; i++)
{
    if (i % 2 == 0 ) //cift sayı
    {
        ciftToplam += i;
    }
    else //teksayı
    {
        tekToplam += i;
    }

}
Console.WriteLine("Tek sayıların toplamı: " + tekToplam);
Console.WriteLine("Çift sayıların toplamı: " + ciftToplam);


