using Domain.Entities;
using Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class StudentService : IStudentService
    {
        private readonly IRepository<Student> _studentRepository;

        public StudentService(IRepository<Student> studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public async Task<Student> GetStudentByIdAsync(int studentId)
        {
            return await _studentRepository.GetAsync(studentId);
        }

        public async Task AddStudentAsync(Student student)
        {
            if (student == null)
            {
                throw new ArgumentNullException(nameof(student));
            }

            await _studentRepository.AddAsync(student);
        }

        public async Task UpdateStudentAsync(Student student)
        {
            if (student == null)
            {
                throw new ArgumentNullException(nameof(student));
            }

            await _studentRepository.UpdateAsync(student);
        }

        public async Task DeleteStudentAsync(int studentId)
        {
            var student = await _studentRepository.GetAsync(studentId);

            if (student == null)
            {
                throw new ArgumentException(nameof(studentId));
            }

            await _studentRepository.DeleteAsync(student);
        }

        public Task<IEnumerable<Student>> GetAllStudentsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Student> CreateStudentAsync(Student student)
        {
            throw new NotImplementedException();
        }

        Task<Student> IStudentService.UpdateStudentAsync(Student student)
        {
            throw new NotImplementedException();
        }
    }
}
