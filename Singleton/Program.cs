using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Hospital
    {
        private static Hospital _instance;     //Static property with have private keyword

        private Hospital()      //Private constructor 
        {
        }

        public static Hospital Instance   //static property & return instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Hospital();

                return _instance;
            }
        }

        public void DoSingletonOperation()    //non staic public method for singleton opeartion (call by refernce)
        {
            Console.WriteLine("singleton operation");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Hospital hospital = Hospital.Instance;
            Hospital hospital2 = Hospital.Instance;

            hospital.DoSingletonOperation();   //singleton opeartion

                Console.WriteLine(hospital == hospital2);
            Console.ReadLine();
           
            
        }
    }
}
