namespace LinqAgregateProject
{
    class Person
    {
        public string? Name { get; set; }
        public int Age { set; get; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>
            {
                new Person{ Name = "Bob", Age = 24 },
                new Person{ Name = "Tommy", Age = 33 },
                new Person{ Name = "Sam", Age = 17 },
                new Person{ Name = "Mike", Age = 42 },
                new Person{ Name = "Susan", Age = 25 },
                new Person{ Name = "Tim", Age = 24 },
                new Person{ Name = "Phill", Age = 17 },
                new Person{ Name = "Anna", Age = 25 },
            };

            var query1 = persons.Where(p => p.Age < 30);
            int count = persons.Where(p => p.Age < 30).Count();
            Console.WriteLine(count);
            foreach (var p in query1)
                Console.WriteLine($"{p.Name} {p.Age}");
            Console.WriteLine(new String('-', 10));

            int sum = persons.Sum(p => p.Age);
            Console.WriteLine(sum);

            double avg = persons.Average(p => p.Age);
            Console.WriteLine(avg);

            int min = persons.Min(p => p.Age);
            Console.WriteLine(min);

            int max = persons.Max(p => p.Age);
            Console.WriteLine(max);

            int[] array = { 1, 2, 3, 4, 5, 6 };
            //int sumSqr = array.Aggregate(0, (x, y) => x + y * y);

            int sumSqr = persons.Aggregate((x, y) => new Person { Age = x.Age + y.Age * y.Age }).Age;
            Console.WriteLine(sumSqr);
        }
    }
}