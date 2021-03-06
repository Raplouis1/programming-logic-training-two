// Programming logic training with C# - Flow control - for

//-----------------------------------------------------------------------

/* 1-The Fibonacci Sequence is the series of numbers: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34...
     The next number is found by adding up the two numbers before it.Ex.:The 2 is found by adding the two numbers before it (1+1)
     Knowing the informations above, write a program that calculates and shows the sequence to the 20th number.
*/

 int a = 0;
 int b = 1;
 int c; 

 for(int i = 0; i < 7; i++)//i++ = 0         i=1                     i=6   
 {                         //First loop      Second loop      Etc    Last loop
   Console.WriteLine(a);   //0               2                       2584
   Console.WriteLine(b);   //1               3                       4181
   c = a + b;              //c = 0 + 1 = 1   c = 2 + 3 = 5           .
   a = b + c;              //a = 1 + 1 = 2   a = 3 + 5 = 8           .
   b = a + c;              //b = 2 + 1 = 3   b = 8 + 5 = 13          .
   Console.WriteLine(c);   //1               5                       6765
 }
 //Console output: 0 1 1 2 3 5 8 13 21 34 55 89 144 233 377 610 987 1597 2584 4181 6765
 //Note: 0 isn't the first number in the sequence.It's the first number 1.
 //Note 2: i < 7 is because in each loop the results(a, b and c) are shown 3 times
 
//-----------------------------------------------------------------------

// 2-Make a program that reads a number and shows it's multiplication table from 1 to 10

 int number;
 int multiplicationResult;
 Console.WriteLine("Write any whole number: ");
 number = Convert.ToInt32(Console.ReadLine()); // Example: 5
 Console.WriteLine("Your number is: " + number); //Your number is: 5

 for (int i = 1; i < 11; i++)  
 {
   multiplicationResult = number * i; //multiplicationResult = 5 * 1
   Console.WriteLine(number + " times " + i + " is equal to: " + multiplicationResult);// 5 times 1 is equal to: 5
 }
/*
-Note: (i < 11) while one is less than 11, the loop continues.So, the loop will be made 10 times
-Note 2: Console output:
5 times 1 is equal to: 5
5 times 2 is equal to: 10
5 times 3 is equal to: 15
5 times 4 is equal to: 20
5 times 5 is equal to: 25
5 times 6 is equal to: 30
5 times 7 is equal to: 35
5 times 8 is equal to: 40
5 times 9 is equal to: 45
5 times 10 is equal to: 50
*/

//-----------------------------------------------------------------------

// 3-Write a program to read 10 numbers from keyboard and find their sum and average.

double number, sum = 0;
Console.WriteLine("Write 10 numbers.");
for(int i = 0; i < 10; i++)
{
 Console.WriteLine("Write any number:");
 number = Convert.ToDouble(Console.ReadLine()); //Example: 10 20 30 40 50 60 70 80 90 100
 sum += number; // 0 += 10 = 10 += 20 = 30 += 30 = 60 ... = 550 // 10 + 20 + 30 + 40 + 50 + 60 + 70 + 80 + 90 + 100 = 550
}     
average = sum / 10; // average = 550 / 10(ten numbers) = 55
Console.WriteLine("The sum of all numbers is: " + sum); //The sum of all number is: 550
Console.WriteLine("And the average is: " + average); //And the average is: 55

//-----------------------------------------------------------------------

//4-Write a program to calculate the factorial of a given number.Example: 5! = 5.4.3.2.1 = 120 / Note: fatorial of 0 = 1

 int n;
 int fatorial;
 
 Console.WriteLine("Write a whole number: ");
 n = Convert.ToInt32(Console.ReadLine()); //Example: n = 5
 fatorial = n; // 5 = 5 

 if(n == 0)
 {
    fatorial = 1;
 } 
 else
 {
   for (int i = 1; i < n; i++) // i = 1 / i = 2 / i = 3 / i = 4 
   {                    //5 - 1 = 4 ...                  
   fatorial = fatorial * (n - i); // fatorial =  5 * 4 = 20
                                  // fatorial = 20 * 3 = 60
                                  // fatorial = 60 * 2 = 120
                                  // fatorial =120 * 1 = 120
   }                              //Note: 5 * 4 (5-1) * 3(5-2) * 2(5-3) * 1(5-4)
 }           
 Console.WriteLine("The fatorial of your number is: " + fatorial); // The fatorial of your number is: 120      

//----------------------------------------------------------------------- 
