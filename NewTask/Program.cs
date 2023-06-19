


//MultiplicationTable();


//void MultiplicationTable()
//{

////1)Multiplication Table


//    for (int x = 1; x <= 10; x++)
//    {
//        for (int j = 1; j <= 10; j++)
//        {
//            Console.Write(x * j + " ");
//        }
//        Console.WriteLine();
//    }




//2)Write a method that checks if given number (positive integer) contains digit 3. Do not convert number to othe type

////Console.WriteLine(CheckNumber(Convert.ToInt32(Console.ReadLine())));
////bool CheckNumber(int num)

////{
////    while (num > 0)
////    {
////        if (num % 10 == 3)
////        {
////            return true;
////        }
////        num /= 10;
////    }
////    return false;
////}    


////Console.ReadLine();

//3)Write a method that should check no is palidrome(Reverse) or not.

//Palidrome(Convert.ToInt32(Console.ReadLine()));
//bool Palidrome(int num)
//{
//    int rev=0, sum = 0;
//    int number = num;
//    Console.Write("Enter the number: ");
//    num = Convert.ToInt32(Console.ReadLine());

//    while (num > 0)
//    {
//        rev = num % 10;
//        sum = (sum * 10) + rev;
//        num = num / 10;
//    }
//    Console.WriteLine(sum);
//    if (sum == number)
//    {
//        return true;
//    }
//    else
//    {
//        return false;
//    }
//}

////Console.ReadLine();
//4) Write a method that should represent fibinacci series
//Fibonacci(Convert.ToInt32(Console.ReadLine()));
//void Fibonacci(int num)
//{
//    int a = 0, b = 1, sum = 0;

//    Console.Write("{0} {1}", a, b);
//    for (int i = 2; i < num; i++)
//    {
//        sum = a + b;
//        Console.Write(" {0}", sum);
//        a = b;
//        b = sum;
//    }
//}
//5)Given two dates - first from the past and second as present date, write a method that returns numbers of days between
//these two dates.

//DifferenceofTwoDates();
//void DifferenceofTwoDates()
//{
//    DateTime date1 = Convert.ToDateTime(Console.ReadLine());
//    DateTime date2 = Convert.ToDateTime(Console.ReadLine());

//    TimeSpan diffofDates = date1 - date2;

//    Console.WriteLine(diffofDates.Days);


//}

//7)write a method that swaps them using temporary variable and without temp variable.                                                         Write a C# program to find the eligibility of admission for a professional course based on the following criteria: 

//Marks in Maths >=65,Marks in Phy >=55,Marks in Chem>=50, Total in all three subject >=180 or 
// Total in Math and Subjects >=140

using System.Transactions;

Details();
void Details()
{
    int M, P, C;
    Console.WriteLine("Enter Marks of Maths");
    M=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter Marks Of Physics");
    P=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter Marks of Chemistry");
    C=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(M +P+C);

    if (M+P+C >=180)
    {
        Console.WriteLine(" Eligible for Admission"); 
    }


     else 
    {


        Console.WriteLine("Not Eligible for Vote");
    }
}
    



   





























