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


## • Inheritance (Kalıtım)

```
Bir sınıfın başka bir üst sınıftan miras almasına kalıtım denir. 
Miras veren sınıf tüm özelliklerini alt sınıfa aktarmış olur.
```

