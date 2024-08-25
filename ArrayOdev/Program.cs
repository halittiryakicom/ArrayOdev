//dizi tanımlandı
int[] array = new int[10];


//diziye eleman eklendi
Random rnd = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = rnd.Next(1,100);
}

//elemanlar ekranda gösterildi
Console.WriteLine("---------- Dizi Elemanları ----------");
foreach (int i in array)
{
    Console.WriteLine(i);
}


//Diziye 11. elemanı ekleme
Console.WriteLine("---------- Diziye 11. elemanı ekleme ----------");
bool deger;
int newNum;
do
{
    Console.Write("11.sayımızı giriniz:");
    deger = int.TryParse(Console.ReadLine(), out newNum);

} while (!deger);


//Diziyi yeniden boyutlandırma
Array.Resize(ref array, 11);
array[10] = newNum;


//Diziyi büyükten küçüğe yazdırma
Console.WriteLine("---------- Büyükten küçüğe ----------");
Array.Sort(array);
Array.Reverse(array);
for(int i = 0; i < array.Length; i++)
{
    Console.WriteLine($"{i+1}. eleman: {array[i]}");
}