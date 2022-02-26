namespace SOLID.Entities
{
    public interface IStaff
    {
        int Id { get; }
        String Name { get; }
        String Email { get; }
        String PhoneNo { get; }

        int Salary { get; }
        void Attendance();
        void Work();
    }
}