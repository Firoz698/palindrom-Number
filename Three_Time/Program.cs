//Palindrome Number in C# 
//a Palindrom number is a number that remains the same when its
//digits are reversed
Console.Write("Plase Enter Your Numebr : ");
int number = Convert.ToInt32( Console.ReadLine());

//int number = 121;
int rem;
int result = 0;
int temp = number;

while (number!=0)
{
    rem = number % 10;
    result = result * 10 + rem;
    number = number / 10;
}
if (temp == result)
{
    Console.WriteLine($" {temp} Palindrome Number");
}
else
{
    Console.WriteLine($" {temp} Is Not a Palindrom Number");
}













