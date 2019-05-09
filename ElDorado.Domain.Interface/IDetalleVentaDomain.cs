using ElDorado.Data.Acces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElDorado.Domain.Interface
{
    public interface IDetalleVentaDomain
    {
        IEnumerable<Detalle_venta> GetDetalleVenta(string nombre);
        Detalle_venta GetDetalleVentaById(int id);
        bool SaveDetalleVenta(Detalle_venta entity);
        bool DeleteDetalleVenta(int id);
    }
}
