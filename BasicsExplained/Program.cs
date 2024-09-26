namespace BasicsExplained
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name; //Declaration of a variable (creating a placeholder for a variable for later use) !IT NEEDS TO GET A VALUE ASSIGNED TO IT BEFORE USING)!!
            name = "Gigel"; //INITIALISATION of a variable (assigning a value to the variable)
            int myInt = 55; //DECLARATION + INITIALISATION AT THE SAME TIME
            int myInt2 = 62; //DECLARATION + INITIALISATION AT THE SAME TIME

            Console.WriteLine("Text"); //print something to the console
            Console.ReadLine(); //Take input from the user via the console
            name = Console.ReadLine(); //here the variable "name" is assigned the value of Console.ReadLine() after the user inputs something
            myInt = Convert.ToInt32(Console.ReadLine()); //Here we first take the user input, then convert it to an integer and then we assign the converted value to the variable "myInt"

            int result = myInt + myInt2; //here we declare the variable "result" of tipe int and then we add myInt to myInt2 and then we assign the value of those 2 added numbers to the variable "result"

        }
    }
}
}
