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
         public IEnumerable<Empleado> GetEmpleadoAll(string nombre)
        {
            IEmpleadoDomain domain = new EmpleadoDomain();
            return domain.GetEmpleado(nombre);
        }
        public Empleado GetEmpleado(int id)
        {
            IEmpleadoDomain domain = new EmpleadoDomain();
            return domain.GetEmpleadoById(id);
        }
        public bool SaveEmpleado(Empleado entity)
        {
            IEmpleadoDomain domain = new EmpleadoDomain();
            return domain.SaveEmpleado(entity);
        }
        public bool DeleteEmpleado(int id)
        {
            IEmpleadoDomain domain = new EmpleadoDomain();
            return domain.DeleteEmpleado(id);
        }
    }
}
