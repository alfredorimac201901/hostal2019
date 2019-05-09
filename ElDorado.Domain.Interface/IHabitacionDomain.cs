using ElDorado.Data.Acces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElDorado.Domain.Interface
{
    public interface IHabitacionDomain
    {
        IEnumerable<Habitacion> GetHabitacion(string nombre);
        Habitacion GetHabitacionById(int id);
        bool SaveHabitacion(Habitacion entity);
        bool DeleteHabitacion(int id);

    }
}