// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to my grade calculator ");

int i=1;
while (i<11)
{
    Console.WriteLine("Enter the  number of student "+i+":");
    double number=Convert.ToDouble(Console.ReadLine());
    if (number>=80 && number<100 )
    {
        Console.WriteLine("Number"+ i + "get A+");
    }
    else if (number>=70 && number<80)
    {
        Console.WriteLine("Number"+ i + "get A");
    }
    else if (number>=50 && number<700)
    {
        Console.WriteLine("Number"+ i + "get A-");
    }
    else if (number>=33 && number<50)
    {
        Console.WriteLine("Number"+ i + "get D");
    }
    else 
    {
        Console.WriteLine("Number"+ i + "get F");
    }
    i++;

}
Console.WriteLine("Thank you ");
