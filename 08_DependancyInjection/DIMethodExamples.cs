using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _08_DependancyInjection
{
    interface ICurrency
    {
        string Name { get; }
        decimal Value { get; }
    }

    class Penny : ICurrency
    {
        public string Name { get => "Penny"; }

        public decimal Value { get => 0.01m; }
    }

    class Dime : ICurrency
    {
        public string Name { get => "Dime"; }

        public decimal Value { get => 0.01m; }
    }


    class Dollar : ICurrency
    {
        public string Name { get => "Dollar"; }
        public decimal Value { get => 1.0m; }
    }


    class ElectronicPayment : ICurrency
    {
        public string Name { get => "Electronic Payment"; }
        public decimal Value { get; }

        public ElectronicPayment(decimal value)
        {
            Value = value;
        }
    }
    [TestClass]
    public class DIMethodExamples
    {
        private decimal _debt = 100000.0m;
        [TestMethod]
        public void DIMethodExample()
        {

            Pay(new Dollar());
            Pay(new Penny());
            Pay(new ElectronicPayment(20.0m));
            Console.WriteLine(_debt);
        }

        void Pay(ICurrency currency)
        {
            _debt -= currency.Value;//_debt = _debt -currency.Value;
            Console.WriteLine($"You paid {currency.Value} to Josh");
        }
    }

    class Transaction
    {

        private readonly ICurrency _amount;
        public DateTimeOffset DateOfTransaction { get; set; }

        public Transaction(ICurrency currency)// currency - parameter
        {
            _amount = currency;
            DateOfTransaction = DateTimeOffset.Now;
        }

        public decimal GetTransactionAmount()
        {
            return _amount.Value;
        }

        public string GetPaymentTypeOfTransaction()
        {
            return _amount.Name;
        }

    }

    [TestClass]
    public class ConstructorDI
    {
        [TestMethod]
        public void InjectingIntoConstructors()
        {
            Dollar dollar = new Dollar();
            Transaction firstTransaction = new Transaction(dollar);
            Transaction secondTransaction = new Transaction(new ElectronicPayment(20.0m));

            Console.WriteLine(firstTransaction.GetTransactionAmount());
            Console.WriteLine(secondTransaction.GetPaymentTypeOfTransaction());

        }
    }

}
