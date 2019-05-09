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
    public class TipoHabitacionDomain : ITipoHabitacionDomain
    {
        public bool DeleteTipoHabitacion(int id)
        {
            using (var uw = new ElDoradoUnitOfWork())
            {
                return uw.TipoHabitacionRepository.Remove(new Tipo_habitacion { Cod_tip_hab = id });
            }
        }

        public Tipo_habitacion GetTipoHabitacionById(int id)
        {
            using (var uw = new ElDoradoUnitOfWork())
            {
                return uw.TipoHabitacionRepository.GetById<int>(id);
            }
        }

        public IEnumerable<Tipo_habitacion> GetTipo_Habitacions(string nombre)
        {
            using (var uw = new ElDoradoUnitOfWork())
            {
                return uw.TipoHabitacionRepository.GetAll();
            }
        }

        public bool SaveTipoHabitacion(Tipo_habitacion entity)
        {
            bool result = false;
            try
            {
                using (var uw = new ElDoradoUnitOfWork())
                {
                    if (entity.Cod_tip_hab == 0)
                    {
                        uw.TipoHabitacionRepository.Add(entity);
                    }
                    else
                    {
                        uw.TipoHabitacionRepository.Update(entity);
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
