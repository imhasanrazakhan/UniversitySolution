using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    internal class StudentRepository : IStudentRepository
    {
        Task IRepository<Student>.AddAsync(Student entity)
        {
            throw new NotImplementedException();
        }

        Task IRepository<Student>.DeleteAsync(Student entity)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<Student>> IRepository<Student>.GetAllAsync()
        {
            throw new NotImplementedException();
        }

        Task<Student> IRepository<Student>.GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        Task IRepository<Student>.UpdateAsync(Student entity)
        {
            throw new NotImplementedException();
        }
    }
}
