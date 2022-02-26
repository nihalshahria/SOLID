using System.Collections.Generic;
using SOLID.Entities;

namespace SOLID.Repositories
{
    public interface IOtherStaffRepository
    {
        IEnumerable<IOtherStaff> GetOtherStaffs();
        IOtherStaff GetOtherStaff(int id);
        void CreateOtherStaff(IOtherStaff otherStaff);
        void UpdateOtherStaff(IOtherStaff otherStaff);
        void DeleteOtherStaff(int id);
    }    
}