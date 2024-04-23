// public class PeopleReport
// {
//     private List<Person> people;

//     public PeopleReport(List<Person> people)
//     {
//         this.people = people;
//     }

//     public void SaveMales(string filePath)
//     {
//         var males = people.Where(p => p.sex == Gender.Male);
//         SaveToFile(filePath, males);
//     }

//     public void SaveFemales(string filePath)
//     {
//         var females = people.Where(p => p.sex == Gender.Female);
//         SaveToFile(filePath, females);
//     }

//     public void SaveDotComUsers(string filePath)
//     {
//         var dotComUsers = people.Where(p => p.email.EndsWith(".com"));
//         SaveToFile(filePath, dotComUsers);
//     }

//     private void SaveToFile(string filePath, IEnumerable<Person> persons)
//     {
//         using (StreamWriter writer = new StreamWriter(filePath))
//         {
//             foreach (var person in persons)
//             {
//                 writer.WriteLine($"{person.index},{person.userId},{person.firstName},{person.lastName},{person.sex},{person.email},{person.phone},{person.dob},{person.jobTitle}");
//             }
//         }
//     }
// }

public class PeopleReport
{
    public void SaveMales(Person[] people, string filePath)
    {
        var males = people.Where(p => p.sex == Gender.Male).Select(p => $"{p.index},{p.userId},{p.firstName},{p.lastName},{p.sex},{p.email},{p.phone},{p.dob},{p.jobTitle}");
        SaveToFile(filePath, males.ToArray());
    }

    public void SaveAdultFemales(Person[] people, string filePath)
    {
        var adultFemales = people.Where(p => p.sex == Gender.Female && (DateTime.Now.Year - p.dob.Year) >= 20).Select(p => $"{p.index},{p.userId},{p.firstName},{p.lastName},{p.sex},{p.email},{p.phone},{p.dob},{p.jobTitle}");
        SaveToFile(filePath, adultFemales.ToArray());
    }

    public void SaveDotComUsers(Person[] people, string filePath)
    {
        var dotComUsers = people.Where(p => p.email.EndsWith("@example.com")).Select(p => $"{p.userId}, {p.index} {p.firstName}, {p.lastName}, {p.email}, {p.phone}");
        SaveToFile(filePath, dotComUsers.ToArray());
    }

    private void SaveToFile(string filePath, string[] lines)
    {
        File.AppendAllLines(filePath, lines);
    }
}