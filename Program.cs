using System;
using System.Security.Cryptography.X509Certificates;

public class Student
{
    private decimal marks;
    public int Id { get; set; }
    public string Name { get; set; }

    public decimal Marks
    {
        get { return marks; }
        set { marks = value; }
    }
    public Student()
    {
        Id = 10;
        Name = "RAM";
        Marks = 70;
    }
    public Student(int id, string name, decimal marks)
    {
        this.Id = id;
        this.Name = name;
        this.Marks = marks;
    }


    public bool IsPass()
    {
        return Marks >= 35;
    }

    public override string ToString()
    {
        return $"Student [Id={Id}, Name={Name}, Marks={Marks}, Result={(IsPass() ? "PASS" : "FAIL")}]";
    }
}

public class Watch
{
    public string Brand { get; set; }
    public int Price { get; set; }

    public Watch()
    {
        Brand = "Sony";
        Price = 110;
    }

    public Watch(string brand, int price)
    {
        this.Brand = brand;
        this.Price = price;
    }

    public override string ToString()
    {
        return $"Watch [Brand={Brand}, Price={Price}]";
    }
}


public class Mobile
{
    public string Brand { get; set; }
    public int Price { get; set; }
    public int Storage { get; set; }

    public Mobile()
    {
        Brand = "Motorola";
        Price = 250;
        Storage = 256;
    }

    public Mobile(string brand, int price, int storage)
    {
        this.Brand = brand;
        this.Price = price;
        this.Storage = storage;
    }

    public override string ToString()
    {
        return $"Mobile [Brand={Brand}, Price={Price}, Storage={Storage}GB]";
    }
}

public class Account
{
    public string Name { get; set; }
    private decimal balance;
    private string AccNo { get; set; }

    public decimal Balance
    {
        get { return balance; }
        set { balance = value; }
    }

    public Account()
    {
        this.Balance = 10;
        this.Name = "Alex";
        this.AccNo = "123";
    }

    public Account(string name, decimal balance, string accNo)
    {
        this.Name = name;
        this.Balance = balance;
        this.AccNo = accNo;
    }

    public override string ToString()
    {
        return $"Account [Name = {Name}, Balance = {Balance}, accNo = {AccNo}]";
    }

}

public class Bike
{
    public string Name { get; set; }
    public int Price { get; set; }
    public int ModelYear { get; set; }

    public Bike()
    {
        this.Name = "Honda Shine";
        this.Price = 80000;
        this.ModelYear = 2016;
    }

    public Bike(string name, int price, int modelYear)
    {
        this.Name = name;
        this.Price = price;
        this.ModelYear = modelYear;
    }

    public override string ToString()
    {
       return $" Bike [Name:{Name} ,Price:{Price} ,ModelYear :{ModelYear}]";
    }
}

public class Laptop
{
    public int LaptopId { get; set; }
    public string LaptopBrand { get; set; }
    public string  Processor { get; set; }
    public int Storage { get; set; }

    public Laptop()
    {
        this.LaptopId = 12323;
        this.LaptopBrand = "Lenova";
        this.Processor = "Ryzen";
        this.Storage = 128;
    }

    public Laptop(int laptopId, string laptopBrand, string processor, int storage)
    {
        this.LaptopId = laptopId;
        this.LaptopBrand = laptopBrand;
        this.Processor = processor;
        this.Storage = storage;
    }

    public override string ToString()
    {
        return $"Laptop [LaptopId:{LaptopId} , LaptopBrand:{LaptopBrand}, Processor:{Processor} , Storage:{Storage}]";
    }
}

public class Country
{
    public string CountryName { get; set; }
    public int CountryCode { get; set; }
    public string Region {  get; set; }
    public string Population {  get; set; }

    public Country()
    {
        this.CountryName = "India";
        this.CountryCode = 124;
        this.Region = "Asia";
        this.Population = "1.4 Million";
    }

    public Country(string CountryName, int CountryCode,string Region, string Population)
    {
        this.CountryName = CountryName;
        this.CountryCode = CountryCode; 
        this.Region = Region;
        this.Population = Population;
    }

    public override string ToString()
    {
        return $"Country[CountryName:{CountryName},CountryCode:{CountryCode},CountryRegion:{Region},CountryPopulation:{Population}]";
    }
}

public class Company
{
    public string CompanyName { get; set; }

    public int CompanyCode { get; set; }

    public string Type { get; set; }
    public string HeadQuarter{  get; set; }

    public Company()
    {
        CompanyName = "Tata Consultancy Services";
        CompanyCode = 53434;
        Type = "MNC";
        HeadQuarter = "India";
    }

    public Company(string name, int code, string type, string location)
    {
        this.CompanyName = name;
        this.CompanyCode = code;
        this.Type = type;
        this.HeadQuarter = location;
    }

    public override string ToString()
    {
        return $"Company[CompanyName :{CompanyName},CompanyCode:{CompanyCode},Type:{Type},HeadQuarter:{HeadQuarter}]";
    }
}

public class Movie
{
    public string MovieName { get; set; }
    public int ReleaseYear { get; set; }
    public string Genre { get; set; }
    public string Duration { get; set; }
    public string Director { get; set; }

    public Movie()
    {
        MovieName = "3 Idiots";
        ReleaseYear = 2012;
        Genre = "Comedy";
        Duration = "3 Hours";
        Director = "Rajkumar Hirani";
    }

    public Movie(string name,int releasedate,string genre,string duration,string director)
    {
        this.MovieName = name;
        this.ReleaseYear = releasedate; 
        this.Genre = genre;
        this.Duration = duration;
        this.Director = director; 
    }

    public override string ToString()
    {
        return $"Movie[MovieName:{MovieName},ReleaseYear:{ReleaseYear},Genre:{Genre},Duration:{Duration},Director:{Director}]";
    }

}

public class Book
{
    public string BookName { get; set; }
    public string BookGenre { get; set; }
    public int PublicationYear { get; set; }
    public string Language { get; set; }

    public Book()
    {
        BookName = "XYZ";
        BookGenre = "Timepass";
        PublicationYear = 199;
        Language = "English";
    }

    public Book(string bookName, string bookGenre, int publicationYear, string language)
    {
        BookName = bookName;
        BookGenre = bookGenre;
        PublicationYear = publicationYear;
        Language = language;
    }

    public override string ToString()
    {
        return $"Book[BookName:{BookName},BookGenre:{BookGenre},PublicationYear:{PublicationYear},Language:{Language}]";
    }
}


public class Program
{
    public static void Main(string[] args)
    {
        Student s1 = new Student();
        Student s2 = new Student(101, "Yogesh", 78);

        Watch w1 = new Watch();
        Watch w2 = new Watch("Titan", 5000);

        Mobile m1 = new Mobile();
        Mobile m2 = new Mobile("Samsung", 20000, 128);

        Account A1 = new Account();
        Account A2 = new Account("John",500,"256");

        Bike b1 = new Bike();
        Bike b2 = new Bike("Honda Unicorn",90000,2017);

        Laptop L = new Laptop();
        Laptop L1 =new Laptop(5675,"Asus","Dell",256);

        Country C=new Country();
        Country C1=new Country("USA",127,"North America","1.3 billion");
        
        Company Com = new Company();
        Company Com1 = new Company("Microsof", 684, "MNC", "USA");

        Movie M = new Movie();
        Movie M1 = new Movie("Student of the Year",2016,"Student Life","3hour","Karan Johar");

        Book B=new Book();
        Book B1=new Book("ABC","Cartoon",2010,"Hindi");

        Console.WriteLine(s1);
        Console.WriteLine(s2);
        Console.WriteLine("------------------------------------------------------------------------");

        Console.WriteLine(w1);
        Console.WriteLine(w2);
        Console.WriteLine("------------------------------------------------------------------------");

        Console.WriteLine(m1);
        Console.WriteLine(m2);
        Console.WriteLine("------------------------------------------------------------------------");

        Console.WriteLine(A1);
        Console.WriteLine(A2);
        Console.WriteLine("-------------------------------------------------------------------------------");

        Console.WriteLine(b1);
        Console.WriteLine(b2);
        Console.WriteLine("---------------------------------------------------------------------------------------------------");

        Console.WriteLine(L);
        Console.WriteLine(L1);
        Console.WriteLine("------------------------------------------------------------------------------------------------------");

        Console.WriteLine(C);
        Console.WriteLine(C1);
        Console.WriteLine("--------------------------------------------------------------------------------------------------------");

        Console.WriteLine(Com);
        Console.WriteLine(Com1);
        Console.WriteLine("---------------------------------------------------------------------------------------------------------");

        Console.WriteLine(M);
        Console.WriteLine(M1);
        Console.WriteLine("---------------------------------------------------------------------------------------------------------");

        Console.WriteLine(B);
        Console.WriteLine(B1);

    }
}
