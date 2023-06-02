namespace inheritclass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Teacher teacher = new Teacher("Niyazi", "Babayev", 25);
            teacher.Explain();
            Student student = new Student("Rufane","Aliyeva", 30);
            student.Learn();

        }
    }
    public class Person 
    {
        public string  Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        public Person(string name,string surname,int age) 
        {
            Name = name;
            Surname = surname;
            Age = age;
        
        }


    }
    public class Teacher :Person
    {
    public Teacher(string name, string surname, int age):base(name,surname, age) { }
        public void Explain() 
        {
            Console.WriteLine("Explaining...");
        }
    
    }
    public class Student :Person
    
    
    {
    public Student(string name,string surname,int age):base(name,surname,age) { }
        public void Learn() { Console.WriteLine("Learning..."); }
    
    }
}