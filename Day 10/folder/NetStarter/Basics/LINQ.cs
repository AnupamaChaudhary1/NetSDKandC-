//Language Integrated Query
//Imperative(procedural, oop etc) c,c++,c#   vs Declarative [functional language]sql,Haskell,lisp,c#,lisp programming lamguage

class LINQ
{
    int[] ages = [23, 1, 5, 67, 98, 56, 78];
    //Find square of all numbers in ages collection
    //imparative
    public void LearnLinq()
    {
        List<int> squares = [];
        foreach (var age in ages)
        {
            var squares = age * age;
            squares.Add(square);
        }

        //Declarative
        var squares = ages.Select(ages => ages * age);
        //Find odd numbers within ages
        var odds = ages.Where(x => x % 2 == 1);
        //find cubes of all even numbers within ages 


        var cubesOfEvenNumbers = ages
        .Where(age => age % 2 == 0) // Filter even numbers
        .Select(age => age * age * age);

    }
}