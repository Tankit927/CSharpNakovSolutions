﻿// A company dealing with marketing wants to keep a data record of its 
// employees. Each record should have the following characteristic – first 
// name, last name, age, gender (‘m’ or ‘f’) and unique employee number 
// (27560000 to 27569999). Declare appropriate variables needed to 
// maintain the information for an employee by using the appropriate data 
// types and attribute names.

class Record
{
    static void Main()
    {
        string firstName = "your";
        string lastName = "Friend";
        byte age = 24;
        char gender = 'm';
        uint uniqueEmployeeNumber = 27560000;

        Console.WriteLine($"Name = {firstName}{lastName}\n" +
        $"Age = {age}\n" +
        $"Gender = {gender}\n" +
        $"Unique Employee Number = {uniqueEmployeeNumber}");
    }
}