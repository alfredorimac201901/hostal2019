using ElDorado.Data.Acces;
using ElDorado.Data.Repository;
using ElDorado.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElDorado.Domain
{
    public class TipoEmpleadoDomain : ITipoEmpleadoDomain
    {
        public bool DeleteTipoEmpleado(int id)
        {
            using (var uw = new ElDoradoUnitOfWork())
            {
                return uw.TipoEmpleadoRepository.Remove(new Tipo_empleado { Cod_tip_emp = id });
            }
        }

        public Tipo_empleado GetTipoEmpleadoById(int id)
        {
            using (var uw = new ElDoradoUnitOfWork())
            {
                return uw.TipoEmpleadoRepository.GetById<int>(id);
            }
        }

        public IEnumerable<Tipo_empleado> GetTipo_Empleados(string nombre)
        {
            using (var uw = new ElDoradoUnitOfWork())
            {
                return uw.TipoEmpleadoRepository.GetAll();
            }
        }

        public bool SaveTipoEmpleado(Tipo_empleado entity)
        {
            bool result = false;
            try
            {
                using (var uw = new ElDoradoUnitOfWork())
                {
                    if (entity.Cod_tip_emp == 0)
                    {
                        uw.TipoEmpleadoRepository.Add(entity);
                    }
                    else
                    {
                        uw.TipoEmpleadoRepository.Update(entity);
                    }
                    uw.Complete();
                }
                result = true;
            }
            catch (Exception ex)
            {


            }
            return result;
        }
    }
}
