namespace SOLID.Entities
{
    public class Surgon: ISurgon
    {
        public int Id { get; }
        public String Name { get; }
        public String Email { get; }
        public String PhoneNo { get; }
        public int Salary { get; }
        public String Specialization { get; }

        public Surgon(int id, String name, String email, String phoneNo, int salary, String specialization )
        {
            Id = id;
            Name = name;
            Email = email;
            PhoneNo = phoneNo;
            Salary = salary;
            Specialization = specialization;
        }
        public void Attendance()
        {
            Console.WriteLine("{0} is present", Name);
        }

        public void ConductAppointment()
        {
            Console.WriteLine("{0} conducts appointment", Name);
        }

        public void ConductSurgery()
        {
            Console.WriteLine("{0} conducts surgery", Name);
        }

        public void Work()
        {
            ConductAppointment();
            ConductSurgery();
        }
    }
}