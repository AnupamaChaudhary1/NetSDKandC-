class csvParser{
    List<Persons> people =[];
    public void Parse(){
        string filePath=@"D:\NetSDKandC-\Assignment1\PeopleManagement\data\People.csv";
        var lines= File.ReadAllLines(filePath);
        foreach(var line in lines.skip(1)){
            var parts=line.split("," StringSplitOptions.RemoveEmptyEntries);
            var person=new Person{
                index=int.Parse[parts[0]],
                userId=parts[1],
                firstName=parts[2],
                lastname=parts[3],
                sex=enum.Parse<Gender>(parts[4]),
                email=parts[5],
                phone=parts[6],
                dob=DateTime.Parse(parts[7]),
                jobTitle=parts[8]
            };
            csvParser.Add(person);
        }
    }
    public void PrintNames(){
        foreach
    }
}