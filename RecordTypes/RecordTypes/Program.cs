// See https://aka.ms/new-console-template for more information
using RecordTypes;

Console.WriteLine("Example of record in C#");

var person1 = new Person { FirstName = "Michael", LastName = "V" };
var person2 = new Person { FirstName = "Michael", LastName = "V" };

bool areEqual = person1 == person2; // true

Console.WriteLine($"Are person1 and person2 equal? {areEqual}");

Console.WriteLine("Deconstruction example");

var employee = new Employee("Jane","Smith");
var (firstName, lastName) = employee;

Console.WriteLine($"First Name: {firstName}, Last Name: {lastName}");

Console.WriteLine("With expression example");

var employee2 = employee with { FirstName = "John" };

Console.WriteLine($"First Name: {employee2.FirstName}, Last Name: {employee2.LastName}");

Console.Read();
