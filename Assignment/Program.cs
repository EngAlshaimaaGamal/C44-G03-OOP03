namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        { //        public Employee(int iD, string? name, SecurityLevel securityLevel, double salary, Gender gender, HiringDate? hiringDate)

            Employee[] EmpArr = new Employee[3];

            EmpArr[0] = new Employee(1, "Ali", SecurityLevel.DBA, 10000, Gender.M, new HiringDate(1, 1, 2020));
            EmpArr[1] = new Employee(2, "Sara", SecurityLevel.Guest, 4000, Gender.F, new HiringDate(15, 5, 2022));
            EmpArr[2] = new Employee(3, "Kareem", SecurityLevel.Developer, 8000, Gender.M, new HiringDate(10, 3, 2021) );

            foreach (var emp in EmpArr)
            {
                Console.WriteLine(emp);
            }




        }
    }
}
