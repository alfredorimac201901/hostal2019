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
        public IEnumerable<Tipo_empleado> GetTipo_EmpleadoAll(string nombre)
        {
            ITipoEmpleadoDomain domain = new TipoEmpleadoDomain();
            return domain.GetTipo_Empleados(nombre);
        }

        public Tipo_empleado GetTipo_Empleado(int id)
        {
            ITipoEmpleadoDomain domain = new TipoEmpleadoDomain();
            return domain.GetTipoEmpleadoById(id);
        }
        public bool SaveTipoEmpleado(Tipo_empleado entity)
        {
            ITipoEmpleadoDomain domain = new TipoEmpleadoDomain();
            return domain.SaveTipoEmpleado(entity);
        }
        public bool DeleteTipoEmpleado(int id)
        {
            ITipoEmpleadoDomain domain = new TipoEmpleadoDomain();
            return domain.DeleteTipoEmpleado(id);
        }

    }
}
