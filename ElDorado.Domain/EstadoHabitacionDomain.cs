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
    public class EstadoHabitacionDomain : IEstadoHabitacionDomain
    {
        public bool DeleteEstadoHabitacion(int id)
        {
            using (var uw = new ElDoradoUnitOfWork())
            {
                return uw.EstadoHabitacionRepository.Remove(new Estado_habitacion() { Cod_est_hab = id });
            }
        }

        public Estado_habitacion GetEstadoHabitacionById(int id)
        {
            using (var uw = new ElDoradoUnitOfWork())
            {
                return uw.EstadoHabitacionRepository.GetById<int>(id);
            }
        }

        public IEnumerable<Estado_habitacion> GetEstado_Habitacion(string nombre)
        {
            using (var uw = new ElDoradoUnitOfWork())
            {
                return uw.EstadoHabitacionRepository.GetAll();
            }
        }

        public bool SaveEstadoHabitacion(Estado_habitacion entity)
        {
            bool result = false;
            try
            {
                using (var uw = new ElDoradoUnitOfWork())
                {
                    if (entity.Cod_est_hab == 0)
                    {
                        uw.EstadoHabitacionRepository.Add(entity);
                    }
                    else
                    {
                        uw.EstadoHabitacionRepository.Update(entity);
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
