using System;
namespace DelegateExample
{
    class Program
    {
        public delegate void delmethod();
        public delegate void DisplayMessage(string mess);
        public static void display()
        {
            Console.WriteLine("Display");
        }

        public static void show(string message)
        {
            Console.WriteLine(message);
        }

        public void print()
        {
            Console.WriteLine("Print");
        }

        static void Main(string[] args)
            {
            // here we have assigned static method show() of class P to delegate delmethod()
                DisplayMessage del1 = show;

                // here we have assigned static method display() of class P to delegate delmethod() using new operator
                // you can use both ways to assign the delagate
                delmethod del2 = new delmethod(display);

                // here first we have create instance of class P and assigned the method print() to the delegate i.e. delegate with class    
                delmethod del3 = new delmethod(new Program().print);

                del1("Hello I am Shareef u din bhat");
                del2();
                del3();
                Console.ReadLine();
            }
        }
}
