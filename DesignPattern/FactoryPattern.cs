using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern
{

    // This is factory Pattern Ex.
    class FactoryPattern
    {
        public FactoryPattern()
        {

            Console.WriteLine();
            Console.WriteLine("In Factory pattern, we create the object without exposing the creation logic. In this pattern, an interface is used for creating an object, but let subclass decide which class to instantiate. The creation of object is done when it is required. The Factory method allows a class later instantiation to subclasses.");

            Console.WriteLine("In short, factory method design pattern abstract the process of object creation and allows the object to be created at run-time when it is required.");

            Console.WriteLine();

            //Console.WriteLine("Factory Patter Code Snippet");



            CodeSnippet.Factory();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Enter class Name Student or Teacher");
            string str = Console.ReadLine();

            IFactory factory = CreateObject.getObject(str);

            Console.WriteLine(factory.GetFirstName());

            Console.WriteLine(factory.GetFullName());

            Console.ReadLine();
        }

    }


    class CreateObject

    {
        public static IFactory getObject(string typeofObject)
        {
            IFactory obj = null;
            if (typeofObject.ToLower() == "teacher")
            {
                obj = new Teacher();
            }
            else
            {
                obj = new Student();
            }
            return obj;
        }

    }



    interface IFactory
    {

        public string GetFirstName();
        public string GetFullName();

    }



    class Teacher : IFactory
    {

        public string GetFirstName()
        {
            return "Teacher First Name";
        }

        public string GetFullName()
        {
            return "Teacher Full Name";
        }

    }


    class Student : IFactory
    {

        public string GetFirstName()
        {
            return "Student First Name";
        }

        public string GetFullName()
        {
            return "Student Full Name";
        }

    }



}
