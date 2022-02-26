namespace SOLID.Entities
{
    public class OtherStaff: IOtherStaff
    {
        public int Id { get; }
        public String Name { get; }
        public String Email { get; }
        public String PhoneNo { get; }
        public int Salary { get; }
        public int workHours { get; }

        public OtherStaff(int id, String name, String email, String phoneNo, int salary, int workHours)
        {
            Id = id;
            Name = name;
            Email = email;
            PhoneNo = phoneNo;
            Salary = salary;
            this.workHours = workHours;
        }

        public void Attendance()
        {
            Console.WriteLine("{0} is present", Name);
        }

        public void Work()
        {
            for (int i = 0; i < workHours; i++)
            {
                Console.WriteLine("{0} is working", Name);
            }
        }
    }
}