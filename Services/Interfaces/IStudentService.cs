using Sistematico.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IStudentService : IServices<Estudiante>
    {
        Estudiante findbyid(int id);
        double claculateaverage(Estudiante est);
    }
}
