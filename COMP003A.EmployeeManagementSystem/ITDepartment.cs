namespace COMP003A.EmployeeManagementSystem;


public class ITDepartment : Department, IDepartmentOperations
{
    public ITDepartment() : base("IT")
    {
    }
/// <summary>
/// Just displays department details
/// </summary>
/// <returns></returns>
    public override string GetDepartmentDetails()
    {
        return "Manages technical resources and infrastructure.";
    }

    public void Operate()
    {
        Console.WriteLine("Performing IT operations...");
    }
}
