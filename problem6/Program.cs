  public class Student
{
    public Student(string v1, int v2)
    {
        V1 = v1;
        V2 = v2;
    }

    public string name { get; set; }
    public int age { get; set; }
    public string V1 { get; }
    public int V2 { get; }

    public void student(string Name, int Age)
    {
        Name = name;
        Age = age;
    }
    public void get()
    {
        Console.WriteLine("name : {0} ", name);
        Console.WriteLine("age : {0} ", age);
    }
}
class Program
{
    static void Main(string[] args)
    {
        Student student1 = new("mohamed", 20);
        student1.get();
        Console.ReadLine();

    }
    
}





