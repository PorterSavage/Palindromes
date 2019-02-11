using System;
public class Palindromes
{
    public static void Main()
    {
        Console.WriteLine("Enter A word of your choice and let's see if it's a palindrome:");
        string userWord = Console.ReadLine();
        char[] userArray = userWord.ToCharArray();
        Array.Reverse(userArray);
        string reverseArray = new string(userArray);
        if(userWord == reverseArray)
        {
            Console.WriteLine("It is A palindrome!");
        }
        else
        {
            Console.WriteLine("It is not A palindrome!");
        }
    }
}
