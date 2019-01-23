using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// if you copy and paste this text into your Visual Studio instance,
// you will have to change the name of this namespace to your first initial,
// last name, and assignment name in order for this to work properly

namespace nlove_inclass01
{
    class Program
    {
        static void Main(string[] args)
        {
            // create two int variables
           
            int my_age = 30;
            int profs_age = 40;

            // create two string variables
           
            string my_name = "Natasha";
            string profs_name = "Greg";

            // create a three-part conditional statement
            
            if (my_age>profs_age)
            {
                Console.WriteLine("I'm older than prof M.");
            }

            else if (my_age<profs_age)
            {
                Console.WriteLine("I'm younger than prof M.");
            }

            else
            {
                Console.WriteLine("I and prof M. are the same age.");
            }

             Console.WriteLine();

            // Ask the user how many times your name should be displayed
            Console.WriteLine("How many times should I display your name?");

            // Parse or convert this input into an integer (do not worry
            // about invalid input checking at this time) and assign it to
            // a new integer variable
            // Syntax for this step:
            // datatype variableName = datatype.Parse(string input);
            // datatype variableName = Convert.ToInt32(string input);
            // Remember your "string input" will likely be Console.ReadLine()

            int times = Int32.Parse(Console.ReadLine()); // Parse only works with strings (no floating or double )
            // int times = Convert.ToInt32(Console.ReadLine()); // Convert can work with flooating and double

            // create a loop that will run that many times and display
            // your name that many times.
            // 3 Syntax possibilities:
            // FOR : for(initialization clause; termination (comparison) clause; alteration clause)
            //WHILE :  initialization clause; while(termination clause) { alteration clause; }
            //DO.. WHILE: initialization clause; do { alteration clause; } while(termination clause);
            for (int i = 0; i < times; i++)
            {
                Console.WriteLine(my_name);
            }

            Console.WriteLine();

            // create a string  array of names that is at least four elements long
            // assign the two variable names and at least two other names as elements
            // in the array
            // Syntax: datatype[] arrayName = new dataType[size] { string, string, ... };

            string[] names = new string[4] {my_name, profs_name, "Richi", "Glenna" };

            // use the foreach loop to loop through the names and display them
            // Syntax: foreach (datatype variableName in arrayName) { /* statements */ }

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine();

            // display the third name in the array, remembering that counting starts at
            // zero.
            // Syntax: Console.WriteLine(arrayName[index]);
            Console.WriteLine(names[2]);

            Console.WriteLine();

            // Write the three methods first.
            // Call each of the methods. The two "void" methods will not return any
            // values, so just calling them will suffice.
            // The first method accepts no parameters.
            // The second method accepts one string parameter. Use the variable for your name
            // For the third method, you will have to dispaly the returned string. Use
            // Prof. M.'s name for this method call.
            display_text();
            display_text(my_name);
            Console.WriteLine(return_text(profs_name));

            Console.WriteLine();

            Console.WriteLine("Press any key to exit. . .");
            Console.ReadKey();
        }

        // create a void method that will display some basic text. This method should
        // not have any parameters that it accepts
        // Syntax: accessModifier [static|virtual|override] returnType method_name([param_list]) { }
        public static void display_text()
        {
            Console.WriteLine("This is text.");
        }

        // create a void method named the same as the above method (this will create
        // an overlaoded method) that accepts a string parameter. This method will
        // display the argument that is passed into it
        public static void display_text(string name)
        {
            Console.WriteLine("The name is {0}.", name);
        }

        // create a method that returns a string and has a string as a parameter.
        // The method will return a formatted string.
        // String.Format Syntax: String.Format(string format [, string variable ...]);
        // remember you can use {index} as a placeholder. For each placeholder, there
        // needs to be a string variable to display.

        public static string return_text(string name)
        {
            return String.Format("The returned name is {0}.", name);
        }

    }
}
