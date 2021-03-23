using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();



            Person person1 = new Person();
            Person person2 = new Person();
            person1.FırstName = "İlknur";


            person2 = person1;
            person1.FırstName = "irem";
            Console.WriteLine(person2.FırstName);  //irem olarak degişir

            Customer customer = new Customer();
            Employee employee = new Employee();
            employee.FırstName = "İsa";



            Person person3 = customer;    //peki bunu nasıl yaptık çünkü customer aynı zamanda person dır. 
            customer.FırstName = "Pınar";      // Biz miras aldıgımız sınıfa mirası alan sınıfı atayabiiriz.
            Console.WriteLine(person3.FırstName);     //base class
            customer.CrediCardNumber = "123456789";

            Console.WriteLine(((Customer)person3).CrediCardNumber);

            PersonManager personManager = new PersonManager();

            personManager.Add(employee);  // person employee ve customer adresini tutuyor ve bu sayede kabul ediyo.


            Console.ReadLine();


        }


        class Person
        {
            public int Id { get; set; }
            public string FırstName { get; set; }
            public string LastName { get; set; }


        }
        class Customer : Person
        {
            public string CrediCardNumber { get; set; }
        }
        class Employee : Person
        {
            public int EmployeNumber { get; set; }
        }

        class PersonManager
        {
            public void Add(Person person)
            {
                Console.WriteLine(person.FırstName);

            }

        }
    }
}
