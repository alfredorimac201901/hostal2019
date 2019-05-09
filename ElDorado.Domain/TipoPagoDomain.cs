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
    public class TipoPagoDomain : ITipoPagoDomain
    {
        public bool DeleteTipoPago(int id)
        {
            using (var uw = new ElDoradoUnitOfWork())
            {
                return uw.TipoPagoRepository.Remove(new Tipo_pago() { Cod_tip_pag = id });
            }
        }

        public IEnumerable<Tipo_pago> GetTipoPago(string nombre)
        {
            using (var uw = new ElDoradoUnitOfWork())
            {
                return uw.TipoPagoRepository.GetAll();
            }
        }

        public Tipo_pago GetTipoPagoById(int id)
        {
            using (var uw=new ElDoradoUnitOfWork())
            {
                return uw.TipoPagoRepository.GetById<int>(id);
            }
        }

        public bool SaveTipoPago(Tipo_pago entity)
        {
            bool resul = false;
            try
            {
                using (var uw = new ElDoradoUnitOfWork())
                {
                    if (entity.Cod_tip_pag == 0)
                    {
                        uw.TipoPagoRepository.Add(entity);
                    }
                    else
                    {
                        uw.TipoPagoRepository.Update(entity);
                    }
                    uw.Complete();
                }
                resul = true;
            }
            catch (Exception ex)
            {


            }
            return resul;
        }
    }
}
