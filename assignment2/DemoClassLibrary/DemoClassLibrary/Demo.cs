/**
 * In visual studio, Create Classlibrary project. Declare a class Demo in it. In Demo class write member function called message that prints "I am great" on the terminal. Compile the project. Now add console application  project in the same solution/workspace and in the console application use the Demo class reference and create its instance and call the function message.
 * Learning You will learn about how to write class, how to print on console, how create class library, how to create console application, how reference project.https://www.youtube.com/watch?v=pe1_zs1FEi0
 */
namespace DemoClassLibrary
{
    public class Demo
    {
        public void Message()
        {
            Console.WriteLine("I am great");
        }
    }
}