//1. Soru
Console.WriteLine("1) Konsol ekranına 10 kere \"Kendime inanıyorum, ben bu yazılım işini hallederim!\" yazdırınız."); 
for ( int i = 1; i <= 10; i++) //indexi 1 aldık, 10'dan küçük eşit şeklinde belirledik ki 10 defa yazdırsın. i++ ile artırdık
{
    Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
}


Console.WriteLine(" ");
Console.WriteLine("----------------------------------------------------------------------");
Console.WriteLine(" ");


//2. Soru
Console.WriteLine("2) 1 ile 20 arasındaki sayıları konsol ekranına yazdırınız.");
for ( int i = 1; i <=20; i++ ) //indexi 1 aldık ve 20'den küçük eşit şeklinde belirledik. Bu şekilde 20'ye kadar sayacağız. i++ ile artırdık.
{
    Console.WriteLine(i); //i ile sayıları atadık.
}

Console.WriteLine(" ");
Console.WriteLine("----------------------------------------------------------------------");
Console.WriteLine(" ");


//3. Soru
Console.WriteLine("1 ile 20 arasındaki çift sayıları konsol ekranına yazdırınız.");
for (int i = 1; i<=20; i++) //aynı şekilde 20'ye kadar yazdıracağız
{
    if (i % 2 == 0) // ancak sadece 2'ye bölünenleri almak istiyoruz ki çift sayılar yazdırılsın. Bu nedenle if kullandık.
    {
        Console.WriteLine(i); //2'ye bölünenleri yazdırdık.
    }
}


Console.WriteLine(" ");
Console.WriteLine("----------------------------------------------------------------------");
Console.WriteLine(" ");


//4. Soru
Console.WriteLine("4) 50 ile 150 arasındaki sayıların toplamını ekrana yazdırınız.");
int toplam = 0; //başlangıçta toplamı 0 aldık.
for (int i = 50; i <= 150; i++) // 50 ile 150 arasındaki sayıları istediğimiz için i'yi 50'ye eşit ve 150'den küçük eşit aldık.
{
    toplam += i; //toplam += ile sayıları toplayıp i ile atadık.
}
Console.WriteLine("50 ile 150 arasındaki sayıların toplamı: " + toplam); //cw ile sayıların toplamını gösteren bir ifade yazdık ve sonunda toplam yazarak tamamladık.


Console.WriteLine(" ");
Console.WriteLine("----------------------------------------------------------------------");
Console.WriteLine(" ");



//5. Soru
Console.WriteLine("5) 1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdırınız.");
int tekToplam = 0; //tek sayıların toplamını 0 aldık.
int ciftToplam = 0; //çift sayıların toplamını 0 aldık.
for (int i = 1; i <=120; i++) //1 ile 120 arasında olacağı için 1'e eşit 120'ye küçük eşit aldık.
{
    if (i % 2 == 0 ) //cift sayı
    {
        ciftToplam += i; //çift sayıları topladık ve atadık.
    }
    else //teksayı
    {
        tekToplam += i; //tek sayıları topladık ve atadık.
    }

}
Console.WriteLine("Tek sayıların toplamı: " + tekToplam); //tek sayıların toplamını yazdırdık.
Console.WriteLine("Çift sayıların toplamı: " + ciftToplam); //çift sayıların toplamını yazdırdık.


