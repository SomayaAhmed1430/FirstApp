using System;

class Program
{
    static void Main(string[] args)
    {

        /* وصف التطبيق:
         * 1 - المستخدم يشوف قائمة من الخيارات:
         
        1: جمع رقمين.
        2: التحقق من زوجي/فردي.
        3: طباعة جدول الضرب.
        4: عكس نص.
        5: الخروج من البرنامج.
        
        * 2 - بعد اختيار خيار، ينفذ التطبيق العملية المناسبة.
        * 3 - يستمر البرنامج في عرض الخيارات حتى يختار المستخدم الخروج.
        */

        bool keepRunning = true;

        while (keepRunning)
        {

            // 1
            Console.WriteLine("1: Addition two numbers.");
            Console.WriteLine("2: Check even/odd number.");
            Console.WriteLine("3: Print multiplication table.");
            Console.WriteLine("4: Reverse text.");
            Console.WriteLine("5: Exit the program.");
            Console.WriteLine("Hello Hello, enter the number of the operation you want to perform : ");
            string input = Console.ReadLine();
            //int num = int.Parse(input);

            if (!int.TryParse(input, out int num))
            {
                Console.WriteLine("Invalid input! Please enter a valid number.");
                continue;
            }

            // 2
            switch (num)
            {
                case 1:
                    Console.WriteLine("You have chosen the program to Addition two numbers.");
                    Console.WriteLine("Please enter the first number : ");
                    string input1 = Console.ReadLine();
                    int num1 = int.Parse(input1);
                    Console.WriteLine("Second number : ");
                    string input2 = Console.ReadLine();
                    int num2 = int.Parse(input2);

                    int sum = num1 + num2;
                    Console.WriteLine($"The result is : {num1} + {num2} = {sum}");
                    break;
                case 2:
                    Console.WriteLine("You chose the program to verify the number even or odd");
                    Console.WriteLine("Please enter your number");
                    string input3 = Console.ReadLine();
                    int num3 = int.Parse(input3);

                    if (num3 % 2 == 0)
                    {
                        Console.WriteLine("Your number is an `even` number");
                    }
                    else
                    {
                        Console.WriteLine("Your number is an `odd` number");
                    }
                    break;
                case 3:
                    Console.WriteLine("You have chosen the multiplication table program.");
                    Console.WriteLine("Please enter your number");
                    string input4 = Console.ReadLine();
                    int num4 = int.Parse(input4);

                    Console.WriteLine($"The {num4} multiplication table is : ");
                    for (int i = 0; i <= 10; i++)
                    {
                        int multi = i * num4;
                        Console.WriteLine($"{num4} X {i} = {multi}");
                    }
                    break;
                case 4:
                    Console.WriteLine("You have chosen the text reverser program.");
                    Console.WriteLine("Now please enter your text.");
                    string input5 = Console.ReadLine();

                    var reverse = "";
                    for (int t = input5.Length - 1; t >= 0; t--)
                    {
                        reverse += input5[t];
                    }
                    Console.WriteLine($"Reversed string: {reverse}");
                    break;
                case 5:
                    // إنهاء البرنامج
                    Console.WriteLine("Goodbye!");
                    keepRunning = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice! Please enter a number from 1 to 5.");
                    break;
            }



            Console.WriteLine("-------------------------------------");
            Console.WriteLine("If you want to continue and try another program ??  (Press Enter)");
            Console.ReadKey();
        }
    }
}