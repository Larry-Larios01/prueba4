using Sistematico.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistematico.Domain.Interfaces
{
    public interface IStudentRepository: IModel<Estudiante>
    {
        Estudiante findbyid(int id);
        double claculateaverage(Estudiante est);

    }
}
