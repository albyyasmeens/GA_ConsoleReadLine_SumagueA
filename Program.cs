using System;

partial class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your userName?");
        string firstName = Console.ReadLine();
        Console.WriteLine(firstName);

        Console.WriteLine("Hello, " + firstName);
        Console.WriteLine("What is your favorite color?");
        string favoriteColor = Console.ReadLine();
        Console.WriteLine(favoriteColor);
        Console.WriteLine("Ah, " + favoriteColor + ", is a great color!");
        Console.WriteLine(firstName + " who likes " + favoriteColor + " welcome to the program!");

        Console.WriteLine("What school do you go to?");
        string schoolName = Console.ReadLine();
        Console.WriteLine(schoolName);
        Console.WriteLine("What do you hope to learn in this class?");
        string hopeToLearn = Console.ReadLine();
        Console.WriteLine(hopeToLearn);
    }
}
