using ElDorado.Data.Acces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElDorado.Domain.Interface
{
    public interface IEstadoHabitacionDomain
    {
        IEnumerable<Estado_habitacion> GetEstado_Habitacion(string nombre);
        Estado_habitacion GetEstadoHabitacionById(int id);
        bool SaveEstadoHabitacion(Estado_habitacion entity);
        bool DeleteEstadoHabitacion(int id);
    }
}
