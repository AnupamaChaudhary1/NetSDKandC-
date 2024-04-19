//Language Integrated Query
//Imperative(procedural, oop etc) c,c++,c#   vs Declarative [functional language]sql,Haskell,lisp,c#,lisp programming lamguage

class LINQ
{
    int[] ages = [23, 1, 5, 67, 98, 56, 78];
    //Find square of all numbers in ages collection
    //imparative
    List<Student> students = [
        new Student() { name = "Ram", address = "Ktm"},
        new Student() { name = "Laxman", address = "Dang"},
        new Student() { name = "Bikendra", address = "Ktm"},
        new Student() { name = "Sandip", address = "Dang"},
        new Student() { name = "Chahana", address = "Dhangadhi"},
    ];
    public void LearnLinq()
    {
        List<int> squares = [];
        foreach (var age in ages)
        {
            var squares = age * age;
            squares.Add(square);
        }

        //Declarative
        var squares = ages.Select(ages => ages * ages); // method syntax
        var squaresAlternate = from agr in ages //expression
                               selectage* ages;
        //Find odd numbers within ages
        var odds = ages.Where(x => x % 2 == 1);
        //find cubes of all even numbers within ages 
        var cubesOfEvenNumbers = ages
        .Where(ages => ages % 2 == 0) // Filter even numbers
        .Select(ages => ages * ages * ages);

        //find students who live in dang and sort the result by names

        var inDang = students
        .Where(students => students.address == "Dang")
        .OrderBy(students => students.Name);

    }
}