using ElDorado.Data.Acces;
using ElDorado.Domain;
using ElDorado.Domain.Interface;
using ElDorado.Service.WCFLib.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElDorado.Service.WCFLib
{
    public partial class MantenimientoService : IMantenimientoService
    {
        public IEnumerable<Estado_habitacion> GetEstado_HabitacionAll(string nombre)
        {
            IEstadoHabitacionDomain domain = new EstadoHabitacionDomain();
            return domain.GetEstado_Habitacion(nombre);
        }
        public Estado_habitacion GetEstado_Habitacion(int id)
        {
            IEstadoHabitacionDomain domain = new EstadoHabitacionDomain();
            return domain.GetEstadoHabitacionById(id);
        }
        public bool SaveEstadoHabitacion(Estado_habitacion entity)
        {
            IEstadoHabitacionDomain domain = new EstadoHabitacionDomain();
            return domain.SaveEstadoHabitacion(entity);
        
    }
        public bool DeleteEstadoHabitacion(int id)
        {
            IEstadoHabitacionDomain domain = new EstadoHabitacionDomain();
            return domain.DeleteEstadoHabitacion(id);
        }
    }
}
