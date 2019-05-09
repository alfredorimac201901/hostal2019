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
    public class HabitacionDomain : IHabitacionDomain
    {
        public bool DeleteHabitacion(int id)
        {
            using (var uw = new ElDoradoUnitOfWork())
            {
                return uw.HabitacionRepository.Remove(new Habitacion { Cod_hab = id });
            }
        }

        public IEnumerable<Habitacion> GetHabitacion(string nombre)
        {
            using (var uw = new ElDoradoUnitOfWork())
            {
                return uw.HabitacionRepository.GetAll();
            }
        }

        public Habitacion GetHabitacionById(int id)
        {
            using (var uw = new ElDoradoUnitOfWork())
            {
                return uw.HabitacionRepository.GetById<int>(id);
            }
        }

        public bool SaveHabitacion(Habitacion entity)
        {
            bool result = false;

            try
            {
                using (var uw = new ElDoradoUnitOfWork())
                {
                    if (entity.Cod_hab == 0)
                    {
                        uw.HabitacionRepository.Add(entity);
                    }
                    else
                    {
                        uw.HabitacionRepository.Update(entity);
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
