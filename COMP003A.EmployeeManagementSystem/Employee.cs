namespace COMP003A.EmployeeManagementSystem
{
    /// <summary>
    /// This will gather and later show the employee information
    /// </summary>
    public class Employee
    {
        // Fields
        private readonly string _employeeId;
        private string _firstName;
        private string _middleName;
        private string _lastName;
        private double _salary;

        // Properties
        /// <summary>
        /// Gets the employee id 
        /// </summary>
        public string EmployeeId
        {
            get { return _employeeId; }
        }
        /// <summary>
        /// Gets the first name ensuring that its not blank
        /// </summary>
        public string FirstName
        {
            get { return _firstName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("First name cannot be empty or null.");
                }
                _firstName = value;
            }
        }
        /// <summary>
        /// Gets the middle name making it okay to be blank
        /// </summary>
        public string MiddleName
        {
            get { return _middleName; }
            set
            {
                _middleName = value ?? string.Empty;
            }
        }
        /// <summary>
        /// Gets the last name ensuring it cant be blank
        /// </summary>
        public string LastName
        {
            get { return _lastName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Last name cannot be empty or null.");
                }
                _lastName = value;
            }
        }
        /// <summary>
        /// gettingf the salary ensuring it cant be negative 
        /// </summary>
        public double Salary
        {
            get { return _salary; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Salary cannot be less than 0.");
                }
                _salary = value;
            }
        }

        // Constructor
        /// <summary>
        /// Setting some variables
        /// </summary>
        /// <param name="employeeId">ID</param>
        /// <param name="firstName">firstname</param>
        /// <param name="middleName">middle name</param>
        /// <param name="lastName">lastname</param>
        /// <param name="salary">money</param>
        public Employee(string employeeId, string firstName, string middleName, string lastName, double salary)
        {
            _employeeId = employeeId;
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            Salary = salary;
        }

        /// <summary>
        /// Prints the full name in the format: FirstName MiddleName LastName
        /// If MiddleName is empty, prints just the first and last names
        /// </summary>
        public void PrintFullName()
        {
            if (string.IsNullOrEmpty(MiddleName))
            {
                Console.WriteLine($"{FirstName} {LastName}");
            }
            else
            {
                Console.WriteLine($"{FirstName} {MiddleName} {LastName}");
            }
        }

        /// <summary>
        /// Displays the employee details, including the full name and salary. Ensures it calls PrintFullName()
        /// </summary>
        public void DisplayEmployeeInfo()
        {
            Console.WriteLine($"Employee ID: {EmployeeId}");
            PrintFullName();
            Console.WriteLine($"Salary: ${Salary}");
        }
    }
}
