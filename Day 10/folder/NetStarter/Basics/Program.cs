// See https://aka.ms/new-console-template for more information


// Console.WriteLine("Hello, World!");
// Student s1= new();
// Student s2= new();
// Student s3= new();
// Student s4= new();
// s1.name="Aaa";
// s1.address="bbb";
// s1.roll=1;
// s1.dob=new DateTime(2000,3,5);
// Console.WriteLine(s1.name+ " " +s1.address +" "+  s1.roll+" "+ s1.dob);
// class Student{
// public string name;
// public string address;
// public int roll;
// public DateTime dob;
// }
// Student.PrintStudentType();
// // Wait for user input before closing the console window
// Console.ReadLine();

// Animal n1=new Animal();
// Animal n2=new Animal();
// n1.name="Elephant";
// n1.bodycolor="grey";
// n1.scientificname="Elephas maximus";
// n1.weight=1500;
// n1.limbs=4;
// n1.PrintDetails();
// n2.name="Dog";
// n2.bodycolor="brown";
// n2.scientificname="Canis lupus familiaris";
// n2.weight=10;
// n2.limbs=4;
// n2.PrintDetails();

// var rec1=new Rectiangle(5.3,5.2);
// var p=rec1.GetPerimeter();
// var rec2=new Rectiangle(121.22,34.2);
// var a=rec2.GetArea();
// Console.WriteLine("Rectangle 1 - Perimeter: " + p );
// Console.WriteLine("Rectangle 2 - Area: " + a);


// var square1=new Square(25.2);
// var sa=square1.GetArea();
// var sp=square1.GetPerimeter();
// Console.WriteLine("Square1 - Perimeter: " + sp);
// Console.WriteLine("Square1 - Area: " + sa);


// Circle c1 = new Circle(15.2);
// double perimeter = c1.GetPerimeter();
// double area = c1.GetArea();
// Console.WriteLine("Circle- Perimeter: " + perimeter);
// Console.WriteLine("Circle - Area: " + area);

// var sphere1=new Sphere(32.2);
// var ssa=sphere1.GetArea();
// sphere1.PrintSphereInfo();

// var fileio=new FileIO();
// global::System.Object value = fileio.CreateFile();

// var fileio = new FileIO();
// fileio.CreateFileWithinFolder();
// Console.WriteLine("new folder is created here.");

// string filePath = @"D:\NetSDKandC-\Day 10\folder\NetStarter\Basics\Peoplemanagement\People.csv";

// CSVParser csvParser = new CSVParser();
// csvParser.Parse(filePath);
// csvParser.PrintNames();



// namespace MyNamespace
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             // Instantiate the Generics class and call the Test method
//             Generics generics = new Generics();
//             generics.Test();

//             // Wait for user input before closing the console window
//             Console.ReadLine();
//         }
//     }
// }

//list and declerations
// int[] ages=[23,1,5,67,98,56,78];
// //Find square of all numbers in ages collection
// //imparative
// List<int> squares=[];
// foreach(var age in ages)
// {
//     var squares=age*age;
//     squares.Add(square);
// }

// //Declarative
// var squares=ages.Select(ages=> ages*age);

//linq
// LINQ linq = new LINQ();
// linq.LearnLinq();

ParallelAsync parallelAsync = new();
parallelAsync.ProcessNumbers();

// await parallelAsync.IgniteStove();
// await parallelAsync.GrindMasala();
// await parallelAsync.PutkeatleyOnWithWater();
// await parallelAsync.IgniteStove();

