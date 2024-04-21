class Student
{
    public static string StudentType ="tech";
    public string name;
    public string address;
    public int roll;
    public DateTime dob;
    public void PrintDetails()
    {
        Console.WriteLine($"{name} {address} {roll} {dob}");
    }
    public static void PrintStudentType()
    {
        Console.WriteLine($"StudentType: { StudentType}");
    }
}
// using System.Runtime.CompilerServices;
// using System;
// class Student
// {
//     public static string studentType = "Tech";
//     public string name;
//     // public string Name{
//     //     get
//     //     {
//     //         return name;
//     //     }
//     //     set
//     //     {
//     //         if(value != "")
//     //         name = value;
//     //     }
//     // }
//     public string address;
//     public int roll;
//     public DateTime dob;
//     public void PrintDetails()
//     {
//         Console.WriteLine($"{name}  {address}  {roll}  {dob}");
//     }
//     public static void PrintStudentType()
//     {
//         Console.WriteLine($"Student Type: {studentType}");
//     }
// }
