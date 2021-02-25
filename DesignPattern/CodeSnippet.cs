using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern
{
   static class CodeSnippet
    {
       
       public static void Factory() {

            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Red;


            #region Code Snippet Factory Pattern
            string CodeSnippet = @"
    
!!!!!!Code Snippet!!!!!

    interface IFactory{
        public string GetFirstName();
        public string GetFullName();
    }
    class Teacher : IFactory
    {
        public string GetFirstName()
        {
            return 'Teacher First Name';
        }
        public string GeFullName()
        {
            return 'Teacher Full Name';
        }
    }
    class Student : IFactory
    {
        public string GetFirstName()
        {
            return 'Student First Name';
        }
        public string GetFullName()
        {
            return 'Student Full Name';
        }
 class CreateObject
    {
        public static IFactory getObject(string typeofObject)
        {
            IFactory obj = null;
            if (typeofObject.ToLower() == 'teacher')
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
    public static void Main(){
    Console.WriteLine('Enter class Name Student or Teacher');
            string str = Console.ReadLine();
            IFactory factory = CreateObject.getObject(str);
            Console.WriteLine(factory.GetFirstName());
            Console.WriteLine(factory.GetFullName());
    }
}";
          
            Console.WriteLine(CodeSnippet);
            #endregion

            
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}
