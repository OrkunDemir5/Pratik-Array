
int[] sayilar = new int[10]; // 10 elemanlı bir integer dizisi oluşturulur.
Random random = new Random(); // Random sayı üretimi için bir Random nesnesi oluşturulur.

for (int i = 0; i < sayilar.Length - 1; i++) // Diziyi doldurmak için döngü başlar; dizinin son elemanını boş bırakır.
{
    sayilar[i] = random.Next(1, 11); // 1 ile 10 arasında rastgele bir sayı diziye eklenir.
}

foreach (int i in sayilar) // Dizideki her eleman sırayla ekrana yazdırılır.
{
    Console.WriteLine(i);
}

Console.WriteLine("Yeni sayı giriniz"); // Kullanıcıdan yeni bir sayı istenir.

int yeniSayi = Convert.ToInt32(Console.ReadLine()); // Kullanıcının girdiği değer integer’a çevrilir ve yeniSayi değişkenine atanır.

Array.Resize(ref sayilar, sayilar.Length + 1); // sayilar dizisinin boyutu bir eleman artırılır, böylece yeni sayı için alan açılır.

sayilar[sayilar.Length - 1] = yeniSayi; // Yeni girilen sayı dizinin son elemanına atanır.

Array.Sort(sayilar); // Diziyi küçükten büyüğe sıralar (Array sınıfının Sort metodu).

Console.WriteLine("Büyükten küçüğe sıralanmış sayılar"); // Sonuçların başlığını yazdırır.

foreach (int i in sayilar.Reverse()) // Diziyi tersten (büyükten küçüğe) yazdırmak için foreach kullanarak sırayla elemanları ekrana yazdırır.
{
    Console.WriteLine(i);
}

Console.ReadKey(); // Programın kapanmaması için bir tuşa basılmasını bekler.