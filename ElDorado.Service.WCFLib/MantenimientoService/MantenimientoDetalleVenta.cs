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
       public IEnumerable<Detalle_venta> GetDetalle_VentaAll(string nombre)
        {
            IDetalleVentaDomain domain = new DetalleVentaDomain();
            return domain.GetDetalleVenta(nombre);
        }
        public Detalle_venta GetDetalle_Venta(int id)
        {
            IDetalleVentaDomain domain = new DetalleVentaDomain();
            return domain.GetDetalleVentaById(id);
        }

        public bool SaveDetalleVenta(Detalle_venta entity)
        {
            IDetalleVentaDomain domain = new DetalleVentaDomain();
            return domain.SaveDetalleVenta(entity);
        }
        public bool DeleteDetalleVenta(int id)
        {
            IDetalleVentaDomain domain = new DetalleVentaDomain();
            return domain.DeleteDetalleVenta(id);
        }
    }
}
