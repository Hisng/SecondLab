using System;
using System.Collections.Generic;
using System.Text;

namespace _8
{
    class Invoice
    {
        private int account;
        private string customer;
        private string provider;
        private string article;
        private int quantity = 1;

        public Invoice (int account, string customer, string provider)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
        }

        public string Article
        {
            get
            {
                return article;
            }
            set
            {
                article = value;
            }
        }

        public int Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                quantity = value;
            }
        }

        public void OrderValue(int cost)
        {
            double result = cost * 1.2 * quantity;
            Console.WriteLine(customer + "'s order from " + provider + " will cost " + (cost * quantity) + "$ without NDS and " + result + "$ with NDS.");
        }

    }
}
