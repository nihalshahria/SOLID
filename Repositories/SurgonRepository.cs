using SOLID.Entities;

namespace SOLID.Repositories
{
    public class SurgonRepository : ISurgonRepository
    {
        private readonly List<ISurgon> surgons = new();
        public IEnumerable<ISurgon> GetSurgons()
        {
            return surgons;
        }
        public ISurgon GetSurgon(int id)
        {
            return surgons.Where(surgon => surgon.Id == id).SingleOrDefault();
        }
        public void CreateSurgon(ISurgon surgon)
        {
            surgons.Add(surgon);
        }
        public void UpdateSurgon(ISurgon surgon)
        {
            var index = surgons.FindIndex(s => s.Id == surgon.Id);
            surgons[index] = surgon;
        }
        public void DeleteSurgon(int id)
        {
            var index = surgons.FindIndex(s => s.Id == id);
            surgons.RemoveAt(index);
        }
        public void WorkingStatus(int id)
        {
            var index = surgons.FindIndex(s => s.Id == id);
            surgons[index].Work();
        }
    }
    
}