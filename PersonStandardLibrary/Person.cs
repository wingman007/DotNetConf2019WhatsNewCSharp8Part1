public class Person
{
    public string FirstName { get; set; }
    public string MiddleName { get; set; }
    public string FamilyName { get; set; }


    //// Severity	Code	Description	Project	File	Line	Suppression State
    //Warning CS8618  Non-nullable property 'MiddleName' is uninitialized.Consider declaring the property as nullable.PersonStandardLibrary C:\Users\User\source\repos\DotNetConf2019C8Part1\PersonStandardLibrary\Person.cs	7	Active
    public Person(string firstName, string familyName)
    {
        FirstName = firstName;
        FamilyName = familyName;
    }
    public Person(string firstName, string middleName, string familyName)
    {
        FirstName = firstName;
        MiddleName = middleName;
        FamilyName = familyName;
    }
}
