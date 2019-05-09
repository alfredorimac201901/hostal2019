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
        public IEnumerable<Tipo_comprobante> GetTipo_ComprobanteAll(string nombre)
        {
            ITipoComprobanteDomain domain = new TipoComprobanteDomain();
            return domain.GetTipo_Comprobantes(nombre);
        }

        public Tipo_comprobante GetTipo_Comprobante(int id)
        {
            ITipoComprobanteDomain domain = new TipoComprobanteDomain();
            return domain.GetTipoComprobanteById(id);
        }

        public bool SaveTipoComprobante(Tipo_comprobante entity)
        {
            ITipoComprobanteDomain domain = new TipoComprobanteDomain();
            return domain.SaveTipoComprobante(entity);
        }

        public bool DeleteTipoComprobante(int id)
        {
            ITipoComprobanteDomain domain = new TipoComprobanteDomain();
            return domain.DeleteTipoComprobante(id);
        }
    }
}
