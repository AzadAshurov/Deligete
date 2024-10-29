namespace Delegate__Function__Action__Predicate__Lamda_expression
{
    public class Person
    {

        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        public Person(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }
        public override string ToString()
        {
            return $"{Name} {Surname},Age: {Age}";
        }
    }
}
