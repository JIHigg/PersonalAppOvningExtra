using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalApp
{
    class GoldenEditionBook:Book
    {
        public override decimal Price
        {
            get
            {
                return base.Price * (decimal)1.3;
            }
        }
        public GoldenEditionBook(string author, string title, decimal price)
            :base(author,title,price)
        {}
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
