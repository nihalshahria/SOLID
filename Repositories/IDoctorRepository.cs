using System.Collections.Generic;
using SOLID.Entities;

namespace SOLID.Repositories
{
    public interface IDoctorRepository
    {
        IEnumerable<IDoctor> GetDoctors();
        IDoctor GetDoctor(int id);
        void CreateDoctor(IDoctor doctor);
        void UpdateDoctor(IDoctor doctor);
        void DeleteDoctor(int id);
        void WorkingStatus(int id);
    }
    
}