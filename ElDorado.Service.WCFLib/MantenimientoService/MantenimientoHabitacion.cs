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
         public IEnumerable<Habitacion> GetHabitacionAll(string nombre)
        {
            IHabitacionDomain domain = new HabitacionDomain();
            return domain.GetHabitacion(nombre);
        }
        public Habitacion GetHabitacion(int id)
        {
            IHabitacionDomain domain = new HabitacionDomain();
            return domain.GetHabitacionById(id);
        }
        public bool SaveHabitacion(Habitacion entity)
        {
            IHabitacionDomain domain = new HabitacionDomain();
            return domain.SaveHabitacion(entity);
        }
        public bool DeleteHabitacion(int id)
        {
            IHabitacionDomain domain = new HabitacionDomain();
            return domain.DeleteHabitacion(id);
        }

    }
}
