namespace SOLID.Entities
{
    public class Staff : IStaff
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNo { get; set; }
        public int Salary { get; set; }

        public Staff(int id, string name, string email, string phoneNo, int salary)
        {
            Id = id;
            Name = name;
            Email = email;
            PhoneNo = phoneNo;
            Salary = salary;
        }
        public void Attendance()
        {
            Console.WriteLine("Staff attendance");
        }
        public void Work()
        {
            Console.WriteLine("Staff working");
        }
    }
}