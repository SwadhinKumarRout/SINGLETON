using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Singleton
    {
        private static Singleton _instance;     //Static property with have private keyword

        private Singleton()      //Private constructor 
        {
        }

        public static Singleton Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Singleton();

                return _instance;
            }
        }

        public void DoSingletonOperation()    //non sttaic public method for singleton opeartion
        {
            Console.WriteLine("singleton operation");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
          
                Singleton singleton = Singleton.Instance;

                Singleton singleton2 = Singleton.Instance;

                Console.WriteLine(singleton == singleton2);
            Console.ReadLine();
           
            
        }
    }
}
