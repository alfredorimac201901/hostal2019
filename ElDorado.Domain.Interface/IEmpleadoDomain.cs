using ElDorado.Data.Acces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElDorado.Domain.Interface
{
    public interface IEmpleadoDomain
    {
        IEnumerable<Empleado> GetEmpleado(string nombre);
        Empleado GetEmpleadoById(int id);
        bool SaveEmpleado(Empleado entity);
        bool DeleteEmpleado(int id);

    }
}
