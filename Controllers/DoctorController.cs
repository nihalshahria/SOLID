using SOLID.Entities;
using SOLID.Repositories;

namespace SOLID.Controllers
{
    public class DoctorController
    {
        private readonly IDoctorRepository _doctorRepository;
        private readonly StaffController _staffController;

        public DoctorController(IDoctorRepository doctorRepository, StaffController staffController)
        {
            _doctorRepository = doctorRepository;
            _staffController = staffController;
        }

        public void Index()
        {
            var doctors = _doctorRepository.GetDoctors();
            foreach (var doctor in doctors)
            {
                Console.WriteLine("Id: " + doctor.Id);
                Console.WriteLine("Name: " + doctor.Name);
                Console.WriteLine("Email: " + doctor.Email);
                Console.WriteLine("Phone no: " + doctor.PhoneNo);
                // Console.WriteLine("Salary: " + doctor.Salary);
                Console.WriteLine("Specialization: " + doctor.Specialization);
                Console.WriteLine("---------------------------------");
            }
        }
        public void Create(IDoctor doctor)
        {
            _doctorRepository.CreateDoctor(doctor);
            // IStaff staff = new Doctor(doctor.Id, doctor.Name, doctor.Email, doctor.PhoneNo, doctor.Salary, doctor.Specialization);
            // _staffRepository.CreateStaff(doctor);
            _staffController.Create(doctor);
        }

        public void Edit(IDoctor doctor)
        {
            _doctorRepository.UpdateDoctor(doctor);
            _staffController.Edit(doctor);
        }

        public void Delete(int id)
        {
            _doctorRepository.DeleteDoctor(id);
            _staffController.Delete(id);
        }

        public void WorkingStatus(int id)
        {
            _doctorRepository.WorkingStatus(id);
        }
        
    }
    
}