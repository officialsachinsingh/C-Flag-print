int num, dup, rem, sum = 0;
Console.WriteLine("enter the number to check:");
num =   Convert.ToInt32(Console.ReadLine());
dup = num;
while (num != 0)
{
    rem = num % 10;
    sum = sum + rem * rem * rem;
    num = num / 10;

}
if (sum == dup)
    Console.WriteLine($"The number{dup}is arm");
else
    Console.WriteLine($"The number{dup}is not arm");