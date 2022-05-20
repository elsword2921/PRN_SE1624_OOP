// lap trinh tao ra cac list employee
namespace Prn.Se1624;

public class Program
{
    static void Main(String[] args)
    {
        //1. create a object(instance)
        Employee e = new Employee();
        e.Id = 1;
        e.Name = "Nguyen Quoc Khanh";
        e.Level = "Junior";
        e.Salary = 5000;
        e.Dob = new DateOnly();
        e.ToString();
        Console.WriteLine(e);
        //create a list emplotee and filter and display to console
        Console.WriteLine(e.ToString());
        Console.ReadLine();
    }
}
