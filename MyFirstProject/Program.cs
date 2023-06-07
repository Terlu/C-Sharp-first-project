using System;

//Unit 8-2. User enters 2 integers A and B. Write to console a difference: max (A,B) - min (A,B). 
Console.WriteLine("Unit 8-2 \nEnter an integer A.");
string input82 = Console.ReadLine();
int a82 = Convert.ToInt32(input82);
Console.WriteLine("Enter an integer B.");
input82 = Console.ReadLine();
int b82 = Convert.ToInt32(input82);
int c82 = Math.Max(a82, b82) - Math.Min(a82, b82);
Console.WriteLine("Difference: max (A,B) - min (A,B) equals: "+c82+"\n");

//Unit 8-3. User enters 2 integers A and B and C. Write them to console in ascending order.
//Unit 8-4. User enters 2 integers A and B and C.  Write to console the answer (for X) of the equation:AX^2+BX+C=0.

//Unit 5 (06Jun2023)
// Unit 5-1: The program asks a name of the user, then writes "Hello, *name*!!!" to console.
Console.WriteLine("Unit 5-1: \nEnter your name.");
string name = Console.ReadLine();
Console.WriteLine("Hello, " + name + "!");
//Unit 5-2: An user enters their First name, Last name and Paternal name. The program writes the full name to the console.
Console.WriteLine("Unit 5-2: \nEnter your first name.");
string firstName = Console.ReadLine();
Console.WriteLine("Enter your last name.");
string lastName = Console.ReadLine();
Console.WriteLine("Enter your paternal name.");
string paternalName = Console.ReadLine();
string fullName = lastName + " " + firstName + " " + paternalName;
Console.WriteLine(fullName + "\n");


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

//Unit 7 (06Jun2023) - Conditionals 
//Unit 7-1. User enters their password. Check if it equals to "QWERTY123".
Console.WriteLine("Unit 7-1\nEnter your password.");
string password = Console.ReadLine();
if (password == "QWERTY123")
{
    Console.WriteLine("Password is correct.");
}
else
{
    Console.WriteLine("Password is not correct.\n");
}
//Unit 7-2. User enters 2 integers (A and B). If A is more than B, count A+B, if A equals B, count A*B, if A is less B, count A-B.
Console.WriteLine("Unit 7-2: \nEnter an integer А.");
string input72 = Console.ReadLine();
int a72 = Convert.ToInt32(input72);
Console.WriteLine("Enter an integer B.");
input72 = Console.ReadLine();
int b72 = Convert.ToInt32(input72);
if (a72 < b72)
{
    int sum = a72 + b72;
    Console.WriteLine("Since A < B, the sum is: A+B = " + sum + "\n");
}
else if (a72 == b72)
{
    int product = a72 * b72;
    Console.WriteLine("Since A = B, the product is: A*B = " + product + "\n");
}
else
{
    int difference = a72 - b72;
    Console.WriteLine("Since A > B, the difference is: A-B = " + difference + "\n");
}
//Unit 7-3. User enters an integer. If it is even, write "Even" to console.
Console.WriteLine("Unit 7-3: \nEnter an integer.");
string input73 = Console.ReadLine();
int a73 = Convert.ToInt32(input73);
if (a73 % 2 == 0)
{
    Console.WriteLine("Even\n");
}

//Unit 8 (07Jun2023) - Conditionals part2
//Unit 8-1.  User enters an integer. If it is even, write "Even" to console. Else, write "Odd" to console. 
Console.WriteLine("Unit 8-1: \nEnter an integer.");
string input81 = Console.ReadLine();
int a81 = Convert.ToInt32(input81);
if (a81 % 2 == 0)
{
    Console.WriteLine("Even\n");
}
else
{
    Console.WriteLine("Odd\n");
}


