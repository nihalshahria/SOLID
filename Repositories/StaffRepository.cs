using System.Collections.Generic;
using SOLID.Entities;

namespace SOLID.Repositories
{
    public class StaffRepository : IStaffRepository
    {
        private readonly List<IStaff> staffs = new();

        public IEnumerable<IStaff> GetStaffs()
        {
            return staffs;
        }

        public IStaff GetStaff(int id)
        {
            return staffs.Where(staff => staff.Id == id).SingleOrDefault();
        }

        public void CreateStaff(IStaff staff)
        {
            staffs.Add(staff);
        }

        public void UpdateStaff(IStaff staff)
        {
            var index = staffs.FindIndex(s => s.Id == staff.Id);
            staffs[index] = staff;
        }

        public void DeleteStaff(int id)
        {
            var index = staffs.FindIndex(s => s.Id == id);
            staffs.RemoveAt(index);
        }
    } 
}