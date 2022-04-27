# Object Orientented Programming

C# nesne yönelimli bir programlama dili olduğu için tüm metot ve özellikler sınıflar içinde yer alır. 
<br> OOP da kullanılan bazı kavramlar:

### 1. Field / Özellik

```
Sınıf içerisinde tanımlanan değişkenlere field denilmektedir.
MyClass sınıfının içerisinde color ve maxSpeed adınında iki tane field bulunmaktadır.
```
![image](https://user-images.githubusercontent.com/62007900/165467792-7b84c7c6-0dc0-4d27-a497-d9ed0535f5f4.png)

<br>

### 2. Instance / Örnek

```
Classtan türetilen nesnelere instance denir. Bu nesneler ile sınıfımızın bir örneğini olusturmuş oluyoruz. 
Bu instancelar sayesinde ise sınıf içerisinde erişime açık olan metot ve fieldlara erişim sağlayabiliyoruz.
```
```cs
//Bu şekilde sınıfımızın bir örneğini oluşturmuş olduk.

  MyClass ornek = new MyClass();
```
<br>

### 3. Property 

```
Bir sınıf içerisindeki tanımlanan fieldlar dışarıdan erişime kapalı olabilir. 
Bu alanlara kontrollü bir şekilde erişim sağlayabilmek içinde propertyler tanımlanmaktadır.
```
```cs
//name fieldına kontrollü bir şekilde erişim sağlamış olduk.

class Person

{
  private string name; // field
  public string Name   // property
  {
    get { return name; }
    set { name = value; }
  }
}

class Program
{
  static void Main(string[] args)
  {
    Person myObj = new Person();
    myObj.Name = "Liam";
    Console.WriteLine(myObj.Name);
  }
}
```

<br>

### 4. Erişim Belirleyiciler 

```
Erişim belirleyiciler önüne geldiği öğenin projenin nerelerinden erişilebileceğini belirler. Öğeleri korur gibi düşünebilirsiniz.

1. Public : Her yerden erişilebilir.

2. Private : Sadece tanımlandığı sınıf içerisinden erişilebilir.

3. Internal : Sadece bulunduğu proje içerisinden erişilebilir

4. Protected : Sadece tanımlandığı sınıfta ya da o sınıfı miras alan sınıflardan erişilebilir.
```

***
<br>

## • Constructor (Yapıcı-Kurucu) Metotlar

```
Sınıf nesnesi ilk oluşturulduğun da çalışan metotdur. Bunun içinde nesne ilk 
oluşturulduğunda yapılacak işleri kurucu metot içerisine yazarız.

1.Yapıcı metotların isimleri sınıf isimleri ile aynı olmak zorundadır.
2.Public olarak bildirilmeleri gerekir.
3.Geri dönüş değerleri yoktur.
```

```cs

// Create a Car class
class Car
{
  public string model;  // Create a field

  // Create a class constructor for the Car class
  public Car()// Kurucu metot
  {
    model = "Mustang"; // Set the initial value for model
  }

  static void Main(string[] args)
  {
    Car Ford = new Car();  // Create an object of the Car Class (this will call the constructor)
    Console.WriteLine(Ford.model);  // Print the value of model
  }
}
```

<br>


## • Encapsulation (Kapsülleme)

```
Tanımladığımız özelliklerin başka sınıflar içerisinde erişimini kısıtlamak istiyorsak bunu kapsülleme ile yaparız. 
Kapsülleme işlemini ise property leri kullanarak yapabilirsiniz.

Kapsülleme sayesinden nesneler bilinçsiz olarak kullanımdan korunmuş olur. 
Fakat bazı durumlarda private field'lara erişmemiz ve özelliklerini değiştirmemiz gerekebilir. 
Bu durumda Property Kavramı devreye girer. Property bir field'ın değerini geri döndürmeye(Get) ve 
yeni bir değer(Set) atamaya olanak sağlar.
```
```cs
lass Ogrenci
{
    private string name; //field

    public string Name //property
    {
        get { return name; }
        set { name = value; }
    }
}
```

<br>

## • Static Sınıf ve Üyeler

```
Bir sınıfın static olamayan üyelerine nesneler aracılığıyla erişirken static olan metotlara ve 
özelliklere ise nesne oluşturmadan o sınıfın ismi aracılığıyla erişim sağlayabiliyoruz.
Static olmayan üyeler nesne bazında yaratıldıkları için her nesne oluşturuldugunda kendine ait degerleri taşıyabilirken,
static sınıf üyelerinin nesneleri olmadığı için uygulama çalıştığı sürece kendilerine atanan veriyi tutarlar. 
```
```cs
class Ogrenci
{
    public static int OgrenciSayisi = 0; // static olarak tanımlanmış bir field
    public string Isim;
    public string Soyisim;
    public Ogrenci() // Yapıcı metot
    {
        OgrenciSayisi++;
    }
}

class Program
{
    static void Main(string[] args)
    {
        //Static sınıf üyesine erişim
        // static tanımlanmış bir field a Ogrenci.OgrenciSayisi diyerek direk erişim sağlanıyor.
        Console.WriteLine("Öğrenci sayısı: {0}",Ogrenci.OgrenciSayisi);

        //Static olmayan sinif üyesine erişim
        Ogrenci ogrenci1 = new Ogrenci();
        ogrenci1.Isim = "Deniz";
        ogrenci1.Soyisim = "Arda";
      }
}
        
```

<br>

## • Struct (Yapı)
```
Sturct class yapısına göre daha basit düzeyde işlemler gerçekleştirmemizi sağlayan ve belirli bir takım kısıtlamaları 
yanında barındırır.

Şimdi düşünün ki, bir yapı oluşturacaksınız ve bu yapı birbirleriyle ilişkili verileri barındıracaktır. 
Haliyle bunu bir class olarak belirleyebilir ve o classtan üretilen nesne üzerinde işlemlerimizi icra edebiliriz. 
Amma velakin bu yapımız class kadar kompleks işlemler için tasarlanmış bir yapı gerektirmiyorsa ve tutulacak verileri 
enkapsüle etmek yetiyorsa işte bu tarz durumlarda struct yapısını tercih edebiliriz.


Yapıların özellikleri:

•Class lar referans tipli özellikler gösterir, Yapılar ise değer tipli özellikler gösterirler. En temel fark budur.
•Diğer struct yada sınıflardan kalıtım almazlar.
•Interface'lerden kalıtım alabilirler.
•new anahtar sözcüğü ile nesneleri yaratılabilir.
•Sınıflar gibi metot, property ve field'lardan oluşurlar.
•Sınıf içerisinde struct, struct içerisinde de sınıf oluşturulabilir.
•Static üye barındırabilirler.
```
[Alıntı](https://www.gencayyildiz.com/blog/cta-struct-yapilari-ve-kullanim-durumlari/)


## • Inheritance (Kalıtım)

```
Bir sınıfın başka bir üst sınıftan miras almasına kalıtım denir. 
Miras veren sınıf tüm özelliklerini alt sınıfa aktarmış olur.
```

