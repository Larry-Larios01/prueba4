using Sistematico.Domain.Entities;
using Sistematico.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repositories
{
    public class EFStudent : IStudentRepository
    {
        IDBContext dBContext;

        public EFStudent(IDBContext dBContext)
        {
            this.dBContext = dBContext;
        }

        public double claculateaverage(Estudiante est)
        {
            var promedio = est.Contabilidad + est.Estadistica + est.Matematica + est.Programacion / 4;
            return promedio;

        }

        public void Create(Estudiante t)
        {
            if (t == null)
            {
                throw new ArgumentException("El objeto employee no puede ser nulo");
            }
            else
            {
                dBContext.Estudiantes.Add(t);
                dBContext.SaveChanges();
            }
        }

        public bool Delete(Estudiante t)
        {
            if (t == null)
            {
                throw new ArgumentException("El objeto employee no puede ser nulo");
            }
            else
            {
                dBContext.Estudiantes.Add(t);
               int result = dBContext.SaveChanges();
                return result > 0;
            }
            
        }

        public Estudiante findbyid(int id)
        {
            return dBContext.Estudiantes.FirstOrDefault(x => x.Id == id);
        }

        public List<Estudiante> GetAll()
        {
            return dBContext.Estudiantes.ToList();
        }

        public int Update(Estudiante t)
        {
            if (t == null)
            {
                throw new NullReferenceException("no puede ser null");
            }
            Estudiante estudiante = findbyid(t.Id);
            if (estudiante == null)
            {
                throw new Exception("no existe el objeto que quiere actualizar");
            }
            estudiante = t;
            dBContext.Estudiantes.Update(estudiante);
            return dBContext.SaveChanges();
        }
    }
}
