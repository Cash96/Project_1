using System;
using System.Security.Cryptography;
using System.Linq;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // Output text
            // Console.WriteLine("Hello Carter  J Ash");
            // Console.WriteLine("Your wife is Madison E Ash");
            // Console.WriteLine("Your son is Carter J Ash II");

            // Output numbers
            // Console.WriteLine(3 + 3);

            // Write single strings with no new line
            // Console.Write("This is the first string");
            // Console.Write("This is the second string.");

            // Creating a variable
            // type...name...=...data...;
            // int age = 27;
            // Console.WriteLine(age);

            // Console.WriteLine($"You are {age} year old.");      // a bit of advanced string ops.

            // text variable
            // string name = "Carter";
            // Console.WriteLine("Your name is " + name);

            // Late assignment of a variable
            // int age;
            // Console.WriteLine("This is filler before the variable 'age' is assigned...");
            // age = 12;
            // Console.WriteLine($"You are {age} years old.");

            // Change the value of a variable
            // int BankBalance = 1000;
            // Console.WriteLine($"The bank balance is: {BankBalance}");
            // BankBalance = 1500;
            // Console.WriteLine($"The bank balance is: {BankBalance}");

            // Constant values of variables
            // const string SNN_str = "612-66-0988";
            // Console.WriteLine("Your SNN is: " + SNN_str);

            // Concatination
            // string f_name = "Carter";
            // string l_name = "Ash";
            // Console.WriteLine(f_name + " " + l_name);

            // Create mutiple variables
            // int a = 1, b = 2, c = 3, d = 4;
            // Console.WriteLine(a);
            // Console.WriteLine(b);
            // Console.WriteLine(c);
            // Console.WriteLine(d);

            // Examples of naming variables (for humans) correctly
            // int Seconds_in_Minutes = 60;        // good, clear example
            // int m = 60;                         // worksm but not advised.

            // small and big numbers
            // int num1 = 2;
            // long num2 = 20938475629832;
            // Console.WriteLine($"This is a small number (int): {num1}");
            // Console.WriteLine($"This is a large number (long): {num2}");

            // Boolean values (True and False)
            // bool yes = true;
            // bool no = false;

            // Console.WriteLine(yes);
            // Console.WriteLine(no);

            // single character values are called 'char'
            // char Grade = 'B';
            // Console.WriteLine(Grade);

            // Strings are collections of chars
            // string name = "Carter";
            // Console.WriteLine(name);

            // Casting is the process of converting one data-type into another

            //Implicit Casting (From a small to a big data type)
            // int age = 27;
            // double age_double = age;
            // Console.WriteLine($"This is your age: {age}");
            // Console.WriteLine($"This is your age (as a double): {age_double}");

            //Explicit Casting (From a large data-type to a small data-type)
            // double age = 27.825;
            // int age_int = (int) age;

            // Console.WriteLine($"age as double: {age}");
            // Console.WriteLine($"age as an int: {age_int}");

            // using the Convert method.
            // int myInt = 8;
            // string myStr = "5";
            // bool myBool = true;

            // Console.WriteLine(Convert.ToString(myInt));
            // Console.WriteLine(Convert.ToInt32(myStr));
            // Console.WriteLine(Convert.ToString(myBool));

            // Gather user input
            // Console.WriteLine("What is your name?");
            // string name = Console.ReadLine();
            // Console.WriteLine(name);

            /*
            When you want to make a string input, the computer is trying to let 
            you know that the user input might be null (no value). For this reason,
            the stirng data-type needs a '?' marker.
            */
            // Console.Write("What is your name?");
            // string? name = Console.ReadLine();
            // Console.WriteLine(name);


            // You cannot use Console.ReadLine() to input anything but a string so data-types must be casted.
            // Console.WriteLine("Input age: ");
            // string? myAge_string = Console.ReadLine();
            // Console.Write(Convert.ToInt32(myAge_string));

            // OPERATORS
            // Addition (+)

            // int a = 5, b = 5, c = a + b;
            // Console.WriteLine(c);

            // The Math library lets you... do math.
            // Console.WriteLine(Math.Min(5, 35));     // determine the smallest numebr
            // Console.WriteLine(Math.Sqrt(64));        // square root
            // Console.WriteLine(Math.Abs(-2.2));          // absolute (positive) vlaue
            // Console.WriteLine(Math.Round(4.987));   // round the number to a whole number
            // Console.WriteLine(Math.Round(4.587772, 2)); // rounds the number to '2' digits.

            // Tools for working with strings
            // string a_b_cs = "abcdefghijklmnopqrstuvwxyz";
            // Console.WriteLine($"The string '{a_b_cs}' is : {a_b_cs.Length} characters long.");      // determining length
            // Console.WriteLine($"Here is the string in UPPER-CASE: {a_b_cs.ToUpper()}");             // upper case
            // Console.WriteLine($"Here is the sting in lower-case: {a_b_cs.ToLower()}");


            // Accessing individual characters within a string by 'indexing' the string.
            // string f_name = "Carter";
            // string m_name = "James";
            // string l_name = "Ash";
            // Console.WriteLine($"{f_name}'s initals are {f_name[0]}.{m_name[0]}.{l_name[0]}.");

            // Find the specific index (number position) of a specific letter in a string
            // string f_name = "Carter";
            // Console.WriteLine($"'e' is in position {f_name.IndexOf("e")}.");

            // string full_name = "Cater Ash";
            // int start_of_last_name = full_name.IndexOf(" ");
            // string f_name = full_name.Substring(0, start_of_last_name);
            // string l_name = full_name.Substring(start_of_last_name+1);
            // Console.WriteLine(f_name);
            // Console.WriteLine(l_name);

            // Boolean data-type are t/f
            // Console.WriteLine(true);
            // Console.WriteLine(false);

            // Booleans are used to evaluate data to one another.
            // int x = 5;
            // int y = 25;
            // Console.WriteLine(x > y);

            // Booleans do not need to be variables
            // Console.WriteLine(5 > 25);

            // More boolean examples
            // int x = 15;
            // Console.WriteLine(x == 15);
            // Console.WriteLine($"The value 'x' is equal to 20: {x == 20}");

            // example of voting age
            // int age = 27;
            // int voting_age = 18;
            // Console.WriteLine($"The statement \"At the age {age}, you can vote\", is a {age >= voting_age} statement.");

            // You can grow the number of possible outputs using if-statements
            // int age = 2;
            // int voting_age = 18;

            // if(age >= voting_age){
            //     Console.WriteLine("You can vote!");
            // }
            // else{
            //     Console.WriteLine("You can NOT vote.");
            // }
            
            // The if-statement determines what path to take based on the first (or last) true statement found.
            // use 'x' for the next few examples
            // int x = 5;

            //ex 1
            // if(Convert.ToBoolean(x)){
            //     Console.WriteLine("'x' has non 0 value.");
            // }

            //ex 2
            // if(x > 20){
            //     Console.WriteLine("foo");
            // }
            // else{
            //     Console.WriteLine("bar");
            // }

            //ex 3
            // if(x > 20){
            //     Console.WriteLine("Foo");
            // }
            // else if(x == 5){
            //     Console.WriteLine("Bar");
            // }
            // else{
            //     Console.WriteLine("Foo-Bar");
            // }

            // There exists, a short-hand for if-statements.
            // Structure is
            // variable = (condition) ? expressionTrue : expressionFalse
            // int time = 22;
            // string time_of_day = (time >= 12) ? "EVENING" : "MORNING";
            // Console.WriteLine($"It is {time_of_day}.");

            // Another short-hand example
            // Console.WriteLine("Please enter your username: ");
            // string ? username = Console.ReadLine();
            // Console.WriteLine($"What is {username}'s password?");
            // string ? password = Console.ReadLine();
            // bool is_LoggedIn = username == "carter" && password == "12345";        // No need to explicitly write the t/f output.c
            // if(is_LoggedIn){
            //     Console.WriteLine($"Welcome {username}.... Logging in...");
            // }
            // else{
            //     Console.WriteLine("Something went wrong.... Please try again.");

            // Switch statements are like if-statements but evaluate some data once and then determine the execution flow path
            // int day = 4;
            // switch (day)
            // {
            //     case 1:
            //         Console.WriteLine("It is Monday");
            //         break;

            //     case 2:
            //         Console.WriteLine("It is Tuesday.");
            //         break;

            //     case 3:
            //         Console.WriteLine("It is Wednesday.");
            //         break;
                
            //     case 4:
            //         Console.WriteLine("It is Thursday.");
            //         break;
                
            //     case 5:
            //         Console.WriteLine("It is Friday.");
            //         break;

            //     case 6:
            //         Console.WriteLine("It is Saturday.");
            //         break;

            //     case 7:
            //         Console.WriteLine("It is Sunday.");
            //         break;
            // }

            /* Note, the switch statement only evaluates equals comparison. If I want the program to check more complex
            compasison operators such as >, <, >=, etc, the program will need to use an if-statement structure.*/

            // The 'default' keyword is used similarly to the 'else' keyword in if-statement structures.
            // int day = 12;
            // switch (day)
            // {
            //     case 1:
            //         Console.WriteLine("It is Monday");
            //         break;

            //     case 2:
            //         Console.WriteLine("It is Tuesday.");
            //         break;

            //     case 3:
            //         Console.WriteLine("It is Wednesday.");
            //         break;
                
            //     case 4:
            //         Console.WriteLine("It is Thursday.");
            //         break;
                
            //     case 5:
            //         Console.WriteLine("It is Friday.");
            //         break;

            //     case 6:
            //         Console.WriteLine("It is Saturday.");
            //         break;

            //     case 7:
            //         Console.WriteLine("It is Sunday.");
            //         break;

            //     default:
            //         Console.WriteLine("That... is... well... not a day..");
            //         break;
            // }

            // AUTOMATION
            // a while-loop structure will continue to execute the block of code below it asl long as (while) some condition is TRUE
            // int count = 0;
            // while(count < 10){
            //     if (count > 1){
            //         Console.WriteLine($"The loop has iterated {count} times.");
            //     }
            //     else{
            //         Console.WriteLine($"The loop has iterated {count} time.");
            //     }
            //     count++;    // ++ will increase the current value of an int variable by 1.
            // }
            // Console.WriteLine($"The loop has completed. The loop iterated {count} times.");

            // a do-while-loop structure has the code execute at least one time before the boolean expression has been evaluate. 
            // int count = 11;
            // do{
            //     if (count > 1){
            //         Console.WriteLine($"The loop has iterated {count} times.");
            //     }
            //     else{
            //         Console.WriteLine($"The loop has iterated {count} time.");
            //     }
            //     count++;    // ++ will increase the current value of an int variable by 1.
            // }
            // while(count < 10);
            // Console.WriteLine($"The loop has completed. The loop iterated {count} times.");

            /* Notice how the do-while-loop executed completely one time before the loop had a chance to notice that count was NEVER correct.*/

            /* a for-loop structure is similar to a while-loop structure in that fact that a set of code will try to execute some numebr of times.
            The main difference is that the for loop has all the control mechanisms of the sutomation built into the inital initialization structure.
            */
            // for(int iter = 0; iter < 10; iter++){
            //     Console.WriteLine($"The value of 'iter' is {iter}");
            // }

            // For-loops have a lot of flexability in the way they work or are setup (which is not exclusive to for-loops)
            // int sum = 0;
            // for(int iter = 20; iter >=1; iter--){
            //     Console.WriteLine($"The value of 'iter' is {iter}");
            //     sum += iter;
            // }
            // Console.WriteLine($"The sum of the first 20 digits is {sum}");

            // Nested for-loops allow for more complex iteration structures such as the ability to index multi layered (multi-demensional) arrays
            // for(int iter_1 = 0; iter_1 < 10; iter_1++){
            //     Console.WriteLine($"****The value of 'iter_1' is: {iter_1}");
            //     for(int iter_2 = 0; iter_2 < iter_1; iter_2++){
            //         Console.WriteLine($"The value of 'iter_2' is: {iter_2}");
            //     }
            // }

            // foreach-loops allow you not to iterate based on some counter variables (whether user defined int or for-loop based iterator)
            // string[] cars = {"FORD", "VOLVO", "VW", "NESSAN", "CHEVY"};
            // foreach(string car in cars){
            //     Console.WriteLine($"Some people like {car}s.");
            // }

            // 'break' keywords force the automation to exit its structure no matter the current state of the counter/iterator
            // for(int i = 0; i < 200; i++){
            //     if (i == 37){
            //         break;
            //     }
            //     Console.WriteLine($"'i' is {i}");
            // }

            // 'continue' keyword stop only one iteration.
            // for(int i = 0; i < 10; i++){
            //     if(i == 4){
            //         continue;
            //     }
            //     Console.WriteLine($"'i' is {i}");
            // }

            /*
            Note that the last example (the use of 'continue' keyword) should be done carefully becuase if the iterator does not get incremented 
            properly, the loop could go on forever. Take this while-loop for example.
            */
            // int count = 0;
            // while (count < 10){
            //     Console.WriteLine("In the loop.");
            //     if (count == 4){
            //         continue;
            //     }
            //     Console.WriteLine($"The value of 'count' is {count}");
            //     count++;
            // }  

            // STOP THE PROGRAM AFTER NOTICING THE VALUE OF COUNT DOES NOT GO PAST 3.

            // Arrays are collections of a single data-type (in basic usages).
            // string[] cars = {"FORD", "VOLVO", "VW", "NESSAN", "CHEVY"};
            // Console.WriteLine(cars[0]);     // first item
            // Console.WriteLine(cars[1]);     // second item
            // Console.WriteLine(cars[2]);     // third item 
            // Console.WriteLine(cars[3]);     // fourth item
            // Console.WriteLine(cars[4]);     // fith item
            // Console.WriteLine(cars[5]);     // ERROR: No sixth item!

            // To change a single value in a list (by position number) use the [] to 'index' the array
            // string[] cars = {"FORD", "VOLVO", "VW", "NESSAN", "CHEVY"};
            // foreach(string car in cars){
            //     Console.WriteLine(car);
            // }

            // cars[3] = "BMW";    // change in array value at position 3 (fourth item)
            // Console.WriteLine();

            // foreach(string car in cars){
            //     Console.WriteLine(car);
            // }

            // Using the foreach loop is nice, but you cannot change the value of the array item being iterated on. (See below)
            // string[] cars = {"FORD", "VOLVO", "VW", "NESSAN", "CHEVY"};
            // foreach(string car in cars){
            //     Console.WriteLine(car);
            //     car = "NOT A CAR";      // This is invalid assignemnt.. will cause ERROR
            // }

            // Using the '.Length' method, you can control a for-loop or while-loop to access and modify values.
            // string[] cars = {"FORD", "VOLVO", "VW", "NESSAN", "BMW"};
            // Console.WriteLine("INITIAL VALUE OF 'CARS' ARRAY:");
            // for(int car_index = 0; car_index < cars.Length; car_index++){
            //     Console.WriteLine($"The value of the 'cars' array at position {car_index} is: {cars[car_index]}");
            //     if (cars[car_index].Equals("BMW")){
            //         cars[car_index] = "PORCHE";    
            //     }
            // }
            // Console.WriteLine();
            // Console.WriteLine();
            // Console.WriteLine("VALUE OF 'CARS' ARRAY AFTER MODIFICATION:");
            // // Show the cars array with new update
            // foreach(string car in cars){
            //     Console.WriteLine(car);
            // }

            // Many programs take in data that is messy or unorganized. using the 'Arry.sort(YOUR_ARRAY)' method will take care of it for you.
            // int[] myNums = {1, 8, 8, 0, 23, 4000};
            // Console.WriteLine("***UNSORTED ARRAY***");
            // for(int num_index = 0; num_index < myNums.Length; num_index++){
            //     Console.WriteLine($"Position {num_index+1}: {myNums[num_index]}");
            // }

            // Array.Sort(myNums);     // sorts the array given to it
            // Console.WriteLine();    // For visual padding

            // Console.WriteLine("***SORTED ARRAY***");
            // for(int num_index = 0; num_index < myNums.Length; num_index++){
            //     Console.WriteLine($"Position {num_index+1}: {myNums[num_index]}");
            // }

            // The linq library gives you additional tools for woking with arrays (See top program)
            // int[] myints = {1, 54, 99, 22, 105, 2000};
            // Console.WriteLine($"The sum of 'myints array is: {myints.Sum()}");
            // Console.WriteLine($"The minimum value of 'myints' is: {myints.Min()}");
            // Console.WriteLine($"The max value of 'myints' is: {myints.Max()}");

            // Multidimensional arrays are arrays that store arrays
            // int[,] row_col ={{1, 2, 3}, {4, 5, 6}};
            // Console.WriteLine($"The first colum, second row is: {row_col[0, 1]}");

            // row_col[0, 0] = -1;
            // Console.WriteLine($"The first colum, second row is: {row_col[0, 0]}");

            // Using the for-each loop structure, you can easily bypass the required nested loop for most multidemensional arrays
            // int[,] tempList = {{1, 3, 5}, {2, 4, 6}};
            // foreach(int num in tempList){
            //     Console.WriteLine(num);
            // }

            // If you NEED to (which you might need to), you can use for-loops (nested) to access each array
            // int[,] tempList = {{1, 3, 5}, {2, 4, 6}};
            // for(int i = 0; i < tempList.GetLength(0); i++){
            //     for(int k = 0; k < tempList.GetLength(1); k++){
            //         Console.WriteLine(tempList[i, k]);
            //     }
            // }

            /*
            Methods or functions are organized blocks of code that can be 'called' by a program as many times as they want.
            Methods will be made in this program at the bottom of the main method (where the code is)
            Methods need a return-type (data-type) if any, a unique name, and the code.
            */

            // Example of a sinlge function which adds two numbers together and outputs the value
            // Console.WriteLine("Please input a single number: ");
            // String? num_1_string = Console.ReadLine();
            // int num_1 = Convert.ToInt32(num_1_string);
            // Console.WriteLine("Please input a nother number: ");
            // String? num_2_string = Console.ReadLine();
            // int num_2 = Convert.ToInt32(num_2_string);

            // MySum(num_1, num_2);


            
             
        }
        static void MySum(int a, int b)
        {
            Console.WriteLine(a + b);
        }
    }
}

