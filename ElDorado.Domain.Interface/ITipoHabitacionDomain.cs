using ElDorado.Data.Acces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElDorado.Domain.Interface
{
    public interface ITipoHabitacionDomain
    {
        IEnumerable<Tipo_habitacion> GetTipo_Habitacions(string nombre);
        Tipo_habitacion GetTipoHabitacionById(int id);
        bool SaveTipoHabitacion(Tipo_habitacion entity);
        bool DeleteTipoHabitacion(int id);
    }
}
