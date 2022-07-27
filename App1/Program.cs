using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace App1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            #region Урок 1

            /*string x = Console.ReadLine();
            string y = Console.ReadLine();
            bool resultConvert = int.TryParse(x, out int x2) && int.TryParse(y, out int y2);
            if (resultConvert)
            {
                var sum = x2 + y2;
                Console.WriteLine(sum);
                Console.WriteLine("Convert Ok");
            }
            else
            {
                Console.WriteLine("error convert");
            }

            Console.ReadLine();*/

            #endregion
            #region Урок 2

            /*int a = 6;
            int b = 8;
            b--;
            Console.WriteLine($" a равно {++a}, b равно {b}");

            bool re = a >= b;
            Console.WriteLine(re);

            string l1 = "c#";
            string l2 = "c++";
            if (l1 == l2)
            {
                Console.WriteLine("Один и тот же ЯП");
            }
            else
            {
                Console.WriteLine("C# это не C++");
            }

            int num1 = 8;
            int num2 = 6;
            if (num1 > num2)
            {
                Console.WriteLine($"Число {num1} больше числа {num2}");
            }
            else
            {
                Console.WriteLine($"Число {num2} больше числа {num1}");
            }

            decimal n1 = 1;
            decimal n2 = 1;
            if (n1 < 10 || n2 > 100)
            {
                Console.WriteLine("Return True");
            }
            else
            {
                Console.WriteLine("Return False");
            }

            double t = double.Parse(Console.ReadLine());

            if (t % 2 == 0)
            {
                Console.WriteLine("Чётное число");
            }
            else
            {
                Console.WriteLine("Нечётное число");
            }*/

            #endregion
            #region Урок 3

            //Задача №1
            /*int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int evenNumber = 0;
            int oddNumber = 0;

            foreach(int i in arr)
            {
                if (i % 2 == 0)
                {
                    evenNumber++;
                }
                else
                {
                    oddNumber++;
                }
            }
            Console.WriteLine(evenNumber);
            Console.WriteLine(oddNumber);*/

            //Задача №2
            /*int[] array = { 1, 3, 3, 8, 7, 6, 7, 8, 9, 10 };

            for(int i = 0; i < array.Length; i++)
            {
                for(int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                        Console.WriteLine($"Повторяется число под индексом {j}");
                }
            }*/

            //Задача №3
            /*int[] arr = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int summ = 0;
            {
                for(int i = 0; i < arr.Length; i++)
                {
                    summ += arr[i];
                }
            }

            Console.WriteLine(summ);*/

            #endregion
            #region Урок 4

            //void SayHello(string message)
            //{
            //    Console.WriteLine($"Здравствуйте {message}");
            //}

            //SayHello("Далер");

            /*int calc(string op, int a, int b)
                {
                    switch (op)
                    {
                        case "+": return a + b;
                        case "-": return a - b;
                        case "*": return a * b;
                        case "/": return a / b;
                        default: return 0;
                    }
                }
    
                int result = calc("/", 35, 15);
                Console.WriteLine(result);*/

            /*string greatValue(int a, int b)
            {
                if (a > b)
                {
                    return $"Число {a} больше {b}";
                }
                else if (a < b)
                {
                    return $"Число {b} больше {a}";
                }
                else
                {
                    return $"Числа равны";
                }
            }

            string result1 = greatValue(10, 5);
            Console.WriteLine(result1);*/
            //double B;

            //void PowerA3(double A, out double B)
            //{
            //    B = Math.Pow(A, 3);
            //}

            //PowerA3(2, out B);

            //Console.WriteLine(B);

            #endregion
            #region Урок 5

            //Person relad = new Person("Abdu", 20);

            //Person daler = new Person("Daler");

            //relad.Hello();

            //People all = new People("Abdu", 23);

            //all.Print();

            #endregion
            #region Урок 6
            //Person relad = new Person("Abdu", 20);

            //Person daler = new Person("Daler");

            //relad.Hello();

            //People all = new People("Abdu", 23);

            //all.Print();
            #endregion
            #region Урок 7
            /*Person bob = new Person("Bob");
            Console.WriteLine(bob.Age);

            Employee tom = new Employee("Tom", "Microsoft");
            tom.Print();
            Console.WriteLine(tom.Age);
            tom.Age = 22;
            Console.WriteLine(tom.Age);
            tom.Age = 12;
            Console.WriteLine(tom.Age);

            Transport car = new Car("машина");
            Transport ship = new Ship("корабль");
            Transport aircraft = new Aircraft("самолет");

            car.Move();        
            ship.Move();
            aircraft.Move();*/
            #endregion


            // Dictionary
            Dictionary<string, string> pairs = new Dictionary<string, string>();

            pairs.Add("учитель", "teacher");
            pairs.Add("проверка", "check");
            pairs.Add("компьютер", "computer");
            pairs.Add("автомобиль", "car");

            Console.WriteLine("\npairs");
            foreach (KeyValuePair<string, string> e in pairs) Console.WriteLine($"{e} ");     

            Console.WriteLine($"\n\npairs[\"учитель\"] = {pairs["учитель"]}"); 

            Console.WriteLine("\npairs.keys");
            foreach (var e in pairs.Keys) Console.Write($"{e} ");

            Console.WriteLine("\n\npairs.values");
            foreach (var e in pairs.Values) Console.Write($"{e} ");

            Console.WriteLine("\n\nудаление \"учитель\"");

            pairs.Remove("учитель");

            Console.WriteLine("\npairs");
            foreach (KeyValuePair<string, string> e in pairs) Console.WriteLine($"{e} ");       

            Console.WriteLine("\n");

            Console.WriteLine($"элементов в словаре: {pairs.Count}"); 
            pairs.Clear();
            Console.WriteLine("pairs.clear(); выполнен");
            Console.WriteLine($"элементов в словаре: {pairs.Count}");


            // List
            List<Person> persons = new List<Person>
            {
                new Person("Daler", "Olimov", 19)
            };

            persons.Add(new Person("Abduaziz", "Aminov", 20));
            persons.Add(new Person("Munir", "Aminov", 22));


            Console.WriteLine(persons.Count);

            persons.Insert(0, new Person("Dilshod", "Olimov", 16));

            Console.WriteLine(persons.Count);

            Console.WriteLine("\n");

            foreach (var e in persons)
            {
                if(e.Surname == "Olimov")
                {
                    e.Print();
                }
            }

            Console.WriteLine("\n");

            foreach(var person in persons)
            {
                person.Print();
                
            }
            persons.Reverse();

            persons.RemoveAt(1);

            Console.WriteLine("\n");
            foreach(var person in persons)
            {
                person.Print();
            }


            for (var i = 1; i < persons.Count; i++)
            {
                if (persons[i].Age < 18)
                {
                    persons[i].Age = 18;
                }
            }

            foreach (var person in persons)
            {
                person.Print();
            }

            var range = persons.GetRange(1, 2);



            // Queue

            Queue<int> queue = new Queue<int>();

            // First In First Out = FIFO

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);

            foreach (var e in queue) Console.Write($"{e} "); // 1 2 3 4 5
            Console.WriteLine("\n");

            Console.WriteLine($"queue.Dequeue() = {queue.Dequeue()}"); // 1
            foreach (var e in queue) Console.Write($"{e} "); // 2 3 4 5
            Console.WriteLine("\n");


            Console.WriteLine($"queue.Peek() = {queue.Peek()}"); // 2
            foreach (var e in queue) Console.Write($"{e} "); // 2 3 4 5
            Console.WriteLine("\n");



            // Stack 

            Stack<int> stack = new Stack<int>();

            // First In Last Out -FILO

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            foreach (var e in stack) Console.Write($"{e} "); // 5 4 3 2 1
            Console.WriteLine("\n");

            Console.WriteLine($"stack.Pop() = {stack.Pop()}"); // 5
            foreach (var e in stack) Console.Write($"{e} "); // 4 3 2 1
            Console.WriteLine("\n");


            Console.WriteLine($"stack.Peek() = {stack.Peek()}"); // 4
            foreach (var e in stack) Console.Write($"{e} "); // 4 3 2 1
            Console.WriteLine("\n");


            // ObservableCollection

            ObservableCollection<User> users = new ObservableCollection<User>
               {
                    new User { Name = "Evgeni"},
                    new User { Name = "Slava"},
                    new User { Name = "Boris"}
               };

            users.CollectionChanged += Users_CollectionChanged;

            users.Add(new User { Name = "Sergei" });

            users.RemoveAt(1);

            users[0] = new User { Name = "Petia" };

            foreach (User user in users)
            {
                Console.WriteLine(user.Name);
            }

            Console.ReadLine();
        }
        private static void Users_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            // срабатывает при добавлении элемента
            if (e.Action == NotifyCollectionChangedAction.Add)
            {
                User newUser = e.NewItems[0] as User;
                Console.WriteLine("Добавлен новый объект: {0}", newUser.Name);
            }

            // срабатывает при удалении элемента
            else if (e.Action == NotifyCollectionChangedAction.Remove)
            {
                User oldUser = e.OldItems[0] as User;
                Console.WriteLine("Удален объект: {0}", oldUser.Name);
            }

            // срабатывает при замене элемента
            else if (e.Action == NotifyCollectionChangedAction.Replace)
            {
                User replacedUser = e.OldItems[0] as User;
                User replacingUser = e.NewItems[0] as User;
                Console.WriteLine("Объект {0} заменен объектом {1}", replacedUser.Name, replacingUser.Name);
            }
        }
    }
}

