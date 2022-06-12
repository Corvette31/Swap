using System;

namespace Swap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string lastName = "Иван";
            string firstName = "Иванов";
            string temp = lastName;
            lastName = firstName;
            firstName = temp;
            Console.WriteLine($"Имя : {firstName} , Фамилия : {lastName}");
        }
    }
}
