namespace COMP003A.EmployeeManagementSystem;
/// <summary>
/// This will gather and later show the employee information
/// </summary>
public class Employee
{
    //Fields
    private string _employeeId;
    private string _firstName;
    private string _middleName;
    private string _lastName;
    private double _salary;
    
    //Properties
    public string EmployeeId
    {
        //Only read "get" info
        get { return _employeeId; }
    }
    /// <summary>
    /// Easy pizzy just geting the name when the user imputs
    /// </summary>
    /// <exception cref="ArgumentException">There has to be a name and this will make sure of that</exception>
    public string FirstName
    {
        //Need to get validation to ensure they are not empty or null.
        //The hint: string.IsNullOrWhiteSpace()
        get { return _firstName; }
        set
        {
            if (string.IsNullOrEmpty(value))
                throw new ArgumentException("You must enter first name");
        }
        
    }
    /// <summary>
    /// Gets and sets middle name if given if not then its blank
    /// </summary>
    public string MiddleName
    {   //Need it to allow it to be an empty string but not null. Default to an empty string if no value is provided.
        get {return _middleName; }
        set
        {
            if (value == null)
                _middleName = "";
            else
            {
                _middleName = value;
            }

        }
        //?? "" allows it to be empty
    }
    public  string LastName
    {
        //Need to get validation to ensure they are not empty or null.
        //The hint: string.IsNullOrWhiteSpace()
        get { return _lastName; }
        set
        {
            _lastName = value;
            if (string.IsNullOrEmpty(value))
                throw new ArgumentException("You must enter last name");
        }
    }
    /// <summary>
    /// Gets and sets the money
    /// </summary>
    /// <exception cref="ArgumentException">THe code will bounce if salary is negative</exception>
    public double Salary
    {   // Use get and set accessors with validation to ensure the value is not less than 0.
        get {return _salary; }
        set
        {
            _salary = value;
            if (value < 0)
                throw new ArgumentException("Salary cannot be less than 0.");
        }
    }
/// <summery>
/// Setting some varitables
/// </summery>
/// <param name="employeeId">ID</param>
/// <param name="firstName">firstname</param>
/// <param name="middleName">middle name</param>
/// <param name="lastName">lastname</param>
/// <param name="salary">money</param>
    public Employee(string employeeId, string firstName, string middleName, string lastName, double salary)
    {
        _employeeId = employeeId;
        _firstName = firstName;
        _middleName = middleName;
        _lastName = lastName;
        _salary = salary;
    }

    public void CashMoney()
    {
        Console.WriteLine($"salary: {_salary}");
    }

    public void PrintFullName()
    {
        Console.WriteLine($"{_firstName} + {_middleName} +{_lastName}");
        if (_middleName != "")
        {
            Console.WriteLine($"{_firstName} - {_lastName}");
        }
    }

    public void DisplayEmployeeInfo()
    {
        //Console.WriteLine($"your name is {PrintFullName()} ");
        Console.WriteLine("This is your name:");
        PrintFullName();
        CashMoney();
    }
}
//Notes Throw 'ArgumentException' for invalid inputs.
// ?? "" for null

//Steps I Took
//I created fields and 