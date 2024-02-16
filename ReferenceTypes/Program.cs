using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 20;
            sayi1 = sayi2;
            sayi2 = 100;

            
            Console.WriteLine("Sayı 1 -> " + sayi1);

            int[] numbers1=new int[3] { 1,2,3};
            int[] numbers2=new int[3] { 4,5,6};

            numbers1 = numbers2;
            numbers2[0] = 1000;

            Console.WriteLine("Sayılar 1'in 0. indexi ->" + numbers1[0]);

            Person person1 = new Person();
            Person person2 = new Person();

            person1.FirstName = "Engin";
            person2 = person1;
            person1.FirstName = "Derin";
            Console.WriteLine("Ref type örneğinin 4684936340.sı ->" +person2.FirstName);

            Customer customer = new Customer();
            customer.FirstName = "İlker";
            customer.CreditCardNumber = "45454848688554";
            Employee employee = new Employee();

            Person person3 = customer;
            Console.WriteLine("Person3 ->" + ((Customer)person3).CreditCardNumber);

            PersonManager personManager = new PersonManager();
            personManager.Add(person3);
            //personManager.Add(customer);
           // personManager.Add(employee);


            Console.ReadLine();
        }

        class Person
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }

        class Customer : Person
        {
            public string CreditCardNumber { get; set; }
        }

        class Employee : Person
        {
            public string EmployeeNuber { get; set; }
        }

        class PersonManager
        {
            public void Add(Person person)
            {
                Console.WriteLine(person.FirstName);
            }
        }
    }
}
