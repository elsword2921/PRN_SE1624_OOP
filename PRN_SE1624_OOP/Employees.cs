namespace Prn.Se1624;
public class Employee
{
    //Define fields-cac data
    private int _id;
    private string _name;
    private DateOnly _dob;

    //Define properties
    public float Salary { get; set; }
    public string Level { get; set; }

    public int Id { get => _id; set => _id = value; }
    public string Name { get => _name; set => _name = value; }
    public DateOnly Dob { get => _dob; set => _dob = value; }

    //Constructors
    public Employee()
    {

    }
    public Employee(int id, string name, DateOnly dob, float salary, string level)
    {
        Id = id;
        Name = name;
        Dob = dob;
        Salary = salary;
        Level = level;
    }
    //manual methods
    public override string? ToString()
    {
        return _getString() ;
    }
    private string _getString()
    {
        return $"[Id = {this._id}], Name = {Name}, Dob = {this._dob}, Level = {Level}, Salary = {Salary}";
    }
}