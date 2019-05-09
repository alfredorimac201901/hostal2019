using ElDorado.Data.Acces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElDorado.Domain.Interface
{
    public interface ITipoComprobanteDomain
    {
        IEnumerable<Tipo_comprobante> GetTipo_Comprobantes(string nombre);
        Tipo_comprobante GetTipoComprobanteById(int id);
        bool SaveTipoComprobante(Tipo_comprobante entity);
        bool DeleteTipoComprobante(int id);

    }
}
