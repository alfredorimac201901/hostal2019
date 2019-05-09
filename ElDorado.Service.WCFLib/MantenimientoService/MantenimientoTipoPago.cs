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
        public IEnumerable<Tipo_pago> GetTipo_pagoAll(string nombre)
        {
            ITipoPagoDomain domain = new TipoPagoDomain();
            return domain.GetTipoPago(nombre);
        }

        public Tipo_pago GetTipo_Pago (int id)
        {
            ITipoPagoDomain domain = new TipoPagoDomain();
            return domain.GetTipoPagoById(id);
        }
        public bool SaveTipoPago(Tipo_pago entity)
        {
            ITipoPagoDomain domain = new TipoPagoDomain();
            return domain.SaveTipoPago(entity);
        }

        public bool DeleteTipoPago(int id)
        {
            ITipoPagoDomain domain = new TipoPagoDomain();
            return domain.DeleteTipoPago(id);
        }

    }
}
