namespace COMP003A.EmployeeManagementSystem;

public class HRDepartment : Department, IDepartmentOperations
{
     public HRDepartment() : base("Human Resources") { } 
     /// <summary>
     /// Just displying info
     /// </summary>
     /// <returns> a displaying message </returns>
     /// Overrise is replacing
    public override string GetDepartmentDetails() 
    { return "Handles employee relations and recruitment."; } 
    public void Operate() 
    { Console.WriteLine("Performing HR operations..."); }
}

//Notes
//This one inherits info