using Linq;

List<int> numbers = new List<int> {-87,12,54,18,-3,-16,19,48,-60,15 }; // numbers adinda yeni bir liste olusturldu ve icerisine rastgele sayilar eklendi.

// Cift Olan Sayilar
Console.WriteLine("-----Cift Sayilar-----");
var doubleNumbers = numbers.Where(numbers => numbers % 2 == 0); // numbers listesindeki cift sayilar Where metodu ile filtrelendi ve cift olan sayilarin bulunabilmesi icin modu alindi.
foreach (var number in doubleNumbers)
{
    Console.WriteLine(number);
}

// Tek Olan Sayilar
Console.WriteLine("-----Tek Sayilar-----");
var singleNumbers = numbers.Where(numbers => numbers % 2 != 0); // numbers listesindeki tek sayilar Where metodu ile filtrelendi ve tek olan sayilarin bulunabilmesi icin modu alindi cifts sayilardan farkli olarak sonucu sifir OLMAYAN sayilar istendi.
foreach (var number in singleNumbers)
{
    Console.WriteLine(number);
}

Console.WriteLine("-----Negatif Sayilar-----");
var negativeNumbers = numbers.Where(numbers => numbers < 0); // numbers listesindeki negatif sayilar Where metodu ile filtrelendi ve negatif olan sayilarin bulunabilmesi icin sifirdan kucuk sayilar istendi.
foreach (var number in negativeNumbers)
{
    Console.WriteLine(number);
}

Console.WriteLine("-----Pozitif Sayilar-----");
var positiveNumbers = numbers.Where(numbers => numbers > 0);
// numbers listesindeki pozitif sayilar Where metodu ile filtrelendi ve sifirdan buyuk sayilar istendi.
foreach (var number in positiveNumbers)
{
    Console.WriteLine(number);
}


Console.WriteLine("-----15'ten büyük ve 22'den küçük sayılar-----");
var numbersBetween = numbers.Where(numbers => numbers > 15 && numbers < 22); // numbers listesindeki 15'ten buyuk ve 22'den kucuk sayilar Where metodu ile filtrelendi ve bu sartlara uyan sayilar istendi.
foreach (var number in numbersBetween)
{
    Console.WriteLine(number);
}

Console.WriteLine("-----Sayıların kareleri-----");//YENI LISTE OLUSTURULDU.
 List<int> SquareNum = new List<int> { -87, 12, 54, 18, -3, -16, 19, 48, -60, 15 }; // numbers listesindeki sayilarin karelerini tutmak icin yeni bir liste olusturuldu. Bu listedeki degerler square metoduyla hesaplanacak.
var squareNumbers = SquareNum.Select(num => new {Original = num, Squared = num * num }); // Select metodu ile numbers listesindeki her bir sayinin karesi alindi. num=> new seklinde yazmamin sebebi , her bir sayinin orijinal degeri ve karesi ile yeni bir nesne olusturmak. Bu nesneler Original ve Squared adinda iki ozellik icerecek.
foreach (var number in squareNumbers)
{
    Console.WriteLine($"{number.Original} - Sayisinin Karesi :  {number.Squared}"); // Kareleri hesaplanan sayilar ekrana yazdirildi.
}
