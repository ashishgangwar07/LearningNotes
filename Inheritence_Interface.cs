using System;

namespace OOPInterview
{
    class Program
    {
        static void Main(string[] args)
        {
            ICustomer x = new GoldCustomer();
            x.name = "sss";
            x.productAmount = 100;
            x.CalculateDiscount();

            ICustomer x1 = new SilverCustomer();
            x1.CalculateDiscount();
            Console.WriteLine("Hello World!");

            ICustomerWithInterest c = new SilverCustomer();
            c.CalculateDiscount();
            c.CalculateInterest();
        }
    }
   
    public interface ICustomer
    {
        string name { get; set; }
        string address { get; set; }
        string productName { get; set; }
        decimal productAmount { get; set; }

        decimal CalculateDiscount();


    }
    public interface ICustomerWithInterest : ICustomer
    {
        decimal CalculateInterest();

    }
    public abstract class class1
    {

    }
    public abstract class class2
    {

    }
    public abstract class Customer 
    {
        public string name { get; set; }
        public string address { get; set; }
        public string productName { get; set; }
        public decimal productAmount { get; set; }

        public abstract decimal CalculateDiscount();
    }

    public class GoldCustomer : Customer
    {
        public override decimal CalculateDiscount()
        {
            return productAmount-10;
        }
    }
    public class SilverCustomer : Customer
    {
        public override decimal CalculateDiscount()
        {
            return productAmount-5;
        }
    }





























    public class SomeClass
    {

        private int someValue;
        public SomeClass(int val)
        {
            someValue = val;
        }

        public static SomeClass operator +(SomeClass arg1, SomeClass arg2)
        {
            return new SomeClass(arg1.someValue + arg2.someValue);
        }
    }
    public class Employee
    {
        public string name { get; set; }
        public string address { get; set; }
        public virtual void Validate()
        {
            CheckName();
            CheckAddress();
        }
        private void CheckName()
        {

        }
        private void CheckAddress()
        {

        }
    }
    public class Manager : Employee
    {
        public void Management()
        {

        }
        public override void Validate()
        {
            // our own logic
        }
        public void Validate(bool strict)
        {
            // our own logic
        }
        public void Validate(bool strict, int num1)
        {
            // our own logic
        }
    }
    public class Supervisor : Employee
    {
        public void Management()
        {

        }
        public override void Validate()
        {
            // our own logic
        }
        public void Validate(bool strict)
        {
            // our own logic
        }
        public void Validate(bool strict, int num1)
        {
            // our own logic
        }
    }
}
