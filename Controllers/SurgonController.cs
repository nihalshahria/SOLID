using SOLID.Entities;
using SOLID.Repositories;

namespace SOLID.Controllers
{
    public class SurgonController
    {
        private readonly ISurgonRepository _surgonRepository;
        private readonly DoctorController _doctorController;

        public SurgonController(ISurgonRepository surgonRepository, DoctorController doctorController)
        {
            _surgonRepository = surgonRepository;
            _doctorController = doctorController;
        }

        public void Index()
        {
            var surgons = _surgonRepository.GetSurgons();
            foreach (var surgon in surgons)
            {
                Console.WriteLine("Id: " + surgon.Id);
                Console.WriteLine("Name: " + surgon.Name);
                Console.WriteLine("Email: " + surgon.Email);
                Console.WriteLine("Phone no: " + surgon.PhoneNo);
                Console.WriteLine("Specialization: " + surgon.Specialization);
                Console.WriteLine("---------------------------------");
            }
        }

        public void Create(ISurgon surgon)
        {
            _surgonRepository.CreateSurgon(surgon);
            _doctorController.Create(surgon);
        }

        public void Edit(ISurgon surgon)
        {
            _surgonRepository.UpdateSurgon(surgon);
            _doctorController.Edit(surgon);
        }

        public void Delete(int id)
        {
            _surgonRepository.DeleteSurgon(id);
            _doctorController.Delete(id);
        }
        public void WorkingStatus(int id)
        {
            _surgonRepository.WorkingStatus(id);
        }
    }
    
}