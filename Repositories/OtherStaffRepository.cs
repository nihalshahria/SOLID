using SOLID.Entities;

namespace SOLID.Repositories
{
    public class OtherStaffRepository : IOtherStaffRepository
    {
        private readonly List<IOtherStaff> otherStaffs = new();

        public IEnumerable<IOtherStaff> GetOtherStaffs()
        {
            return otherStaffs;
        }

        public IOtherStaff GetOtherStaff(int id)
        {
            return otherStaffs.Where(staff => staff.Id == id).SingleOrDefault();
        }

        public void CreateOtherStaff(IOtherStaff otherStaff)
        {
            otherStaffs.Add(otherStaff);
        }

        public void UpdateOtherStaff(IOtherStaff otherStaff)
        {
            var index = otherStaffs.FindIndex(x => x.Id == otherStaff.Id);
            otherStaffs[index] = otherStaff;
        }

        public void DeleteOtherStaff(int id)
        {
            var index = otherStaffs.FindIndex(d => d.Id == id);
            otherStaffs.RemoveAt(index);
        }
    }
    
}