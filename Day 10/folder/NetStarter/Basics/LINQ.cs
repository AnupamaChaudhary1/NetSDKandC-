// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Security.AccessControl;
// class LINQ
// {
//     int[] ages = [12, 45, 78, 89, 78];

//     List<Student> students = new List<Student>
//     {
//         new Student() { Name = "Laxman", Address = "Dang"},
//         new Student() { Name = "Bikendra", Address = "Ktm"},
//         new Student() { Name = "Sandip", Address = "Dang"},
//         new Student() { Name = "Chahana", Address = "Dhangadhi"}
//     };

//     public void LearnLinq()
//     {
//         // Imperative
//         List<int> squares = new List<int>();
//         foreach (var age in ages)
//         {
//             squares.Add(age * age);
//         }

//         // Declarative using method syntax
//         var squaresMethod = ages.Select(x => x * x);

//         // Declarative using query syntax
//         var squaresQuery = from age in ages
//                            select age * age;

//         // Find odd numbers within ages
//         var odds = ages.Where(x => x % 2 == 1);

//         // Find cubes of all even numbers within ages 
//         var cubesOfEvenNumbers = ages
//             .Where(x => x % 2 == 0) // Filter even numbers
//             .Select(x => x * x * x);

//         // Find students who live in "Dang" and sort the result by names
//         var inDang = students
//             .Where(student => student.Address == "Dang")
//             .OrderBy(student => student.Name);

//         // Output
//         foreach (var square in squares)
//         {
//             Console.WriteLine(square);
//         }
//     }
// }

// // class Student
// // {
// //     public string Name { get; set; }
// //     public string Address { get; set; }
// // }
//language Integrated query

//Imperative [Procedural , oop etc] (C, C++, C#) 
//Declarative
using System.Security.AccessControl;
 

class LINQ
{
    int[] ages = [12, 45, 78, 89, 78];
     List<Student> students = [
        new Student() { name = "Ram", address = "Ktm"},
        new Student() { name = "Laxman", address = "Dang"},
        new Student() { name = "Bikendra", address = "Ktm"},
        new Student() { name = "Sandip", address = "Dang"},
        new Student() { name = "Chahana", address = "Dhangadhi"},
    ];
// find squares of all numbers in ages collection.
public void LearnLinq()
    {
        List<int> squares = [];
        foreach (var age in ages)
        {
            var square = age * age;
            squares.Add(square);
        }
        //declarative
        // var squares = ages.Select(age => age *age);
        //  var squaresAlternate = from age in ages select age * age;

        //find odd numbers within ages
        // var odds = ages.Where(x => x % 2 == 1);

        //find cube of all even numbers within ages collection.
        // var cubesofEvenNumber = ages.Where(age => age % 2 == 0) .Select(age => age * age * age);

       // find student who lives in dang and sort the result by names.
       
       var Dang = students.Where(students => students.address == "Dang") .OrderBy(students => students.name);

    }


}