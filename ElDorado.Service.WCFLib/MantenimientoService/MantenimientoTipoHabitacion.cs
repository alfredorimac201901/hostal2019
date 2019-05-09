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
       public IEnumerable<Tipo_habitacion> GetTipo_HabitacionAll(string nombre)
        {
            ITipoHabitacionDomain domain = new TipoHabitacionDomain();
            return domain.GetTipo_Habitacions(nombre);
        }
        public Tipo_habitacion GetTipo_Habitacion(int id)
        {
            ITipoHabitacionDomain domain = new TipoHabitacionDomain();
            return domain.GetTipoHabitacionById(id);
        }
        public bool SaveTipoHabitacion(Tipo_habitacion entity)
        {
            ITipoHabitacionDomain domain = new TipoHabitacionDomain();
            return domain.SaveTipoHabitacion(entity);
        }
        public bool DeleteTipoHabitacion(int id)
        {
            ITipoHabitacionDomain domain = new TipoHabitacionDomain();
            return domain.DeleteTipoHabitacion(id);
        }

    }
}
