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
