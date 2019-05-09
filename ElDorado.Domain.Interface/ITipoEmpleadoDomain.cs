using ElDorado.Data.Acces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElDorado.Domain.Interface
{
    public interface ITipoEmpleadoDomain
    {
        IEnumerable<Tipo_empleado> GetTipo_Empleados(string nombre);
        Tipo_empleado GetTipoEmpleadoById(int id);
        bool SaveTipoEmpleado(Tipo_empleado entity);
        bool DeleteTipoEmpleado(int id);
    }
}
