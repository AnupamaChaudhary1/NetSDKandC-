// See https://aka.ms/new-console-template for more information
// CsvParser.parser = new  CsVParser();
// parser.Parse();
// parser.PrintNames();
// Import the namespace where CsVParser is defined


// class Program
// {
//     static void Main(string[] args)
//     {
//         // Assuming CsVParser is a class and parser is an object of that class
//         CsvParser parser = new CsvParser(); // Instantiate CsVParser object
//         parser.Parse(); // Call the Parse() method
//         parser.PrintNames(); // Call the PrintNames() method
//     }
// }


CsvParser parser = new CsvParser();
List<Person> people = parser.Parse();

// Create instance of PeopleReport
PeopleReport report = new PeopleReport();

// Generate and save reports
report.SaveMales(people.ToArray(), "males.csv");
report.SaveAdultFemales(people.ToArray(), "adultfemales.csv");
report.SaveDotComUsers(people.ToArray(), "dotcomusers.csv");
