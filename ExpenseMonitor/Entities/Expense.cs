using System;
using System.Collections.Generic;
using System.Text;

namespace ExpenseMonitor.Entities
{
    public class Expense
    {
        private DateTime date;
        private string description;
        private string category;
        private double amount;

        public DateTime Date
        {
            get { return this.date; }
            set { this.date = value; }
        }

        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }

        public string Category
        {
            get { return this.category; }
            set { this.category = value; }
        }

        public double Amount
        {
            get { return this.amount; }
            set { this.amount = value; }
        }
    }
}
