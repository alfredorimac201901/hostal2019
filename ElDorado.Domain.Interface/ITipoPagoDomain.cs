using ElDorado.Data.Acces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElDorado.Domain.Interface
{
    public interface ITipoPagoDomain
    {
        IEnumerable<Tipo_pago> GetTipoPago(string nombre);

        Tipo_pago GetTipoPagoById(int id);

        bool SaveTipoPago(Tipo_pago entity);

        bool DeleteTipoPago(int id);
    }
}
