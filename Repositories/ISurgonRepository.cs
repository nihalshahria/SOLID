using System.Collections.Generic;
using SOLID.Entities;

namespace SOLID.Repositories
{
    public interface ISurgonRepository
    {
        IEnumerable<ISurgon> GetSurgons();
        ISurgon GetSurgon(int id);
        void CreateSurgon(ISurgon surgon);
        void UpdateSurgon(ISurgon surgon);
        void DeleteSurgon(int id);
        void WorkingStatus(int id);
    }
}