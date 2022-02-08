using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    //delegate is a type safe function pointer.It holds the refernce of a method and when we
    //call delegate it interally call the method

    public delegate void mydelegate(string s);//Declaring the delegate return type and parameter type should be same as method that is calling 
    class Program
    {

        public void SendMessage(string s)
        {
            Console.WriteLine(s + "from  delegate");
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            mydelegate de = new mydelegate(p.SendMessage);//binding the method with delegate
            de("heyy");//calling delegate
            Console.Read();
        }
    }

}
