using System.ComponentModel;

namespace Assignmentadv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1 
            //Q1: What is a generic class? Why use generics?

            //Answer :  
            //A generic class is a class that can work with any data type.
            //It allows you to create a class that can be used with different types of data without having to write separate code for each type.
            //Generics provide type safety, code reusability, and improved performance by allowing you to define classes, methods,
            //and data structures that can operate on any data type while still maintaining type safety at compile time.

            #endregion

            #region Question 2 
            //Q2: Write a generic class Container<T> with Add and Get methods.

            //Answer :

            //Container<string> stringContainer = new Container<string>();

            //stringContainer.Add("Hello, World!");
            //Console.WriteLine(stringContainer.Get());

            //Container<int> intContainer = new Container<int>();
            //intContainer.Add(3);
            //Console.WriteLine(intContainer.Get());

            #endregion
        }
    }
}
