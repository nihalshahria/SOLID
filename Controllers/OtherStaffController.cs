using SOLID.Entities;
using SOLID.Repositories;

namespace SOLID.Controllers
{
    public class OtherStaffController
    {
        private readonly IOtherStaffRepository _otherStaffRepository;
        private readonly StaffController _staffController;
        public OtherStaffController(IOtherStaffRepository otherStaffRepository, StaffController staffController)
        {
            _otherStaffRepository = otherStaffRepository;
            _staffController = staffController;
        }
        public void Index()
        {
            var otherStaffs = _otherStaffRepository.GetOtherStaffs();
            foreach (var otherStaff in otherStaffs)
            {
                Console.WriteLine("Id: " + otherStaff.Id);
                Console.WriteLine("Name: " + otherStaff.Name);
                Console.WriteLine("Email: " + otherStaff.Email);
                Console.WriteLine("Phone no: " + otherStaff.PhoneNo);
                Console.WriteLine("WorkHours: " + otherStaff.workHours);
                Console.WriteLine("---------------------------------");
            }
        }
        public void Create(IOtherStaff otherStaff)
        {
            _otherStaffRepository.CreateOtherStaff(otherStaff);
            _staffController.Create(otherStaff);
        }
        public void Edit(IOtherStaff otherStaff)
        {
            _otherStaffRepository.UpdateOtherStaff(otherStaff);
            _staffController.Edit(otherStaff);
        }
        public void Delete(int id)
        {
            _otherStaffRepository.DeleteOtherStaff(id);
            _staffController.Delete(id);
        }
    }    
}