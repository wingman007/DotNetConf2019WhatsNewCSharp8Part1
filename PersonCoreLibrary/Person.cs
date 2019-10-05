// #nullable disable warnings
// #nullable disable annotations
// #nullable disable
public class Person
{
    public string FirstName { get; set; }
    public string? MiddleName { get; set; } // you have to make it nullable explicitly in C# 8.0
    public string FamilyName { get; set; }

    // if in the project file of this lib we have     <LangVersion>8.0</LangVersion> <Nullable>enable</Nullable> we get warning middleName is not assigned
    public Person(string firstName, string familyName)
    {
        FirstName = firstName;
        // we can solve the warnig like this
        MiddleName = null; // but we get the warning Cannot convert null to non-nullable reference type. Strings are not null by default anymore. You have to make string nullable
        FamilyName = familyName;
    }

#nullable disable
    public Person(string firstName, string middleName, string familyName)
    {
        FirstName = firstName;
        MiddleName = middleName;
        FamilyName = familyName;
    }
}
