namespace COMP003A.EmployeeManagementSystem;

/// <summary>
/// IT departent getting representation
/// </summary>
public class ITDepartment : Department, IDepartmentOperations
{
    /// <summary>
    /// Initalizes a new instance of ITDepartment class
    /// </summary>
    public ITDepartment() : base("IT")
    {
    }
/// <summary>
/// Just displays department details
/// Ensures it operates via this interface of IDepartmentOperations
/// </summary>

    public override string GetDepartmentDetails()
    {
        return "Manages technical resources and infrastructure.";
    }
/// <summary>
/// Ensures it operates via this interface of IDepartmentOperations
/// </summary>
    public void Operate()
    {
        Console.WriteLine("Performing IT operations...");
    }
}
