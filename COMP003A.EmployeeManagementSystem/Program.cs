namespace COMP003A.EmployeeManagementSystem;
// Author: Raymond
// Course: COMP-003A
// Faculty: Jonathan Cruz
// Purpose: Employee management system demonstrating OOP principles in C#
class Program
{

    static void Main(string[] args)
    {
        //User adding names
        Console.WriteLine("Let's create an employee account ");
        Console.Write("PLEASE enter the employee's ID: ");
        string employeeId = Console.ReadLine();
        //Console.Write("Enter First Name: ");
        // An if statement to not allow blank in first name
        string firstName;
        while (true)
        {
            Console.Write("Enter First Name: ");
            firstName = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(firstName))
            {
                break;
            }
            Console.WriteLine("You need a first name ");
            
        }
        Console.Write("Enter Middle Name (Press Enter to skip): ");
        string middleName = Console.ReadLine();
        // An if statement to not allow blank in last name
        
        string lastName;
        while (true)
        {
            Console.Write("Enter Last Name: ");
            lastName = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(lastName))
            {
                break;
            }
            Console.WriteLine("You need a last name.");
        }
        //Adding Salary but it can't be negative
        
        double salary;
        while (true)
        {
            Console.WriteLine("Note: Please enter a valid number, salary must be a positive number.");
            Console.Write("Enter Salary: ");
            
            if (double.TryParse(Console.ReadLine(), out salary) && salary >= 0)
            {
                
                break;
            }
            Console.WriteLine("Negative number not acceptable.");
        }
        /// <summery
        /// This will print out all the saved data from the classes
        /// </summery
       
            Employee employee = new Employee(employeeId, firstName, middleName, lastName, salary);
        
            Console.WriteLine("\nYou've created an employee");
            
            employee.DisplayEmployeeInfo();

            HRDepartment hrDepartment = new HRDepartment();
            ITDepartment itDepartment = new ITDepartment();

            Console.WriteLine("\nDepartment Information:");
            hrDepartment.DisplayDepartmentInfo();
            hrDepartment.Operate();

            itDepartment.DisplayDepartmentInfo();
            itDepartment.Operate();
        
        
    }

    
}