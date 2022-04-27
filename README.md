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

<br>

## • Enum
```
Bazen uygulama geliştirirken sabit değerlerle çalışmak durumunda kalabiliriz. 
Enumlar bir grup sabiti temsil eden özel sınıftır.

Sayısal verilerı string ifadelerle saklamanızı sağlar. 

Enumlar default olarak sıfırdan başlar.
```
```cs
enum Months
{
  January,    // 0
  February,   // 1
  March,      // 2
  April,      // 3
  May,        // 4
  June,       // 5
  July        // 6
}

static void Main(string[] args)
{
  int myNum = (int) Months.April;
  Console.WriteLine(myNum); // çıktı olarak 3 degerini döndürür.
}
```
***

## • Inheritance (Kalıtım)

```
Bir sınıfın başka bir üst sınıftan miras almasına kalıtım denir. 
Miras veren sınıf tüm özelliklerini alt sınıfa aktarmış olur.

  • Derived Class (child) - Türetilmiş sınıf, başka bir sınıftan miras alan.
  • Base Class (parent) - Temel sınıf, miras alınan sınıf.
  
Miras alma işlemi miras alacak oaln sınıf adının yanına : sembolü ile miras alınacak sınıf adının 
yazılması ile yapılmaktadır.
```
```cs
class Vehicle  // base class (parent) - Temel sınıf 
{
  public string brand = "Ford";  //  field
  public void honk()             //  method 
  {                    
    Console.WriteLine("Tuut, tuut!");
  }
}

class Car : Vehicle  // derived class (child) - Vehicle sınıfından miras almış
{
  public string modelName = "Mustang";  // Car field
}

class Program
{
  static void Main(string[] args)
  {
    // Create a myCar object
    Car myCar = new Car();

    // Call the honk() method (From the Vehicle class) on the myCar object
    myCar.honk();

    // Display the value of the brand field (from the Vehicle class) and the value of the modelName from the Car class
    Console.WriteLine(myCar.brand + " " + myCar.modelName);
  }
}
```
<br>

## • Polymorphism  (Çok Biçimlilik)
```
Miras veren sınıf içerisindeki metotları, miras alan sınıf içinde tekrardan tanımlayıp yeni
özellikler eklemeye çok biçimlilik denir. Bunu yapabilmemiz için ilk önce ana sınıf içindeki
metot tanımlamasında virtual anahtar kelimesi kullanılır daha sonra bu metotu türetilmiş 
sınıf içinde override anahtar kelimesi ile tekrar tanımlarız. Bu şekilde ana sınıftaki 
metotu türetilmiş sınıf içerisinde tanımlayarak yeni özellikler ekleyebiliriz bu şekilde metotu 
ezmiş oluyoruz.

Eğer oluşturulan sınıfın başka bir sınıf tarafından kalıtım olarak alınmasını istemiyorsanız 
class tanımlamasının önüne "sealed" kelimesini yazarak bu durumu engellemiş olursunuz.
```

```cs
sealed class Vehicle 
{
  ...
}

class Car : Vehicle // Bu tanımlama hata verir.
{
  ...
}
```

```cs
class Animal  // Base class (parent) - Temel Sınıf
{
  public virtual void animalSound() 
  {
    Console.WriteLine("The animal makes a sound");
  }
}

class Dog : Animal  // Derived class (child) - Türetilmiş sınıf
{
  public override void animalSound() 
  {
    Console.WriteLine("The dog says: bow wow");
  }
}

class Program 
{
  static void Main(string[] args) 
  {
    Animal myAnimal = new Animal();  // Create a Animal object
    Animal myDog = new Dog();  // Create a Dog object

    myAnimal.animalSound(); // Çıktı : The animal makes a sound"
    myDog.animalSound(); // Çıktı: The dog says: bow wow
  }
}
```

<br>

## • Interface (Arayüzler)

```
Sınıfların içermesi gereken metotların imzaları yer alır sadece, bu yüzdende Interface 
içerisindeki property'lere bir değer ataması yapılmaz, metotların ise gövdesi yazılmaz.
Sadece implemente eden sınıfın ne iş yaptığının bir arayüzüdür interface'ler. Ve bir 
sınıf aynı anda birden fazla arayüzden kalıtım alabilir.
Interface isimleri "I" ile başlar. 

```
```cs

public interface IAnimal // Interface
{
  void animalSound(); // interface method (does not have a body)
}


class Pig : IAnimal // Pig "implements" the IAnimal interface
{
  public void animalSound() 
  {
    // The body of animalSound() is provided here
    Console.WriteLine("The pig says: wee wee");
  }
}

class Program 
{
  static void Main(string[] args) 
  {
    Pig myPig = new Pig();  // Create a Pig object
    myPig.animalSound();
  }
}
```

<br>

## • Abstract Class (Soyut)

```
Veri soyutlama, belirli ayrıntıları gizleme ve kullanıcıya yalnızca gerekli bilgileri gösterme işlemidir.
Abstract metotlar yalnızca soyut bir sınıfta kullanılabilir ve gövdesi yoktur. Gövde türetilmiş sınıf tarafından sağlanır.

Kısaca abstract sınıfların özelliklerine bakacak olursak:

• Normal sınıflar gibi new() anahtar kelimesi ile türetilemezler.
• Interface ler gibi metot bildirimi yapabilirsiniz.
• Sanal metotları override eder gibi abstract metotlar override edilebilir.
• Abstract metotların gövdesi yazılamaz.
• Bir abstract class bir abstract metot içeriyorsa, abstract sınıftan türeyen tüm sınıflar bu metodu override etmek zorundadır.
• Bir sınıf sadece tek abstract sınıftan kalıtım alabilir.
• Abstract sınıf başka bir abstract sınıftan kalıtım alabilir. Dolaylı olacak türeyen sınıfta birden fazla abstract
dan kalıtım almış olur. Ve bağlantılı olduğu tüm abstract sınıfların bildirimi yapılmış olan abstract metotlarını 
override etmek zorundadır.

Abstract metotdan türetilmiş sınıf içerisinde abstract metodun kullanılabilmesi için de override anahtar kelimesinin kullanılması gerekir.
```
```cs

abstract class Animal // Abstract class
{

  public abstract void animalSound();   // Abstract method

  public void sleep()
  {
    Console.WriteLine("Zzz");
  }
}


class Pig : Animal
{
  public override void animalSound() //Abstract metot override edilmiş.
  {
    Console.WriteLine("The pig says: wee wee");
  }
}

class Program
{
  static void Main(string[] args)
  {
    Pig myPig = new Pig(); // Create a Pig object
    myPig.animalSound();  // Call the abstract method
    myPig.sleep();  // Call the regular method
  }
}

```

***

Patika C# 101 eğitiminin linki. [C# 101](https://app.patika.dev/courses/csharp-101)

Bilgilerinizi pekiştirmek için bu platformdaki eğitimlere bakabilirsiniz. [W3 Schools OOP](https://www.w3schools.com/cs/cs_oop.php)
<br>
***
### 🔗 Connect with me 
Konu anlatımında yaptığım hatalar var ise lütfen benimle iletişime geçin :) 
<p align="left">
  <a href="mailto:sumeyyecoskun.sc@gmail.com" target="blank"><img align="center" src="https://img.icons8.com/color/48/000000/gmail-new.png" alt="4214976" height="40" width="40" /></a>
  <a href="https://www.linkedin.com/in/sümeyyecoşkun/" target="blank"><img align="center" src="https://raw.githubusercontent.com/rahuldkjain/github-profile-readme-generator/master/src/images/icons/Social/linked-in-alt.svg" alt="gautamkrishnar" height="30" width="40"  /></a>
