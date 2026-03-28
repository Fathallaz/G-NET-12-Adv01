using Microsoft.VisualBasic;
using System.ComponentModel;
using System.Data;
using System.Reflection.Metadata;

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

            #region Question 3
            //Q3: What are multiple type parameters? Write Pair<TKey, TValue>.

            //Answer : multiple type parameters allow you to define a generic class or method that can work with more than one type.
            //Pair<string, int> pair = new Pair<string, int>();
            //pair.Add("Age", 30);
            //Console.WriteLine($"Key: {pair.GetKey()}, Value: {pair.GetValue()}");



            #endregion

            #region Question 4 
            //Q4: What is a generic method? Write Swap<T> method.

            //Answer : A generic method is a method that can work with any data type.

            //int a = 5, b = 10;
            //Utility.Swap(ref a, ref b);
            //Console.WriteLine(a);
            //Console.WriteLine(b);

            #endregion

            #region Question 5 
            //Q5: Write a generic method FindMax < T > that finds maximum value
            // int[ ] Numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //Utility1.PrintArray(Numbers);
            //Console.WriteLine(Utility1.FindMax(Numbers)); 
            #endregion

            #region Question 6 
            //Q6: What is a generic interface? Write IRepository<T>.

            //Answer : A generic interface is an interface that can work with any data type.

            //IRepository<Product> productRepository = new ProductRepository();
            //productRepository.Add(new Product(1, "Laptop", 999.99m));

            #endregion

            #region Question 7 
            //Q7: What is the 'struct' constraint? Write an example.

            //Answer : The 'struct' constraint is a generic type constraint that specifies that the type parameter must be a value type (struct).

            //Container<int> intContainer = new Container<int>();
            //intContainer.Add(100);
            //Console.WriteLine(intContainer.Get()); 


            //Container<DateTime> dateContainer = new Container<DateTime>();
            //dateContainer.Add(DateTime.Now);
            //Console.WriteLine(dateContainer.Get());

            #endregion

            #region Question 8 
            //Q8: What is the 'class' constraint? Write an example.

            //Answer : The 'class' constraint is a generic type constraint that specifies that the type parameter must be a reference type (class).

            //Container2<string> stringRepo = new Container2<string>();
            //stringRepo.Add("Hello ");
            //Console.WriteLine(stringRepo.Get());



            #endregion

            #region Question 9 
            //Q9: What is the 'new()' constraint? Write an example.

            //Answer : The 'new()' constraint is a generic type constraint that specifies that the type parameter must have a parameterless constructor.

            //Factory<Product> productFactory = new Factory<Product>();
            //Product p = productFactory.Create();
            //Console.WriteLine(p.Price);
            #endregion

            #region Question 10 
            //Q10: What is the interface constraint? Write an example.

            //Answer : The interface constraint is a generic type constraint that specifies that the type parameter must implement a specific interface.

            //Document doc = new Document();
            //Printer<Document > printer = new Printer<Document>();
            //printer.PrintItem(doc);

            #endregion

            #region Question 11 
            //Q11: What is the base class constraint? Write an example.

            //Answer : The base class constraint is a generic type constraint that specifies that the type parameter must inherit from a specific base class.


            //AnimalShelter<Dog> dogContainer = new AnimalShelter<Dog>();
            //dogContainer.Add(new Dog { Name = "shika" });
            //dogContainer.MakeItSpeak(); 

            //AnimalShelter<Cat> catContainer = new AnimalShelter<Cat>();
            //catContainer.Add(new Cat { Name = "cat" });
            //catContainer.MakeItSpeak(); 
            #endregion

            #region Question 12 
            //Q12: How do you apply multiple constraints? Write an example.

            //Answer : You can apply multiple constraints by separating them with commas.

            //Manager<Employee> manager = new Manager<Employee>();
            //manager.CreateAndPrint();


            #endregion

            #region Question 13 

            //Q13: What does the 'default' keyword do in generics ?

            //Answer : The 'default' keyword in generics is used to return the default value of a type parameter.
            #endregion

            #region Question 14 

            //Q14: Write a SafeList < T > that returns default when the index is invalid.


            //SafeList<int> numbers = new SafeList<int>();
            //numbers.Add(10);
            //numbers.Add(20);

            //Console.WriteLine(numbers.Get(0)); 
            //Console.WriteLine(numbers.Get(1)); 
            //Console.WriteLine(numbers.Get(5)); 

            //SafeList<string> words = new SafeList<string>();
            //words.Add("Hello");
            //Console.WriteLine(words.Get(2) == null); 

            #endregion

            #region Question 15 

            //Q15: What is covariance? Explain the 'out' keyword.

            //Answer : Covariance allows you to use a more derived type than originally specified.
            //The 'out' keyword is used to indicate that a type parameter is covariant,
            //meaning it can be substituted with a more derived type.

            #endregion
        }
    }
}
