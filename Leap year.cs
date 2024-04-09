int n1;
    {
        // Prompt the user to enter a year
        Console.Write("Enter a year: ");

        // Read the input from the user and convert it to an integer
        n1 = Convert.ToInt32(Console.ReadLine());

        // Check if the year is a leap year
        bool isLeapYear = (n1 % 4 == 0 && n1 % 100 != 0) || (n1 % 400 == 0);

        // Display the result
        if (isLeapYear)
        {
            Console.WriteLine($"{n1} is a leap year.");
        }
        else
        {
            Console.WriteLine($"{n1} is not a leap year.");
        }
    }

