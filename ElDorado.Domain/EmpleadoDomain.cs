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
    public class EmpleadoDomain : IEmpleadoDomain
    {
        public bool DeleteEmpleado(int id)
        {
            using (var uw = new ElDoradoUnitOfWork())
            {
                return uw.EmpleadoRepository.Remove(new Empleado() { Cod_emp = id });
            }
        }

        public IEnumerable<Empleado> GetEmpleado(string nombre)
        {
            using (var uw = new ElDoradoUnitOfWork())
            {
                return uw.EmpleadoRepository.GetAll();
            }
        }

        public Empleado GetEmpleadoById(int id)
        {
            using (var uw = new ElDoradoUnitOfWork())
            {
                return uw.EmpleadoRepository.GetById<int>(id);
            }
        }

        public bool SaveEmpleado(Empleado entity)
        {
            bool result = false;

            try
            {
                using (var uw = new ElDoradoUnitOfWork())
                {
                    //nuevo registro
                    if (entity.Cod_emp == 0)
                    {
                        uw.EmpleadoRepository.Add(entity);
                    }
                    else
                    {
                        uw.EmpleadoRepository.Update(entity);
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
