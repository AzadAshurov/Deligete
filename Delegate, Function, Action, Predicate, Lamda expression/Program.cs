namespace Delegate__Function__Action__Predicate__Lamda_expression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>
            {
                new Person("Falseman", "Tadjikov", 60),
                  new Person("Truman", "Uzbekstan", 40),
                    new Person("Nullman", "Kirgizova", 20),
                     new Person("Falseman", "Tocikov", 80),


            };
            List<Person> findPeople = people.FindAll(person => person.Name == "Falseman");
            findPeople.ForEach(person => Console.WriteLine(person));
            Console.WriteLine("--------------------------------------------------------");
            List<Person> findPeopleOv = people.FindAll(person => person.Surname.Length >= 2 && ((person.Surname[person.Surname.Length - 1] == 'v' && person.Surname[person.Surname.Length - 2] == 'o') || (person.Surname.Length >= 3 && person.Surname[person.Surname.Length - 1] == 'a' && person.Surname[person.Surname.Length - 2] == 'v' && person.Surname[person.Surname.Length - 3] == 'o')));
            findPeopleOv.ForEach(person => Console.WriteLine(person));
            Console.WriteLine("--------------------------------------------------------");
            List<Person> findPeopleAge = people.FindAll(person => person.Age > 20);
            findPeopleAge.ForEach(person => Console.WriteLine(person));
            Console.WriteLine("--------------------------------------------------------");



            List<Exam> exams = new List<Exam>
            {

                new Exam("Math", TimeSpan.FromHours(1), DateTime.UtcNow.AddDays(3)),
                new Exam("Physics", TimeSpan.FromHours(1.5), DateTime.UtcNow.AddDays(2)),
                new Exam("Chemestry", TimeSpan.FromHours(3), DateTime.UtcNow.AddDays(5)),
                new Exam("Biology", TimeSpan.FromHours(5), DateTime.UtcNow.AddDays(-1)),

            };
            List<Exam> recentExams = exams.FindAll(e => e.StartDate >= DateTime.UtcNow.AddDays(-7));
            recentExams.ForEach(exam => Console.WriteLine(exam));
            Console.WriteLine("--------------------------------------------------------");
            List<Exam> longExams = exams.FindAll(e => e.ExamDuration.TotalHours > 2);
            longExams.ForEach(exam => Console.WriteLine(exam));
            Console.WriteLine("--------------------------------------------------------");
            List<Exam> currentExams = exams.FindAll(e => e.StartDate <= DateTime.UtcNow);
            currentExams.ForEach(exam => Console.WriteLine(exam));
        }

    }
}
