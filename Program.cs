// See https://aka.ms/new-console-template for more information
using CommonLibrary;
using CommonLibrary.Practice;

Console.WriteLine("Hello, World!");

Class1 ob = new Class1();
ob.Demo();
Console.WriteLine("+++++++============Constructor++++++++++========================="); 

Constructor con1 = new Constructor(2);
con1.Parentmethod();
con1.CommonMethod();
Console.WriteLine(con1.Parentmethod);
Console.WriteLine(con1.CommonMethod);
Constructor con2   = new Constructor(12);