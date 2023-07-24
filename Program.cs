namespace cSharp_lambdaExpressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Func<int, int> square = (x) =>
            //{
            //    Console.WriteLine(x);
            //    return x * x;
            //};
            //int result = square(5);
            //Console.WriteLine(result);

            //MathOperation mathOperation = Add;
            //int result = mathOperation(5, 3);
            //mathOperation = multiply;
            //int result1 = mathOperation(10, 10);
            //Console.WriteLine(result);
            //Console.WriteLine(result1);


            List<Person> list = new List<Person>();
            new Person("Salim", 22, "Male", "sohar");
            new Person("Salim", 23, "Male", "sohar");
            new Person("Salim", 25, "Male", "sohar");
            new Person("Ali", 20, "Male", "muscat");
            new Person("Shagufta", 25, "Female", "muscat");
            new Person("Aliya", 19, "Female", "sohar");
            new Person("Fariha", 30, "Female", "muscat");
            new Person("Farzna", 35, "Female", "salalah");
            new Person("Muqeet", 20, "Male", "sohar");
            new Person("Sehar", 18, "Female", "muscat");


            //List<String> Name = list
            //    .Where(x => x.Age <= 25)
            //    .OrderBy(x => x.Name)
            //    .Select(x => x.Name)
            //    .ToList();

     
            //foreach(String name in Name)
            //{
            //    Console.WriteLine(name);
            //}
            //Person person = list.FirstOrDefault(x => x.Address == "sohar");
            //if (person == null)
            //{
            //    Console.WriteLine(person.Name);
            //}

            Person? person = list.FirstOrDefault(x => x.Address == "Karachi");
            //if (person == null)
            //{
            //    Console.WriteLine(person.Name);
            //}
            //Console.WriteLine(person?.Name);
            Console.WriteLine(person?.Name?? "hello");


        }



        public List<Person> getByAge (int age, List<Person> persons)
        {
            List<Person> agePersons = new List<Person>();
            foreach (Person person in persons)
           
            if(person.Age > age)
            {
                agePersons.Add(person);
            }
            return agePersons;

        }
        static void printPersonList (List<Person> persons)
        {
            foreach (Person person in persons)
            {
                Console.WriteLine(person.Name);
            }
        }

        public delegate int MathOperation(int a, int b);
        static int Add(int a, int b) => a + b;
        static int multiply(int a, int b) => a * b;
        static void abc() { }
    }
}