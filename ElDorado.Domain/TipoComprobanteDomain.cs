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
    public class TipoComprobanteDomain : ITipoComprobanteDomain
    {
        public bool DeleteTipoComprobante(int id)
        {
            using (var uw = new ElDoradoUnitOfWork())
            {
                return uw.TipoComprobanteRepository.Remove(new Tipo_comprobante { Cod_tip_com = id });
            }
        }

        public Tipo_comprobante GetTipoComprobanteById(int id)
        {
            using (var uw = new ElDoradoUnitOfWork())
            {
                return uw.TipoComprobanteRepository.GetById<int>(id);
            }
        }

        public IEnumerable<Tipo_comprobante> GetTipo_Comprobantes(string nombre)
        {
            using (var uw = new ElDoradoUnitOfWork())
            {
                return uw.TipoComprobanteRepository.GetAll();
            }
        }

        public bool SaveTipoComprobante(Tipo_comprobante entity)
        {
            bool result = false;
            try
            {
                using (var uw = new ElDoradoUnitOfWork())
                {
                    if (entity.Cod_tip_com == 0)
                    {
                        uw.TipoComprobanteRepository.Add(entity);
                    }
                    else
                    {
                        uw.TipoComprobanteRepository.Update(entity);
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
