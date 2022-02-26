using SOLID.Entities;

namespace SOLID.Repositories
{
    public class DoctorRepository: IDoctorRepository
    {
        private readonly List<IDoctor> doctors = new();

        public IEnumerable<IDoctor> GetDoctors()
        {
            return doctors;
        }

        public IDoctor GetDoctor(int id)
        {
            return doctors.Where(doctor => doctor.Id == id).SingleOrDefault();
        }

        public void CreateDoctor(IDoctor doctor)
        {
            doctors.Add(doctor);
        }

        public void UpdateDoctor(IDoctor doctor)
        {
            var index = doctors.FindIndex(d => d.Id == doctor.Id);
            doctors[index] = doctor;
        }

        public void DeleteDoctor(int id)
        {
            var index = doctors.FindIndex(d => d.Id == id);
            doctors.RemoveAt(index);
        }

        public void WorkingStatus(int id)
        {
            var index = doctors.FindIndex(d => d.Id == id);
            doctors[index].Work();
        }
    }

}