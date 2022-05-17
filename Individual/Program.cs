using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual
{
    class Program
    {
        public class One_Two
        {
            public int value;
        }



        //-------------------------
        struct struct_test
        {
            public struct_test(int age, string name, bool isCat)
            {
                Age = age;
                Name = name;
                IsCat = isCat;
            }
        public int Age { get; set; }
        public string Name { get; set; }
        public bool IsCat { get; set; }

        public override string ToString() => $"({Age}, {Name}, {IsCat})";
        }
        //-------------------------
        enum enum_test
        {
            Cat,
            Dog,
            Mouse
        }
        //-------------------------
        class class_test
        {
            public class_test()
            {
                string cat = "Red";
            }
        }
        //-------------------------
        interface interface_test
        {
            void Cat();
            string Set();
            int Go();
        }
        //-------------------------
        public delegate void delegate_test(string delegated);
        public static void delegate_method(string delegated)
        {
            Console.WriteLine(delegated);
        }
        //-------------------------
        public static void ref_test(ref int a)
        {
            a = 3;
        }
        //-------------------------
        public static void out_test(out int b)
        {
            b = 3;
        }
        //-------------------------

        static void Main(string[] args)
        {
            /*
             * Типи даних в мові програмування C# поділяються на два види:
             * 1. Типи Значень
             * 2. Типи Посилань
             * Вони відрізняються між собою в продуктивності, способом зберігання їх в памяті та роботи з ними, і тд.
             * Є два способи зберігання інформації. Це Stack(Стек) і Pile(Купа). Детальніше пізніше
            */

            //-----Типи Значень-----
            /*
             * По іншому вони називаються структурними типами. Вони зберігаються у Стеку. Стек - це набір впорядкованих
             * значень. Якщо сказати точніше, Стек - це відділ памяті, в якому інформація зберігається у визначених межах
             * і використовується для передачі параметрів і їхніх значень зі змінних  у першозданному вигляді (саме значення)
             * Змінні містять в собі саме значення
            */
            //!!!===Цілочисельні Типи (byte, char, short, int, long, та інші укорочені та побільшені їх різновиди)===!!!
            byte byte_test = 1; //Max = 255 | Min = 0
            char char_test = '0'; //Max = 9 | Min = 0 | Фактично не рахується цілочисельним, але може бути ним
            short short_test = 2; //Max = 32767 | Min = -32768
            int int_test = 3; //Max = 2147483647 | Min = -2147483648
            long long_test = 4; //Max = 9223372036854775807 | Min = -9223372036854775808
            //!!!===Типи З Плаваючою Комою (float, double)===!!!
            float float_test = 5.1f; //Max = 3,402823466E+38 | Min = 1,175494351E–38
            double double_test = 6.2d; //Max = 1.7976931348623157E+308 | Min = -1.7976931348623157E+308
            //!!!===Тип decimal===!!!
            decimal decimal_test = 7.3m; //Max = 79228162514264337593543950335 | Min = -79228162514264337593543950335
            //!!!===Тип bool===!!!
            bool bool_test = true; //true | false
            //!!!===Структури (struct)===!!!
            //Структури - це тип, який з'єднує декілька данних, та функцій, звязаних з ними, в один (інкапсулює) 
          /*struct struct_test
            {
                public Coords(int age, string name, bool isCat)
                {
                    public int age;
     !!!            public string name;
                    public bool isCat;
                }
                public int Age { get; init; }
                public string Name { get; init; }
                public bool IsCat { get; init; }

                public override string ToString() => $"({Age}, {Name}, {IsCat})";
            }*/
            struct_test struct_object = new struct_test(13, "Murchik", true);
            Console.WriteLine("");
            Console.WriteLine("-=-{Struct}-=-");
            Console.Write("Struct: ");
            Console.WriteLine(struct_object);
            Console.WriteLine("-=-{Struct}-=-");
            Console.WriteLine("");
            //!!!===Перерахування (enum)===!!!
            //Перерахування - це сукупність констант, які по стандарту є типу int. Можуть використовуватись для бітових 
            //операцій
          /*enum enum_test
            {
                Cat,
     !!!        Dog,
                Mouse
            }*/
            enum_test enum_var = (enum_test)0;
            Console.WriteLine("");
            Console.WriteLine("-=-{Enum}-=-");
            Console.Write("Enum[0]: ");
            Console.WriteLine(enum_var);
            Console.WriteLine("-=-{Enum}-=-");
            Console.WriteLine("");
            //Якщо призначити один тип значень іншому, то при зміні першого, другий змінюватись не буде
            int one = 1;
            int two = 2;
            two = one;
            one = 3;
            Console.WriteLine("");
            Console.WriteLine("-=-{Types Of Values}-=-");
            Console.Write("One: ");
            Console.WriteLine(one); //Виведе 3 
            Console.Write("Two: ");
            Console.WriteLine(two); //Виведе 1 
            Console.WriteLine("-=-{Types Of Values}-=-");
            Console.WriteLine("");

            //-----Типи Посилань-----
            /*
             * По іншому вони називаються довідковими типами. Вони зберігаються у Купі. Купа - це область пам'яті, яка
             * містить в собі об'єкти і їх посилання. Їх можна очистити за допомогою  спеціальної функції GarbageColector
             * Змінні містять в собі не саме значення, а посилання на комірку пам'яті з тим значенням
            */
            //!!!===Класи (class)===!!!
            /*class class_test
              {
                  public class_test()
                  {
       !!!            string cat = "Red";
                  }
              }*/
            //!!!===Інтерфейси (interface)===!!!
            //Інтерфейс - це тип, який визначає те, що має робити клас, який наслідує його
            /*interface interface_test
              {
                void Cat();
       !!!      string Set();
                int Go();
              }*/
            //!!!===Делегати (delegate)===!!!
            //Делегати - це тип, який посилається на методи з визначеним списком параметрів, і може виконувати їх
            /*public delegate void delegate_test(string delegated);
              public static void delegate_method(string delegated)
              {
                  Console.WriteLine(delegated);
              }*/
            delegate_test delegate_object = new delegate_test(delegate_method);
            Console.WriteLine("");
            Console.WriteLine("-=-{Delegates}-=-");
            delegate_object("Hello World!");
            Console.WriteLine("-=-{Delegates}-=-");
            Console.WriteLine("");
            //!!!===Тип object===!!!
            class_test object_test = new class_test();
            //!!!===Тип string===!!!
            string string_test = "CatRad";
            /*
             * Якщо призначити один тип значень іншому, то при зміні першого, зміниться і другий, 
             * через те що вони містять посилання на значення в пам'яті, а не саме значення
            */
            One_Two one_ = new One_Two();
            One_Two two_ = new One_Two();
            one_.value = 1;
            two_.value = 2;
            two_ = one_; //Присвоєння Посилання, А Не Самого Значення
            two_.value = 3;
            Console.WriteLine("");
            Console.WriteLine("-=-{Types Of References}-=-");
            Console.Write("One_.Value: ");
            Console.WriteLine(one_.value); //Виведе 3
            Console.Write("Two_.Value: ");
            Console.WriteLine(two_.value); //Виведе 3
            Console.WriteLine("-=-{Types Of References}-=-");
            Console.WriteLine("");

            //-----Ключове Слово ref-----
            //Це ключове слово використовується для того щоб передавати параметри по посиланню. Про особливості пізніше
          /*public static void ref_test(ref int a)
            {
                a = 3;
            }*/

            int a = 1;
            ref_test(ref a);
            Console.WriteLine("");
            Console.WriteLine("-=-{ref}-=-");
            Console.Write("a: ");
            Console.WriteLine(a); //Виведе 3
            Console.WriteLine("-=-{ref}-=-");
            Console.WriteLine("");
            //-----Ключове Слово out-----
            //Це ключове слово використовується для того щоб передавати параметри по посиланню. Про особливості пізніше
            /*public static void out_test(out int b)
              {
                  b = 3;
              }*/
            int b;
            out_test(out b);
            Console.WriteLine("");
            Console.WriteLine("-=-{out}-=-");
            Console.Write("b: ");
            Console.WriteLine(b); //Виведе 3
            Console.WriteLine("-=-{out}-=-");
            Console.WriteLine("");

            /*
             * Хоч вони і дуже похожі, їхня різниця полягає в деякий речах, наприклад:
             * 1. out - працює на вихід | ref - працює на вхід і вихід
             * 2. Для out параметру не обов'язково присвоювати значення змінній перед використанням функції | 
             *    Для ref параметру обов'язково потрібно ініціалізувати змінну перед використанням функції 
             * 3. При зрівнюванні по функціоналу out змінна похожа на неініціалізовану локальну змінну | 
             *    ref змінна похожа на ініціалізовану локальну змінну (з нею можна пророблювати дії)
             * 4. В вигляді параметрів, out похожий на додатковий return | 
             *    ref це параметр, зміни якого можна побачити за функцією
             */

            /*
            void out_func(out string value)
            {
                Console.WriteLine(value); //Не можна!!! value не ініціалізовано
                if (false) {
                    return; //Не можна!!! Немає значення value, отже закінчити функцію не можливо
                }
                value = "Hello World!";
            }

            string stringer;
            out_func(out stringer);
            --------------------------------------------------------------------
            void ref_func(ref string value)
            {
                Console.WriteLine(value); //Можна!!!
                if (false) {
                    return; //Можна!!! value буде мати попереднє значення
                }
                value = "Hello World!";
            }

            string stringer;
            ref_func(out stringer); //Не можна!!! Функція має використовувати значення, значить його треба ініціалізувати
            */

            Console.ReadKey();
        }
    }
}