using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Cw11.Dto;
using Cw11.Models;
using Microsoft.EntityFrameworkCore;

namespace Cw11.Repository
{
    public class DoctorRepository : IDoctorRepository
    {
        private readonly AppDbContext appDbContext;

        public DoctorRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public async Task<IList<Doctor>> GetAll()
        {
            return await appDbContext.Doctors.ToListAsync();
        }

        public async Task Create(DoctorEditDto doctor)
        {
            await appDbContext.AddAsync(new Doctor
            {
                FirstName = doctor.FirstName,
                LastName = doctor.LastName,
                Email = doctor.Email,
            });
            await appDbContext.SaveChangesAsync();
        }

        public async Task Update(int id, DoctorEditDto doctor)
        {
            var firstAsync = await appDbContext.Doctors.FirstOrDefaultAsync(n => n.IdDoctor == id);
            if (firstAsync == null)
                throw new NullReferenceException();

            firstAsync.LastName = doctor.LastName;
            firstAsync.FirstName = doctor.FirstName;
            firstAsync.Email = doctor.Email;

            await appDbContext.SaveChangesAsync();
        }

        public async Task Remove(int id)
        {
            var firstAsync = await appDbContext.Doctors.FirstOrDefaultAsync(n => n.IdDoctor == id);
            if(firstAsync == null)
                throw new NullReferenceException();

            appDbContext.Doctors.Remove(firstAsync);
            await appDbContext.SaveChangesAsync();
        }
    }
}
