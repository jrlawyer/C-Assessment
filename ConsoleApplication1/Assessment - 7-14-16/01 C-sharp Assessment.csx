using System;

//Part One:  The Basics

1.Types

var i = 33;
var b = true;
var s = "Jennifer";
var d = 1.20f;
var dec = 1.2m;


//////2. Function

//First Attempt:

//var s = "Jennifer";
//var i = 33;

//string myAge(string, int);  //Function
//{
//    Console.WriteLine({s} + "is" + {i} +"years old.");  //print the string to the console; I keep getting an error about "declaring a body".
//}

//myAge();  //Call function


//Second attempt

//var s = "Jennifer";
//var i = 33;

//string myAge();  //function
//{
//    new System.Text.StringBuilder()
//        .Append(s)
//        .Append(" ")
//        .Append(i)
//        .Append(" " + "years old.")
//        .ToString();
//}

//myAge();  //Call function


//4. Array

var myArray = new[] { "James", "Judy", "Tony", "Steph", "Amond" }; //array

foreach (var name in myArray)  //loop
    Console.WriteLine(name);


//Part Two:

//public class Customer  //1.class
//    public Customer (string name, enum gender { unknown, male, female } string purchase)//1 and 2; properties and enum


