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
    public class VentaDomain : IVentaDomain
    {
        public bool DeleteVenta(int id)
        {
            using (var uw = new ElDoradoUnitOfWork())
            {
                return uw.VentaRepository.Remove(new Venta { Cod_ven = id });
            }
        }

        public Venta GetVentaById(int id)
        {
            using (var uw = new ElDoradoUnitOfWork())
            {
                return uw.VentaRepository.GetById<int>(id);
            }
        }

        public IEnumerable<Venta> GetVentas(string nombre)
        {
            using (var uw = new ElDoradoUnitOfWork())
            {
                return uw.VentaRepository.GetAll();
            }
        }

        public bool SaveVenta(Venta entity)
        {
            bool result = false;

            try
            {
                using (var uw = new ElDoradoUnitOfWork())
                {
                    if (entity.Cod_ven == 0)
                    {
                        uw.VentaRepository.Add(entity);
                    }
                    else
                    {
                        uw.VentaRepository.Update(entity);
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
