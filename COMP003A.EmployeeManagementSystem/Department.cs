namespace COMP003A.EmployeeManagementSystem;

/// <summary>
/// Department stuff
/// </summary>
    public abstract class Department
    {
    /// <summary>
    /// department name
    /// </summary>
        public string DepartmentName { get; set; }

        public Department(string name)
        {
            DepartmentName = name;
        }
        /// <summary>
        /// Just displays data, both of them below
        /// </summary>
        
        public abstract string GetDepartmentDetails();
        public void DisplayDepartmentInfo()
        {
            Console.WriteLine($"Department Name: {DepartmentName}");
            Console.WriteLine($"Details: {GetDepartmentDetails()}");
        }
    }
