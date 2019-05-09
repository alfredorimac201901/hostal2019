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
         public IEnumerable<Venta> GetVentaAll(string nombre)
        {
            IVentaDomain domain = new VentaDomain();
            return domain.GetVentas(nombre);
        }
        public Venta GetVenta(int id)
        {
            IVentaDomain domain = new VentaDomain();
            return domain.GetVentaById(id);
        }
        public bool SaveVenta(Venta entity)
        {
            IVentaDomain domain = new VentaDomain();
            return domain.SaveVenta(entity);
        }
        public bool DeleteVenta(int id)
        {
            IVentaDomain domain = new VentaDomain();
            return domain.DeleteVenta(id);
        }
    }
    }

