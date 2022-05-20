using Services.Interfaces;
using Sistematico.Domain.Entities;
using Sistematico.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class StudentService : IStudentService
    {
        IStudentRepository repository;

        public StudentService(IStudentRepository repository)
        {
            this.repository = repository;
        }

        public double claculateaverage(Estudiante est)
        {
            return repository.claculateaverage(est);
        }

        public void Create(Estudiante t)
        {
            repository.Create(t);
        }

        public bool Delete(Estudiante t)
        {
            return repository.Delete(t);
        }

        public Estudiante findbyid(int id)
        {
            return repository.findbyid(id);
        }

        public List<Estudiante> GetAll()
        {
            return repository.GetAll();
        }

        public int Update(Estudiante t)
        {
            return repository.Update(t);
        }
    }
}
