using System.Collections.Generic;
using SOLID.Entities;

namespace SOLID.Repositories
{
    public interface IStaffRepository
    {
        IEnumerable<IStaff> GetStaffs();
        IStaff GetStaff(int id);
        void CreateStaff(IStaff staff);
        void UpdateStaff(IStaff staff);
        void DeleteStaff(int id);
    }
}