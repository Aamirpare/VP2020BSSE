using System;

namespace ClassesAndProperties.Classes
{
    public class Lamda
    {
        public delegate void SimplePrintDel();
        public delegate int SimpleRetunDel();
        public delegate int SimpleRetunDel2(int x, int y);
        
        
        public static Action action;

        public static Action<string> actionWithParam;



        public static void Print()
        {
            Console.WriteLine("Simple print without param");
        }
        public static void RunDemo()
        {
            //Anonymous functions in C#
            SimplePrintDel spd = delegate ()
            {
                Console.WriteLine("Simple print without param");
            };
            spd.Invoke();

            //Lamda expression in C#
            SimplePrintDel nd = () => 
            {
                Console.WriteLine("Simple print without param Lamda");
            };
            nd.Invoke();

            //=================With C# provided delegate methods=====
            action = delegate ()
            {
                Console.WriteLine("Using Action Delegate");
            };
            action.Invoke();

            action = () =>
            {
                Console.WriteLine("Using Action Lamda");
            };
            action.Invoke();
            //=================================
            var msg = "Message with anonymous method and action param";
            actionWithParam = (x) => {
                Console.WriteLine(x);
            };
            actionWithParam.Invoke(msg);

            SimpleRetunDel rd = delegate () { return 39; };
            Console.WriteLine("Value : " + rd.Invoke());

            rd = () => { return 290; };
            Console.WriteLine("Value : " + rd.Invoke());

            SimpleRetunDel2 srd = delegate (int a, int b)
            {
                return a * b;
            };
            Console.WriteLine("Value : " + srd.Invoke(10, 30));

            srd = (a, b) => a * b;
            Console.WriteLine("Value : " + srd.Invoke(10, 30));

            Console.ReadKey();
        }
    }
}
