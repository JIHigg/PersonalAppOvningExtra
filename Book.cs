using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PersonalApp
{
    public class Book
    {
        private string author;
        private string title;
        private decimal price;
        public string Author
        {
            get { return author; }
            set
            {
                if (value.Any(char.IsDigit))
                    throw new ApplicationException("Author not valid!");
                else
                    Author = author;
            }
        }
        public string Title
        {
            get { return title; }
            set
            {
                if (value.Length < 3)
                    throw new ApplicationException("Title not valid!");
                else
                    Title = title;
            }
        }

        public virtual decimal Price
        {
            get { return price; }
            set
            {
                if (value<=0)
                    throw new ArgumentException("Price not valid!");
                else
                    Price = value;
            }
        }

        public Book(string author, string title, decimal price)
        {
            Author = author;
            Title = title;
            Price = price;
        }

        public override string ToString()
        {
            var resultBuilder = new StringBuilder();
            resultBuilder.Append($"Type: {this.GetType().Name}")
                .AppendLine($"Title: {this.Title}")
                .AppendLine($"Author: {this.Author}")
                .AppendLine($"Price: {Price:f2}");
            string result = resultBuilder.ToString().TrimEnd();
            return result;
        }

    }
}
