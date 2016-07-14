using System;

//Part One:  The Basics

1.Types

var i = 33;  //int
var b = true;  //boolean
var s = "Jennifer";  //string
var d = 1.20f;  //double
var dec = 1.2m;  //decimal


//2. Function

void myAge(string s, int i)  //Function
{
    //var s = "Jennifer";
    //var i = 33;

    Console.WriteLine(s + " " + "is" + " " + i + " " + "years old.");  //3. print the string to the console
}

myAge();  //Call function


//4. Array

var myArray = new[] { "James", "Judy", "Tony", "Steph", "Amond" }; //array

foreach (var name in myArray)  //loop
    Console.WriteLine(name);


//Part Two:
//In progress

//public class Customer //1.class
//{
//    public Customer(string name, Gender gender, string purchase) //2. constructor
//    {

//        Name = name;
//        Gender = gender;
//        Purchase = purchase;
//    }
//    public string Name  //1. property
//    {
//        get;
//        set;
//    }

//    public enum Gender //enum {unknown, male, female,} //1. property
//    {
//        get;
//        set;
//        //0 = "Unkown";
//        //1 = "Male";
//        //2 = "Female";
//    }

//    public string Purchase  //1. property
//    {
//        Console.WriteLine($("Hello", {Name} "thank you for purchasing our product. We hope you enjoy it!"));  
//        get;
//        set;
//    }
//}

//sealed class InactiveCustomer  //5. Subclass of Inactive Customer
//    : Customer
//{
//    sealed int MonthsInactive
//    {
//        get;
//        set;
//    }
//}


