// https://www.youtube.com/watch?v=TJiLhRPgyq4
// What's new in C# 8 - Part 1
using System;
class Program
{
    static void Main(string[] args)
    {
        var miguel = new Person("Miguel", "Angulo");
        var length = GetMiddleNameLength(miguel);
        Console.WriteLine(length);
      }

    static int GetMiddleNameLength(Person person) // Person person
    {
        //var middle = person.MiddleName;
        //// if (middle == null) return 0; // to avoi the warning
        //if (middle is null) return 0; // this works if you overwriten the equality == operator
        //return middle.Length; //It is not null safe. if middle name = null you get an error

        // return person.MiddleName.Length; // we get a warning it myt be null

        // or
        //return person.MiddleName?.Length ?? 0; // this is correct by construction you read the variable once

        // if you think you know better
        // use bank ! - null ignoring operator
        // if (person.MiddleName is null) return 0;
        // return person.MiddleName!.Length; // I know better

        var middle = person.MiddleName;
        if (string.IsNullOrEmpty(middle)) return 0;
        return middle.Length;
    }

    //static int GetMiddleNameLength(Person? person)
    //{
    //    // 1
    //    // { } is it an Object or is it something 
    //    /*        if ((person?.MiddleName is { })) return person.MiddleName.Length;*/  // Alt + Enter or Ctrl + .
    //                                                                                   // 2
    //                                                                                   //if ((person?.MiddleName is { } middle)) return middle.Length;
    //                                                                                   // 3
    //                                                                                   //if ((person?.MiddleName is {Length: var length })) return length;
    //                                                                                   //return 0;
    //                                                                                   // and now only 1 line
    //    return ((person?.MiddleName is { Length: var length })) ? length : 0;
    //}
}