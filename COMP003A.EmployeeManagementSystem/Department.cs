namespace COMP003A.EmployeeManagementSystem;

/// <summary>
/// Department stuff
/// </summary>
    public abstract class Department
    {
    /// <summary>
    /// Department name is got
    /// </summary>
        public string DepartmentName { get; set; }

        public Department(string name)
        {
            DepartmentName = name;
        }
        //Just displays data, both of them below
        /// <summary>
        /// Uses data saved in HRDepartmnet to then print out
        /// </summary>
        
        public abstract string GetDepartmentDetails();
        
        /// <summary>
        /// Uses details saved in the departmen
        /// </summary>
        public void DisplayDepartmentInfo()
        {
            Console.WriteLine($"Department Name: {DepartmentName}");
            Console.WriteLine($"Details: {GetDepartmentDetails()}");
        }
    }
