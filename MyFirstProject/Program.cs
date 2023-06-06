using System;

//Unit 5 (06Jun2023)
// Unit 5-1: The program asks a name of the user, then writes "Hello, *name*!!!" to console.
Console.WriteLine("Enter your name.");
string name = Console.ReadLine();
Console.WriteLine("Hello, " + name + "!");
//Unit 5-2: An user enters their First name, Last name and Paternal name. The program writes the full name to the console.
Console.WriteLine("Enter your first name.");
string firstName = Console.ReadLine();
Console.WriteLine("Enter your last name.");
string lastName = Console.ReadLine();
Console.WriteLine("Enter your paternal name.");
string paternalName = Console.ReadLine();
string fullName = lastName + " " + firstName + " " + paternalName;
Console.WriteLine(fullName);


//Unit 6 (06Jun2023)
//Write the code to do the following:
//Unit 6-1: User enters 2 integers (A and B). Writo to console A multiplied by B; and the remainder of B divided by A.
Console.WriteLine("Unit 6-1: \nEnter an integer А.");
string input = Console.ReadLine();
int a = Convert.ToInt32(input);
Console.WriteLine("Enter an integer B.");
input = Console.ReadLine();
int b = Convert.ToInt32(input);
int multiplicationProduct = a * b;
Console.WriteLine("A multiplied by B gives: " + multiplicationProduct);
int divisionRemainder = b % a;
Console.WriteLine("B divided by A gives the remainder: " + divisionRemainder);
////Unit 6-2: User enters 2 integers: (A and B). Change A to B and B to A using the third int variable. 
Console.WriteLine("\nUnit 6-2: \nEnter an integer А.");
string input62 = Console.ReadLine();
int a62 = Convert.ToInt32(input62);
Console.WriteLine("Enter an integer B.");
input62 = Console.ReadLine();
int b62 = Convert.ToInt32(input62);
int temp62 = a62;
a62 = b62;
b62 = temp62;
Console.WriteLine("Now A equals to " + a62 + " and B equals to " + b62 + ".");
//Unit 6-3: User enters 3 integers (A, B and С). Write to console the result (X) of the equation : A*X+B=C.
Console.WriteLine("\nUnit 6-3: \nEnter an integer А.");
string input63 = Console.ReadLine();
double a63 = Convert.ToDouble(input63);
Console.WriteLine("Enter an integer B.");
input63 = Console.ReadLine();
int b63 = Convert.ToInt32(input63);
Console.WriteLine("Enter an integer C.");
input63 = Console.ReadLine();
int c63 = Convert.ToInt32(input63);
if ((a63 == 0) & (b63 == c63))
{
    Console.WriteLine("If A*X+B=C , then X may be any number.");
} else if ((a63 == 0) & (b63 != c63)) {
    Console.WriteLine("If A*X+B=C , then there are no solutions for X.");
} else
{
    double x63 = (c63 - b63) / a63;
    Console.WriteLine("If A*X+B=C , then X equals to " + x63 + ".");
}












