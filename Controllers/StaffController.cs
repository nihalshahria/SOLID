using SOLID.Entities;
using SOLID.Repositories;

namespace SOLID.Controllers
{
    public class StaffController
    {
        private readonly IStaffRepository _staffRepository;

        public StaffController(IStaffRepository staffRepository)
        {
            _staffRepository = staffRepository;
        }

        public void Index()
        {
            var staffs = _staffRepository.GetStaffs();
            foreach (var staff in staffs)
            {
                Console.WriteLine("Id: " + staff.Id);
                Console.WriteLine("Name: " + staff.Name);
                Console.WriteLine("Email: " + staff.Email);
                Console.WriteLine("Phone no: " + staff.PhoneNo);
                Console.WriteLine("Salary: " + staff.Salary);
                Console.WriteLine("---------------------------------");
            }
        }

        public void Create(IStaff staff)
        {
            _staffRepository.CreateStaff(staff);
        }

        public void Edit(IStaff staff)
        {
            _staffRepository.UpdateStaff(staff);
        }

        public void Delete(int id)
        {
            _staffRepository.DeleteStaff(id);
        }
    } 
}