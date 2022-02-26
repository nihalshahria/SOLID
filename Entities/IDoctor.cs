using System;

namespace SOLID.Entities
{
    public interface IDoctor: IStaff
    {
        String Specialization { get; }
        void ConductAppointment();
    }
}