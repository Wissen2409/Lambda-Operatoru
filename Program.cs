

// Lambda Operatörü => şeklinde yazılır!!

// Temel işlevi : koleksiyonların içerisinde sorgulama yapabilmektiréé


using System.Collections;

List<Personel> personels = new List<Personel>();
personels.Add(new Personel(){ Id=1, Name="Ramazan", Age=12});
personels.Add(new Personel(){ Id=2, Name="Ali", Age=24});
personels.Add(new Personel(){ Id=3, Name="Oğuz", Age=19});
personels.Add(new Personel(){ Id=4, Name="Selçuk", Age=11});
personels.Add(new Personel(){ Id=5, Name="Nur", Age=50});
personels.Add(new Personel(){ Id=6, Name="Hatice", Age=45});
personels.Add(new Personel(){ Id=7, Name="Burak", Age=27});

// Lambda Operatörü : 

var result = personels.Where(x=>x.Name.Contains("e"));
foreach(var item in result){

    Console.WriteLine(item.Name);

}