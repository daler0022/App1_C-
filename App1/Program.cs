using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace App1
{
    internal class Program
    {
        private static async Task Main(string[] args)
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
            #region Урок 8
            /*// Dictionary
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
        }*/
            #endregion

            #region Урок 17
            //Message mes;    
            //mes = Hello;            
            //mes();                  

            //void Hello() => Console.WriteLine("Hello IT RUN");

            //Operation operation = Add;      
            //int result = operation(4, 5);   
            //Console.WriteLine(result);      

            //operation = Multiply;           
            //result = operation(4, 5);       
            //Console.WriteLine(result);      

            //int Add(int x, int y) => x + y;

            //int Multiply(int x, int y) => x * y;
            //delegate void Message();
            //delegate int Operation(int x, int y);
            #endregion
            #region Урок 18
            //var names = new List<string> { "Bill", "Steve", "Mohan", "James", "Angel" };

            //var myLinqQuery = from name in names
            //                  where name.ToLower().Contains('a')
            //                  orderby name descending
            //                  select name;

            //foreach (var name in myLinqQuery)
            //    Console.WriteLine(name);

            //var myLinqMethod = names.Where(name => name.ToLower().Contains('a')).OrderByDescending(name => name);

            //foreach (var name in myLinqMethod)
            //    Console.WriteLine(name);

            //List<Person> persons = new List<Person>
            //{
            //    new Person("Daler", "Olimov", 19),
            //    new Person("Aminov", "Munir", 22),
            //    new Person("Aminov", "Abduaziz", 19),
            //    new Person("Olimov", "Dilshod", 16),
            //    new Person("Toshmatov", "Eshmat", 14)
            //};

            //var personLinqMethod = persons.Where(person => person.Age > 18);

            //var sumPersonAge = persons.Sum(person => person.Age);

            //Console.WriteLine(sumPersonAge);

            //foreach (var person in personLinqMethod)
            //    Console.WriteLine($"{person.Name} {person.Surname} {person.Age}");
            #endregion
            #region Урок 19
            //// Получение части коллекции

            //string[] people = { "Daler", "Umar", "Munir", "Abduaziz", "Bahrom" };
            //var result = people.Skip(3);

            //foreach (var person in result)
            //    Console.WriteLine(person);

            //var result2 = people.SkipWhile(p => p.Length == 5);

            //foreach (var person in result2)
            //    Console.WriteLine(person);

            //var result3 = people.Take(3);

            //foreach (var person in result3)
            //    Console.WriteLine(person);

            //var result4 = people.TakeWhile(p => p.Length == 5);

            //foreach (var person in result4)
            //    Console.WriteLine(person);

            //var result5 = people.Skip(3).Take(2);

            //foreach (var person in result5)
            //    Console.WriteLine(person);

            //var result6 = people.Take(2).Skip(3);

            //foreach (var person in result6)
            //    Console.WriteLine(person);

            //// Группировка

            //List<Person> persons = new List<Person>
            //{
            //    new Person("Daler", "Olimov", 19),
            //    new Person("Munir", "Aminov", 22),
            //    new Person("Abduaziz", "Aminov", 19),
            //    new Person("Dilshod", "Olimov", 16),
            //    new Person("Eshmat", "Toshmatov", 14)
            //};

            //var ages = persons.GroupBy(p => p.Age);

            //foreach (var age in ages)
            //{
            //    Console.WriteLine(age.Key);

            //    foreach (var person in age)
            //    {
            //        Console.WriteLine(person.Name);
            //    }
            //    Console.WriteLine();
            //}

            //// Соеденение коллекций

            //var users = new List<User>
            //{
            //    new User("Daler"),
            //    new User("Munir"),
            //    new User("Abduaziz"),
            //    new User("Dilshod"),
            //    new User("Eshmat"),
            //    new User("Munir"),
            //    new User("Daler"),
            //    new User("Abduaziz")
            //};

            //var names = from p in persons
            //            join u in users on p.Name equals u.Name
            //            select new { Name = u.Name, Surname = p.Surname, Age = p.Age };

            //foreach (var name in names)
            //    Console.WriteLine($"{name.Name} - {name.Surname} ({name.Age})");

            //var namesMethod = persons.Join(users,
            //    p => p.Name,
            //    u => u.Name,
            //    (p, u) => new { Name = u.Name, Surname = p.Surname, Age = p.Age });

            //foreach (var name in namesMethod)
            //    Console.WriteLine($"{name.Name} - {name.Surname} ({name.Age})");

            //// Проверка наличия и получение элементов

            //bool allContainsA = people.All(s => s.Contains("a"));
            //Console.WriteLine(allContainsA);

            //bool anyContainsA = people.Any(s => s.Contains("a"));
            //Console.WriteLine(allContainsA);

            //bool hasDaler = people.Contains("Daler");
            //Console.WriteLine(hasDaler);

            //var first = people.First();
            //Console.WriteLine(first);

            //var firstOfDefault = people.FirstOrDefault();
            //Console.WriteLine(firstOfDefault);

            //string last = people.Last();
            //Console.WriteLine(last);

            //string lastOfDefault = people.LastOrDefault();
            //Console.WriteLine(lastOfDefault);

            //// Отложенное и немедленное выполнение LINQ

            //var selectedPeoples = people.Where(s => s.Length == 3).OrderBy(s => s);

            //// выполнение LINQ-запроса
            //foreach (string s in selectedPeoples)
            //    Console.WriteLine(s);

            //var count = people.Where(s => s.Length == 5).OrderBy(s => s).Count();

            //Console.WriteLine(count);

            //people[2] = "Daler";

            //Console.WriteLine(count);

            #endregion
            #region Урок 20
            //string s = new String(new char[] { 'w', 'o', 'r', 'l', 'd' });
            //string s1 = "hello";

            //Console.WriteLine(s.Contains('o'));

            //string s2 = string.Concat(s1, s);

            //Console.WriteLine(s2);

            //int result = string.Compare(s, s1);

            //Console.WriteLine(result);

            //string wo = "l";

            //int indexof = s.IndexOf(wo);

            //Console.WriteLine(indexof);
            #endregion
            #region Урок 21
            //DateTime datetime = new DateTime();

            ////Console.WriteLine(datetime);

            //DateTime date1 = new DateTime(2022, 8, 11, 19, 0, 0);

            //Console.WriteLine(date1);

            ////Console.WriteLine(DateTime.UtcNow);
            ////Console.WriteLine(DateTime.Now);
            ////Console.WriteLine(DateTime.Today);

            //Console.WriteLine(date1.AddHours(3));

            //Console.WriteLine(date1.ToLongDateString());

            //try
            //{
            //    int x = 5;
            //    int y = x / 0;
            //    Console.WriteLine($"Результат: {y}");
            //}
            //catch
            //{
            //    Console.WriteLine("Возникло исключение!");
            //}
            //finally
            //{
            //    Console.WriteLine("Блок finally");
            //}
            //Console.WriteLine("Конец программы");

            //try
            //{
            //    int x = 5;
            //    int y = x / 0;
            //    Console.WriteLine($"Результат: {y}");
            //}
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("Возникло исключение DivideByZeroException");
            //}

            //try
            //{
            //    int x = 5;
            //    int y = x / 0;
            //    Console.WriteLine($"Результат: {y}");
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine($"Возникло исключение {ex.Message}");
            //}

            //try
            //{
            //    Console.Write("Введите имя: ");
            //    string? name = Console.ReadLine();
            //    if (name == null || name.Length < 2)
            //    {
            //        throw new Exception("Длина имени меньше 2 символов");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Ваше имя: {name}");
            //    }
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine($"Ошибка: {e.Message}");
            //}

            //try
            //{
            //    int number = Convert.ToInt32(Console.ReadLine());
            //    throw new Exception("dont parse");
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine($"Exception: {e}");
            //}
            #endregion

            DriveInfo[] drives = DriveInfo.GetDrives();

            foreach (DriveInfo drive in drives)
            {
                Console.WriteLine($"Название: {drive.Name}");
                Console.WriteLine($"Тип: {drive.DriveType}");
                if (drive.IsReady)
                {
                }
                Console.WriteLine($"Объем диска: {drive.TotalSize}");
                Console.WriteLine($"Свободное пространство: {drive.TotalFreeSpace}");
                Console.WriteLine($"Метка диска: {drive.VolumeLabel}");
                Console.WriteLine($"Свободное место на диске: {drive.AvailableFreeSpace}");
                Console.WriteLine($"Корневой каталог: {drive.RootDirectory}");
                Console.WriteLine($"Имя файловой системы: {drive.DriveFormat}");
            }
            Console.WriteLine();

            string dirName = "C:\\";
            if (Directory.Exists(dirName))
            {
                Console.WriteLine("Подкаталоги:");
                string[] dirs = Directory.GetDirectories(dirName);
                foreach (string s in dirs)
                {
                    Console.WriteLine(s);
                }
                Console.WriteLine();
                Console.WriteLine("Файлы:");
                string[] files = Directory.GetFiles(dirName);
                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }
            }


            string path = @"C:\test";
            DirectoryInfo drinfo = new DirectoryInfo(path);

            if(!drinfo.Exists)
            {
                drinfo.Create();
                Console.WriteLine("Файл успешно создан!");
            }
            else
            {
                Console.WriteLine("Файл не создан!");
            }

            string dirName1 = "C:\\test";

            DirectoryInfo dirInfo = new DirectoryInfo(dirName1);

            Console.WriteLine($"Название каталога: {dirInfo.Name}");
            Console.WriteLine($"Полное название каталога: {dirInfo.FullName}");
            Console.WriteLine($"Время создания каталога: {dirInfo.CreationTime}");
            Console.WriteLine($"Корневой каталог: {dirInfo.Root}");

            string dirName2 = @"C:\test";

            DirectoryInfo dirInfo1 = new DirectoryInfo(dirName2);
            if (dirInfo1.Exists)
            {
                dirInfo1.Delete(true);
                Console.WriteLine("Каталог удален");
            }
            else
            {
                Console.WriteLine("Каталог не существует");
            }

            string path1 = @"C:\projects\content.txt";

            string originalText = "Hello IT-RUN";

            File.WriteAllText(path1, originalText);

            string fileText = File.ReadAllText(path1);

            Console.WriteLine(fileText);

            FileInfo fileDelete = new FileInfo(path1);

            if (fileDelete.Exists)
            {
                fileDelete.Delete();
            }

            string newPath = @"C:\projects\context\content.txt";

            FileInfo fileMove = new FileInfo(path1);
            if(fileMove.Exists)
            {
                fileMove.MoveTo(newPath);
            }

            string copyPath = @"C:\projects\context\copy.txt";
            FileInfo fileCopy = new FileInfo(path1);
            if(fileCopy.Exists)
            {
                fileCopy.CopyTo(copyPath);
            }

            Console.ReadLine();
        
        }
    }
}

