using System;

namespace SOLID.Entities
{
    public class Doctor: IDoctor
    {
        public int Id { get; }
        public String Name { get; }
        public String Email { get; }
        public String PhoneNo { get; }
        public int Salary { get; }
        public String Specialization { get; }

        public Doctor(int id, String name, String email, String phoneNo, int salary, String specialization)
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

        public void Work()
        {
            ConductAppointment();
        }
    }
}