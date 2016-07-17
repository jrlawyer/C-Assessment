using System;

////Part One:  The Basics

//1.Types

var i = 33;  // Int.
var b = true;  // Boolean.
var s = "Jennifer";  // String.
var d = 1.20f;  // Double.
var dec = 1.2m;  // Decimal.


//2. Function

string MyAge(string s, int i)  // Function.
{
    var age = ($"{s} is {i} years old.");  // String interpolation.
    return age;
}

var test = MyAge("Jennifer", 33);
Console.WriteLine(test);  // 3. Print to Console.
// or as an alternative means of printing to Console...
//Console.WriteLine(myAge("Jennifer", 33));

//4. Array

var MyArray = new[] { "James", "Judy", "Tony", "Steph", "Amond" };

foreach (var name in MyArray)  //loop
    Console.WriteLine(name);


//Part Two:


public enum Gender { Unknown, Male, Female }; // 1. Create an enum.

public class Customer // 1. Create a class.
{
    public Customer(string name, Gender gender, string product) // 2. Create a constructor.
    {
        Name = name;
        Gender = gender;
        Product = product;
    }
    public string Name  // 1. Create a property.
    { get; set; }

    public Gender Gender // 1. Create a property.
    { get; set; }

    public string Product //1. Create a property.
    { get; set; }

    //public override string ToString()  // Redundant due to PrintCustomerInfo.
    //{
    //    return $"{Name} {Gender} {Product}";
    //}

    public virtual void PrintCustomerInfo() // 9. Add an overridable, "virtual," method.
    {
        Console.WriteLine($"{Name} - {Product} - {Gender}");
    }

    public void Thanks()  // 3. Write a "thanks" method.
    {
        Console.WriteLine($"Hello {Name}! Thank you for purchasing our {Product}; we appreciate your business!");
    }

    public void SendSalesNotice(DateTime SaleDate) // 4. Write a method with date parameter.
    {
        Console.WriteLine($"Hello {Name}! We will be having a sale on {SaleDate:d}.");
    }

    public void SendSalesNotice(string item, DateTime SaleDate)// 4. Write an overloaded method with string and date parameters.
    {
        Console.WriteLine($"Hello {Name}! We will be having a sale on {item} on {SaleDate:d}.");
    }
}

var c = new Customer("Jennifer", Gender.Female, "yoga mats");  // 8. New instance of class.
//Console.WriteLine(c); // 8. Printing to console. Redundant due to PrintCustomerInfo.

c.Thanks();  // 3. Calling the method on var c; 8. Testing method.

c.SendSalesNotice(new DateTime (2016, 9, 5)); // 4. Calling the method.

c.SendSalesNotice("yoga pants", new DateTime(2016, 9, 5));  // 4. Calling the method.

c.PrintCustomerInfo();  // 9. Calling the method.
 



public enum NotPurchasing { Irate, Moved, Uninterested };  // 10. Add an enum.

sealed class InactiveCustomer  // 5. Subclass of Inactive Customer.
    : Customer
{
    public InactiveCustomer(int monthsInactive, string name, Gender gender, string product, NotPurchasing notpurchasing) 
        : base(name, gender, product) // 6. Create a constructor, 11. Added property to constructor.
    {
        MonthsInactive = monthsInactive;
        NotPurchasing = notpurchasing;
    }

    public int MonthsInactive  // 5. Property of MonthsInactive.
    { get;set;}

    public NotPurchasing NotPurchasing  // 11. Property of NotPurchasing.
    { get; set; }

    //public override string ToString() // Redundant due to PrintCustomerInfo.
    //{
    //    return $"{MonthsInactive} {Name} {Gender} {Product} {Reason}";
    //}

    public override void PrintCustomerInfo() // 12. Add a method that overrides PrintCustomerInfo.
    {
        Console.WriteLine($"{Name} - {Product} - {Gender} - {MonthsInactive} - {NotPurchasing}");
    } 

    public void Notification()  // 7. Create a method.
    {
        if (MonthsInactive > 4)
        {
            Console.WriteLine($"We appreciate your business, {Name}!  We saw you purchased {Product} from us {MonthsInactive} months ago. If you're intereted in our current deals, let us know.");
        } 
    }
}

// 8. New instance of class.
var j = new InactiveCustomer(5, "James", Gender.Male, "golf clubs", NotPurchasing.Uninterested);
j.Notification();  //7. Calling method.
j.PrintCustomerInfo();  //9. Calling method.

// New Instance of class.
var s = new InactiveCustomer(7, "Steph", Gender.Female, "exercise ball", NotPurchasing.Irate);


// Testing Inheritance.
j.SendSalesNotice(new DateTime(2016, 9, 5));
j.SendSalesNotice("golf bags", new DateTime(2016, 9, 5));
j.Thanks();

// Testing overridden method.
c.PrintCustomerInfo();
j.PrintCustomerInfo();


