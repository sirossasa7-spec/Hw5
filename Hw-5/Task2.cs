using System;
using System.Collections.Generic;

namespace Hw_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ReadingList list = new ReadingList();

            list.AddBook("Гаррі Поттер");
            list.AddBook("1984");
            list.AddBook("Майстер і Маргарита");

            Console.WriteLine("Список книг:");

            for (int i = 0; i < list.Count; i++)
                Console.WriteLine($"{i + 1}. {list[i]}");

            Console.WriteLine();

            Console.WriteLine("Є книга '1984'? " + list.Contains("1984"));

            list.RemoveBook("1984");

            Console.WriteLine("\nПісля видалення:");

            for (int i = 0; i < list.Count; i++)
                Console.WriteLine($"{i + 1}. {list[i]}");

            list += "Маленький принц";

            Console.WriteLine("\nПісля додавання оператором +:");

            for (int i = 0; i < list.Count; i++)
                Console.WriteLine($"{i + 1}. {list[i]}");
        }
    }

    class ReadingList
    {
        private List<string> books = new List<string>();

        public int Count
        {
            get { return books.Count; }
        }

        public string this[int index]
        {
            get { return books[index]; }
            set { books[index] = value; }
        }

        public void AddBook(string book)
        {
            books.Add(book);
        }

        public void RemoveBook(string book)
        {
            books.Remove(book);
        }

        public bool Contains(string book)
        {
            return books.Contains(book);
        }

        public static ReadingList operator +(ReadingList list, string book)
        {
            list.AddBook(book);
            return list;
        }

        public static ReadingList operator -(ReadingList list, string book)
        {
            list.RemoveBook(book);
            return list;
        }
    }
}