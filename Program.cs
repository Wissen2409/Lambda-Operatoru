

// Lambda Operatörü => şeklinde yazılır!!

// Temel işlevi : koleksiyonların içerisinde sorgulama yapabilmektiréé


using System.Collections;
using System.Security.Cryptography.X509Certificates;

List<Personel> personels = new List<Personel>();
personels.Add(new Personel() { Id = 1, Name = "Ramazan", Age = 12 });
personels.Add(new Personel() { Id = 2, Name = "Ali", Age = 24 });
personels.Add(new Personel() { Id = 3, Name = "Burak", Age = 19 });
personels.Add(new Personel() { Id = 4, Name = "Selçuk", Age = 11 });
personels.Add(new Personel() { Id = 5, Name = "Nuray", Age = 50 });
personels.Add(new Personel() { Id = 6, Name = "Hatice", Age = 45 });
personels.Add(new Personel() { Id = 7, Name = "Burak", Age = 9 });

// Lambda Operatörü : 

// Adında e geçen personeller
/*var result = personels.Where(c=>c.Name.Contains("e"));
foreach(var item in result){

    Console.WriteLine(item.Name);
}*/

// Yaşı 11 den büyük olan personeller
/*var ageResult = personels.Where(x=>x.Age>11);
foreach(var item in ageResult){
    Console.WriteLine(item.Name);
    Console.WriteLine(item.Age);
}
*/

// İsmi 3 karakter olan personeli sorgulayalım

// Where metodu her zaman bir koleksiyon döner!!!
// Siz tek bir sonuç filtreleseniz bile!!!!

// Bunun için farklı bir metotdan faydalanmamız lazım!!
// metodun Adı : SingleOrDefault
// singleOr default  metodu : Where metodundan çoklu gelen sonucu teke düşürür
// Eğer veri gelmezse, default olan değeri yani null değerini döner!!

// eğer iki veri varken, singleOrDefault kullanırsak, çalışma zamanı hatası alırız
// böyle bir durumda, FirstOrDefault kullanılmalıdır!!

// first Or default adından da anlaşılacağı gibi, çoklu veri gelirse, ilk sıradakini gösterir
/*var selectPersonel = personels.Where(s => s.Name.Length == 2).FirstOrDefault();
if (selectPersonel != null)
{
    // tek bir personel dahi dönse, yinede foreach ile gezmek sorundayız!!!!
    Console.WriteLine(selectPersonel.Name);
}*/

// bir sınıfın içerisinde döngü ile dönebilmek için IEnumarable interfacei gereklidir aynı zamanda, 
// o sınıf içerisindeki yield return olması lazım

// bir sınıfa [] indexer açabilmek için o sınıf içerisinde indexer tanımlı olması lazımdır

// Örnek : 
// adı n ile başlayanlar
// yaşı 30 dan küçük olanlar
//  adı nuray olanlar
// id değeri tekil olanlar

// üç sorguyu aynı anda yazalım 

/*IEnumerable<Personel> selectedPerson = personels.Where(s => s.Id % 2 == 1 && s.Name.StartsWith("N") && s.Age > 40);
foreach(Personel p in selectedPerson){
    Console.WriteLine(p.Name);
}*/


// bu sınıfı bir metotdan geriye interface döndürmek için sağlama yapmak için yazdık!!!
Helper h = new Helper();

// Where metodu, predicate delege alır, Predicate generic bir tip alan ve geriye bool değer döndüren bir delegedir
// dolayısıyla, where metodu içerisinden geriye bool değer döndürülmelidir!!

// 

// Lambda operatörü : Bir metottur!!
// Bir metotur cümlesini açtığımda: Bir Delegedir
// Delege : Metot işaret edebilen yapılara denir!! 


// where metodu kullanıldıktan sonra, order by metotları kullanılabilir!!

// Örnek : personel listesini yazdıralım ve ad alanına göre sıralalım

//OrderBy
// ıd değeri tek sayi olan personelleri sıralayalım
/*var pers = personels.Where(s=>s.Id%2==1).OrderBy(s=>s.Name);
foreach(var p in pers){
    Console.WriteLine(p.Name);
}*/

// Tersten sıralayalım OrderByDescending
/*var pers = personels.Where(s=>s.Id%2==1).OrderByDescending(s=>s.Name);
foreach(var p in pers){
    Console.WriteLine(p.Name);
}*/


// Almış olduğun sonucu koleksiyona çevirmek 
// TOList 
/*List<Personel> personelListesi = personels.Where(s=>s.Name.StartsWith("a")).ToList();

//TOArray: sonucu diziye çevirir!!
Personel[] personelListesiDizi =  personels.Where(s=>s.Name.StartsWith("a")).ToArray();
*/

// Select metodu : sorgulama sonucu gelen sonuç içerisinden istenilen alanları alma!!!
// tüm listede sadece ad alanlarını alalım 
var onlyName = personels.Select(s => s.Name).ToList();
foreach (string item in onlyName)
{
    Console.WriteLine(item);
}
// select metodu ile sonuç olaran dönecek olan tip belirlenir, bazen sınıf içerisindeki bir değişken, bazende
// yeni bir tip dönülebilir!!
// Örnek  : Personel listesini, Ogrenci listesine dönüştürelim 
List<Ogrenci> ogrenciListesi = personels.Select(personel => new Ogrenci()
{
    Id = personel.Id,
    Name = personel.Name
}).ToList();

foreach (Ogrenci o in ogrenciListesi)
{
    Console.WriteLine("Id : {0} Ad : {1} ", o.Id, o.Name);
}