using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateInvocationProgram
{
    class Program
    {
        
            static double Calculate(int x, double y)
            {
                return x + y;
            }

            void Update(int newNumber)
            {
                System.Console.WriteLine(newNumber);
            }

            void Delete(string key)
            {

            }
            void Method1()
            {

            }
            void Method2(string data1)
            {

            }
            int Method3(int A)
            {
                return A;
            }
            bool Method4(string x, string y)
            {
                return true;
            }
            
            static void FunctionsAsAnArguments(Func<int, double, double>obj1, Action<int>obj2, Action<string>obj3, Action obj4, Func<int, int> obj5, Func<string, string, bool> obj6)
            {
                
                double values = obj1.Invoke(5,1.6);
                obj2.Invoke(7);
                obj3.Invoke("data");
                obj4.Invoke();
                int intParamete = obj5.Invoke(5);
                bool value = obj6.Invoke("x","y");
                Console.WriteLine(values);
                Console.WriteLine(intParamete);
                Console.WriteLine(value);

        }

            static void Main()
            {
                Program _obj = new Program();
                Func<int, double, double> obj1Object = new Func<int, double, double>(Calculate);
                Action<int> obj2Object = new Action<int>(_obj.Update);
                Action<string> obj3Object = new Action<string>(_obj.Delete);
                Action obj4Object = new Action(_obj.Method1);
                Func<int, int> obj5Object = new Func<int, int>(_obj.Method3);
                Func<string, string, bool> obj6Object = new Func<string, string, bool>(_obj.Method4);
                FunctionsAsAnArguments(obj1Object, obj2Object, obj3Object, obj4Object, obj5Object, obj6Object);
            Console.ReadLine();

            }

        }
    }
    

