int p1, I1, t1, simple;
    {
        // Prompt the user to enter the principal amount
        Console.Write("Enter the principal amount: ");
        p1 = Convert.ToInt32(Console.ReadLine());

        // Prompt the user to enter the interest rate
        Console.Write("Enter the interest rate (in percentage): ");
        I1 = Convert.ToInt32(Console.ReadLine());

        // Prompt the user to enter the time period
        Console.Write("Enter the time period (in years): ");
        t1 = Convert.ToInt32(Console.ReadLine());

        // Calculate the simple interest
        simple  = (p1 * I1 * t1) / 100;

        // Display the simple interest
        Console.WriteLine($"Simple Interest: {simple}");
    }

