class Palindromes
{
    static void Main(string[] args)
    {
        // declaring variable
        int number;
        int digit1, digit2, digit4, digit5;

        // enter five digit number
        Console.Write("Enter Five Digit Number:  ");
        number = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();    // just for spacing purpose  

        // check if the number is not a five digit number
        if (number < 10000 || number > 99999)
        {
            Console.WriteLine("Error - Entered Number Is Not A Five Digit Number");

            return;
        }

        // seperating digits of number
        digit5 = number % 10;
        digit4 = (number / 10) % 10;
        digit2 = (number / 1000) % 10;
        digit1 = number / 10000;

        // if the digit1 is equal to digit5 and digit2 is equal to digit4
        if (digit1 == digit5 && digit2 == digit4)
        {
            // than it is a palindrome number
            Console.WriteLine("{0} Is A Palindrome Number", number);
        }

        else
        {
            // if it is not than it is not a palindrome number
            Console.WriteLine("{0} Is Not A Palindrome Number", number);
        }
        
    }
}
