using System;
using System.Collections.Generic;
using System.Text;

namespace OopDetails
{
    public class Person
    {
        public Person()
        {

        }
        public Person(decimal initialCreditLimit)
        {
            CreditLimit = initialCreditLimit;
        }
        public string Name { get; set; }
        public decimal CreditLimit { get; private set; } = 1000;

        public void IncreaseCreditLimit(decimal amountOfIncrease)
        {
            CreditLimit += amountOfIncrease;
        }

        public void SaveToDatabase(bool makeBackup)
        {

        }
    }
}
