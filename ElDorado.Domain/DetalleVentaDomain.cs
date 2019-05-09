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
    public class DetalleVentaDomain : IDetalleVentaDomain
    {
        public bool DeleteDetalleVenta(int id)
        {
            using (var uw = new ElDoradoUnitOfWork())
            {
                return uw.DetalleVentaRepository.Remove(new Detalle_venta { Ite_det_ven = id });
            }
        }

        public IEnumerable<Detalle_venta> GetDetalleVenta(string nombre)
        {
            using (var uw = new ElDoradoUnitOfWork())
            {
                return uw.DetalleVentaRepository.GetAll();
            }
        }

        public Detalle_venta GetDetalleVentaById(int id)
        {
            using (var uw = new ElDoradoUnitOfWork())
            {
                return uw.DetalleVentaRepository.GetById<int>(id);
            }
        }

        public bool SaveDetalleVenta(Detalle_venta entity)
        {
            bool result = false;

            try
            {
                using (var uw = new ElDoradoUnitOfWork())
                {
                    if (entity.Ite_det_ven == 0)
                    {
                        uw.DetalleVentaRepository.Add(entity);
                    }
                    else
                    {
                        uw.DetalleVentaRepository.Update(entity);
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
