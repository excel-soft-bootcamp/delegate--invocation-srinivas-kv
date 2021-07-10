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
            void method1()
            {

            }
            void method2(string data1)
            {

            }
            int method3(int A)
            {
                return A;
            }
            bool method4(string x, string y)
            {
                return true;
            }
            
            static void FunctionsAsAnArguments(Action obj, Action<string> obj2, Func<int, int> obj3, Func<string, string, bool> obj4)
            {
                    Func<int, double, double> funcCalculate = new Func<int, double, double>(Program.Calculate);
                    Program _obj = new Program();
                    Action<int> actionUpdate = new Action<int>(_obj.Update);
                    Action<string> actionDelete = new Action<string>(_obj.Delete);    
             }

            static void Main()
            {
                Program _obj1 = new Program();
                Action obj = new Action(_obj1.method1);
                Action<string> obj2 = new Action<string>(_obj1.method2);
                Func<int, int> obj3 = new Func<int, int>(_obj1.method3);
                Func<string, string, bool> obj4 = new Func<string, string, bool>(_obj1.method4);
                FunctionsAsAnArguments(obj,obj2,obj3,obj4);
            }

        }
    }
    

