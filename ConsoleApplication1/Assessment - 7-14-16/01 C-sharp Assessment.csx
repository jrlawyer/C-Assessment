using System;

////Part One:  The Basics

////1.Types

//var i = 33;  //int
//var b = true;  //boolean
//var s = "Jennifer";  //string
//var d = 1.20f;  //double
//var dec = 1.2m;  //decimal


////2. Function

//string myAge(string s, int i)  //function
//{
//    var age = $"{s} is {i} years old.";  //string interpolation
//    return age;
//}

//var test = myAge("Jennifer", 33);
//Console.WriteLine(test);  //print to Console
//// or as an alternative means of printing to Console...
//Console.WriteLine(myAge("Jennifer", 33));

////4. Array

//var myArray = new[] { "James", "Judy", "Tony", "Steph", "Amond" }; //array

//foreach (var name in myArray)  //loop
//    Console.WriteLine(name);


//Part Two:
//In progress


public enum Gender { unknown, male, female }; //1. enum

public class Customer //1.class
{
    public Customer(string name, Gender gender, string product) //2. constructor
    {
        Name = name;
        Gender = gender;
        Product = product;
    }
    public string Name  //1. property
    { get; set; }

    public Gender Gender //1. property
    { get; set; }

    public string Product //1. property
    { get; set; }

    public override string ToString()
    {
        return $"{Name} {Gender} {Product}";
    }

    public void Thanks()  //3. write a method
    {
        Console.WriteLine($"Hello {Name}; thanks for purchasing our {Product}!");
    }

    public void SendSalesNotice(DateTime SaleDate) //4. write a method with date parameter
    {
        Console.WriteLine($"Hello {Name}! We will be having a sale on {SaleDate:d}.");
    }

    public void SendSalesNotice(string item, DateTime SaleDate)//4. write a method with string and date parameters
    {
        Console.WriteLine($"Hello {Name}! We will be having a sale on {item} on {SaleDate:d}.");
    }
}

var c = new Customer("Jennifer", Gender.female, "yoga mats");  //8. New instance of class
Console.WriteLine(c); //8. print to console 

c.Thanks();  //3. Calling method on var c; 8. test method

c.SendSalesNotice(new DateTime (2016, 9, 5)); //4. calling method

c.SendSalesNotice("yoga pants", new DateTime(2016, 9, 5));  //4. calling method








sealed class InactiveCustomer  //5. Subclass of Inactive Customer
    : Customer
{
    public InactiveCustomer(int monthsInactive, string name, Gender gender, string product) 
        : base(name, gender, product) //6. Create a constructor
    {
        MonthsInactive = monthsInactive;
    }

    public int MonthsInactive  //5. Property of MonthsInactive
    { get;set;}

    public override string ToString()
    {
        return $"{MonthsInactive} {Name} {Gender} {Product}";
    }

    public void Notification()
    {
        if (MonthsInactive > 4)
        {
            Console.WriteLine($"We appreciate your business, {Name}!  We saw you purchased {Product} from us {MonthsInactive} ago. If you're intereted in our current deals, let us know.");
        } 
    }
}


var j = new InactiveCustomer(5, "James", Gender.male, "golf clubs");
j.Notification
