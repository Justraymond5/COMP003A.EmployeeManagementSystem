namespace COMP003A.EmployeeManagementSystem;

public class Employee
{
    //Fields
    private string _employeeId;
    private string _firstName;
    private int _middleName;
    private int _lastName;
    private double _salary;
    
    //Properties
    public string EmployeeId
    {
        //Only read "get" info
        get { }
    }
    public string FirstName
    {
        //Need to get validation to ensure they are not empty or null.
        //The hint: string.IsNullOrWhiteSpace()
        get { }
        set { }
    }
    public int MiddleName
    {   //Need it to allow it to be an empty string but not null. Default to an empty string if no value is provided.
        get { }
        set { }
    }
    public  int LastName
    {
        //Need to get validation to ensure they are not empty or null.
        //The hint: string.IsNullOrWhiteSpace()
        get { }
        set { }
    }
    public double Salary
    {   // Use get and set accessors with validation to ensure the value is not less than 0.
        get { }
        set { }
    }
}
//Notes Throw 'ArgumentException' for invalid inputs.