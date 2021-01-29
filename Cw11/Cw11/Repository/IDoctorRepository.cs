using System.Collections.Generic;
using System.Threading.Tasks;
using Cw11.Dto;
using Cw11.Models;

namespace Cw11.Repository
{
    public interface IDoctorRepository
    {
        Task<IList<Doctor>> GetAll();
        Task Create(DoctorEditDto doctor);
        Task Update(int id, DoctorEditDto doctor);
        Task Remove(int id);
    }
}
