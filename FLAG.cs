string text1 = "N*E*P*A*L";
string text2 = "M*Y*L*O*V*E";
int i, j;
for (i = 0; i < text1.Length; i++)
{
    for (j = 0; j <= i; j++)
    {
    Console.Write(text1[j]+" ");
    }
    Console.WriteLine();
}
for (i = 0; i < text2.Length; i++)
{
    for (j = 0; j <= i; j++)
    {
        Console.Write(text2[j] + " ");
    }
    Console.WriteLine();
}