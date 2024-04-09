int n1;
    {
        // Prompt the user to enter a non-negative number
        Console.Write("Enter a non-negative number: ");

        // Read the input from the user and convert it to an integer
        n1 = Convert.ToInt32(Console.ReadLine());

        // Check if the number is non-negative
        if (n1 < 0)
        {
            Console.WriteLine("Error: Please enter a non-negative number.");
            return;
        }

        // Calculate the factorial of the number
        int factorial = 1;
        for (int i = 1; i <= n1; i++)
        {
            factorial *= i;
        }

        // Display the factorial
        Console.WriteLine($"The factorial of {n1} is: {factorial}");
    }

