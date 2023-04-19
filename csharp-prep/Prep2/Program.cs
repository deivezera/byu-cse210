using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What's your grade percentage? ");
        string gradeString = Console.ReadLine();
        int grade = int.Parse(gradeString);

        if (grade >= 90)
        {
            Console.WriteLine(" Grade: " + "A");
        } 
        else if(grade >= 80)
        {
            Console.WriteLine(" Grade: " + "B");
        } 
        else if (grade >= 70)
        {
            Console.WriteLine(" Grade: " + "C");
        } 
        else if (grade >= 60)
        {
            Console.WriteLine(" Grade: " + "D");
        }
        else
        {
            Console.WriteLine(" Grade: " + "F");
        }
    }
}