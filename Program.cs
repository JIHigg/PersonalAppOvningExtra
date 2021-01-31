using System;

namespace PersonalApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Please enter the person's name: ");
            //string name = Console.ReadLine();
            //Console.WriteLine("Please enter the person's age: ");
            //int age = int.Parse(Console.ReadLine());

            //try
            //{
            //    Child child = new Child(name, age);
            //    Console.WriteLine(child);
            //}
            //catch(ArgumentException e)
            //{
            //    Console.WriteLine(e.Message);
            //}


            try
            {
                Console.WriteLine("Please enter the Author: ");
                string author = Console.ReadLine();
                Console.WriteLine("Please enter the Title: ");
                string title = Console.ReadLine();
                Console.WriteLine("Please enter the price: ");
                decimal price = decimal.Parse(Console.ReadLine());

                Book book = new Book(author, title, price);
                GoldenEditionBook goldenEditionBook = new GoldenEditionBook(
                    author, title, price);

                Console.WriteLine(book + Environment.NewLine);
                Console.WriteLine(goldenEditionBook);
            }catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
